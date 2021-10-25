using Dapper;
using FinanceEnterpriseApi.Classes.SPSOne;
using FinanceEnterpriseApi.Dtos.SPSOne;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceEnterpriseApi.Controllers.Spsone
{
    [AllowAnonymous]
    [Route("[controller]")]
    [ApiController]
    public class SpsOneController : ControllerBase
    {
        private readonly IDbConnection _connection;

        public SpsOneController(IConfiguration configuration)
        {
            _connection = new SqlConnection(configuration.GetConnectionString("SPSOneDb"));
        }

        // GET: api/SPSOne/Roles
        [HttpGet("Roles")]
        public Task<IEnumerable<Role>> GetSpsOneRoles()
        {
            // get a list of all roles in SPSOne
            const string sql = @"SELECT psrid
                        ,display_name
                        ,description
                        FROM spsone.spsone_role";

            return _connection.QueryAsync<Role>(sql);
        }

        // GET: api/SPSOne/Roles/id
        [HttpGet("Roles/{psrid}")]
        public Task<Role> GetSpsOneRole(int psrid)
        {
            // get a single role from SPSOne
            const string sql = @"SELECT psrid
                        ,display_name
                        ,description
                        FROM spsone.spsone_role
                        WHERE psrid = @psrid";

            return _connection.QueryFirstOrDefaultAsync<Role>(sql, new { psrid });
        }

        #region Menu Security
        // GET: api/SPSOne/MenuItems
        [HttpGet("MenuItems")]
        public Task<IEnumerable<MenuItem>> GetMenuItems()
        {
            const string sql = @"SELECT psrid
                                ,spsone_manifest_model_parent_psrid
                                ,object_id
                                ,object_description
                                ,object_type
                                FROM spsone.spsone_manifest_model";

            return _connection.QueryAsync<MenuItem>(sql);
        }

        // GET: api/SPSOne/Menu
        [HttpGet("Menu")]
        public async Task<ActionResult<List<MenuSecurityDto>>> GetSpsOneMenuPermissions([FromQuery] int? roleId, int? itemId, bool yesOnly = false)
        {
            if (roleId == null && itemId == null) return BadRequest();

            // get a list of all roles in SPSOne
            var roles = await GetSpsOneRoles();

            roles = roleId != null ?
                roles.Where(r => r.Psrid == roleId) :
                roles;

            // get a list of all securable menu items for looping through parent relationships
            var menuItems = (await GetMenuItems()).ToList();

            // copy the list and filter it so we can iterate through only roles we care about
            // while preserving the parent relationships
            var filteredMenuItems = itemId == null ?
                menuItems :
                menuItems.Where(m => m.Psrid == itemId).ToList()
                ;

            var menuOutput = new List<MenuSecurityDto>();

            foreach (var role in roles)
            {
                var securityItem = new MenuSecurityDto
                {
                    Role = role.DisplayName,
                    Permissions = new List<MenuSecurityItemDto>()
                };

                // permissions in SPSOne are derived from its parent unless explicitly defined
                // we're creating a list of all explicit permissions
                const string sql = @"SELECT *
                        FROM spsone.spsone_manifest_model__spsone_role
                        WHERE spsone_role_psrid = @Psrid";

                var explicitPermissions = (await _connection
                    .QueryAsync<RoleMenuSecurity>(sql, new { role.Psrid }))
                    .ToList();

                foreach (var menuItem in filteredMenuItems)
                {
                    // set permissions of any menu items with explicit access defined
                    if (explicitPermissions.Any(p => p.SpsoneManifestModelPsrid == menuItem.Psrid))
                    {
                        var explicitItem = new MenuSecurityItemDto
                        {
                            MenuObject = menuItem.ObjectDescription,
                            AccessExecute = explicitPermissions
                                .First(p => p.SpsoneManifestModelPsrid == menuItem.Psrid)
                                .AccessExecute
                        };

                        if (yesOnly && explicitItem.AccessExecute == 'Y' || !yesOnly)
                            securityItem.Permissions.Add(explicitItem);
                    }
                    // chain through parents until we find an explicit permission
                    // or reach the top with no explicit permissions defined
                    else if (menuItem.SpsoneManifestModelParentPsrid != null)
                    {
                        var parent = menuItems.First(m => m.Psrid == menuItem.SpsoneManifestModelParentPsrid);

                        while (explicitPermissions.All(p => p.SpsoneManifestModelPsrid != parent.Psrid)
                               && parent.SpsoneManifestModelParentPsrid != null)
                        {
                            // if the parent has no explicit permissions, and the parent has a parent,
                            // grab the parent's parent
                            parent = menuItems.First(m => m.Psrid == parent.SpsoneManifestModelParentPsrid);
                        }

                        var parentPermissions = explicitPermissions
                            .FirstOrDefault(p => p.SpsoneManifestModelPsrid == parent.Psrid);

                        if (yesOnly && parentPermissions?.AccessExecute == 'Y' || !yesOnly)
                        {
                            securityItem.Permissions.Add(new MenuSecurityItemDto
                            {
                                MenuObject = menuItem.ObjectDescription,
                                AccessExecute = parentPermissions?.AccessExecute ?? 'N'
                            });
                        }
                    }
                    // top level derived permissions are the same as no permissions
                    else
                    {
                        if (!yesOnly)
                        {
                            securityItem.Permissions.Add(new MenuSecurityItemDto
                            {
                                MenuObject = menuItem.ObjectDescription,
                                AccessExecute = 'N'
                            });
                        }
                    }
                }

                if (securityItem.Permissions.Count > 0)
                {
                    menuOutput.Add(securityItem);
                }
            }
            return menuOutput;
        }
        #endregion

        #region Data Security
        // GET: api/SPSOne/DataItems
        [HttpGet("DataItems")]
        public Task<IEnumerable<DataItem>> GetDataItems()
        {
            const string sql = @"SELECT psrid
                                ,spsone_datasecurity_model_parent_psrid
                                ,object_name
                                ,object_description
                                ,object_type
                                FROM spsone.spsone_datasecurity_model";

            return _connection.QueryAsync<DataItem>(sql);
        }

        // GET: api/SPSOne/data
        [HttpGet("Data")]
        public async Task<ActionResult<List<DataSecurityDto>>> GetSpsOneDataSecurity([FromQuery] int? roleId, int? itemId)
        {
            if (roleId == null && itemId == null) return BadRequest();

            // get a list of all roles in SPSOne
            var roles = await GetSpsOneRoles();

            roles = roleId != null ?
                roles.Where(r => r.Psrid == roleId) :
                roles;

            // get a list of all securable data items for looping through parent relationships
            var dataItems = (await GetDataItems()).ToList();

            // copy the list and filter it so we can iterate through only roles we care about
            // while preserving the parent relationships
            var filteredDataItems = itemId == null ?
                dataItems :
                dataItems.Where(f => f.Psrid == itemId).ToList();

            var dataOutput = new List<DataSecurityDto>();

            foreach (var role in roles)
            {
                var securityItem = new DataSecurityDto
                {
                    Role = role.DisplayName,
                    Permissions = new List<DataSecurityItemDto>()
                };

                // permissions in SPSOne are derived from its parent unless explicitly defined
                // we're creating a list of all explicit permissions
                const string sql = @"SELECT *
                        FROM spsone.spsone_datasecurity_model__spsone_role
                        WHERE spsone_role_psrid = @Psrid";

                var explicitPermissions = (await _connection
                    .QueryAsync<RoleDataSecurity>(sql, new { role.Psrid }))
                    .ToList();

                foreach (var dataItem in filteredDataItems)
                {
                    // set permissions of any data items with explicit access defined
                    if (explicitPermissions.Any(p => p.SpsoneDatasecurityModelPsrid == dataItem.Psrid))
                    {
                        var explicitPermission = explicitPermissions
                            .First(p => p.SpsoneDatasecurityModelPsrid == dataItem.Psrid);

                        var explicitItem = new DataSecurityItemDto
                        {
                            Data = dataItem.ObjectDescription,
                            AccessRead = explicitPermission.AccessRead,
                            AccessWrite = explicitPermission.AccessWrite,
                            AccessUpdate = explicitPermission.AccessUpdate,
                            AccessDelete = explicitPermission.AccessDelete,
                            AccessExecute = explicitPermission.AccessExecute,
                            AccessXml = explicitPermission.AccessXml
                        };

                        securityItem.Permissions.Add(explicitItem);
                    }
                    // chain through parents until we find an explicit permission
                    // or reach the top with no explicit permissions defined
                    else if (dataItem.SpsoneDatasecurityModelParentPsrid != null)
                    {
                        var parent = dataItems.First(m => m.Psrid == dataItem.SpsoneDatasecurityModelParentPsrid);

                        while (explicitPermissions.All(p => p.SpsoneDatasecurityModelPsrid != parent.Psrid)
                               && parent.SpsoneDatasecurityModelParentPsrid != null)
                        {
                            // if the parent has no explicit permissions, and the parent has a parent,
                            // grab the parent's parent
                            parent = dataItems.First(m => m.Psrid == parent.SpsoneDatasecurityModelParentPsrid);
                        }

                        var parentPermissions = explicitPermissions
                            .FirstOrDefault(p => p.SpsoneDatasecurityModelPsrid == parent.Psrid);

                        securityItem.Permissions.Add(new DataSecurityItemDto
                        {
                            Data = dataItem.ObjectDescription,
                            AccessRead = parentPermissions?.AccessRead ?? 'N',
                            AccessWrite = parentPermissions?.AccessWrite ?? 'N',
                            AccessUpdate = parentPermissions?.AccessUpdate ?? 'N',
                            AccessDelete = parentPermissions?.AccessDelete ?? 'N',
                            AccessExecute = parentPermissions?.AccessExecute ?? 'N',
                            AccessXml = parentPermissions?.AccessXml ?? ""
                        });
                    }
                    // top level derived permissions are the same as no permissions
                    else
                    {
                        securityItem.Permissions.Add(new DataSecurityItemDto
                        {
                            Data = dataItem.ObjectDescription,
                            AccessExecute = 'N'
                        });
                    }
                }

                if (securityItem.Permissions.Count > 0)
                {
                    dataOutput.Add(securityItem);
                }
            }
            return dataOutput;
        }
        #endregion
    }
}