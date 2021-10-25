using Dapper;
using FinanceEnterpriseApi.Classes;
using FinanceEnterpriseApi.Dtos.Finance;
using FinanceEnterpriseApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinanceEnterpriseApi.Controllers.Finance
{
    [AllowAnonymous]
    [Route("finance/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        private readonly SqlConnectionHelpers _helperFunctions;
        private readonly ConversionFileHelpers _conversionFileHelpers;

        public ConversionController(SqlConnectionHelpers helperFunctions,
            ConversionFileHelpers conversionFileHelpers)
        {
            _helperFunctions = helperFunctions;
            _conversionFileHelpers = conversionFileHelpers;
        }

        /// <summary>
        /// Parses a file in the FE Object to Object conversion format
        /// and searches the database for any references to the old object
        /// </summary>
        /// <param name="env"></param>
        /// <returns>A list of tables referencing the old object</returns>
        /// <response code="200">Returns the list</response>
        /// <response code="400">If the file contains any invalid object codes</response>
        [HttpGet("{env}/obj")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<List<ObjectTotalDto>>> GetObjectTotals(string env)
        {
            var actionResult = await _conversionFileHelpers.ParseObjectConversionFile("ECDEVTEN");
            var conversionFile = actionResult.Value;

            var objectTotals = new List<ObjectTotalDto>();

            var objList = "";

            // Check that the value contains only digits
            Regex rx = new(@"^\d+$");

            // Creates a list of the old Object Codes to use in the where clause of the SQL query
            foreach (var line in conversionFile)
            {
                if (!rx.Match(line.OldObj).Success)
                    return BadRequest($"Invalid Object Code: {line.OldObj}");

                objList += "'" + line.OldObj + "',";
            }

            objList = objList.TrimEnd(',');

            await using var conn = _helperFunctions.GetSqlConnection(env);
            await conn.OpenAsync();

            // check each relevant table for the object which should have been converted
            foreach (var table in ConversionTableList.TableList)
            {
                var tableLine = new ObjectTotalDto { TableName = table.TableName };

                var objColumn = table.ObjColumn;

                var sql = $@"SELECT {objColumn} AS ObjectCode
                                ,COUNT(*) AS [Count]
                                ,SUM({table.AmtColumn}) AS Amount
                            FROM {table.TableName}
                            WHERE {objColumn} IN ({objList})" +
                          $"GROUP BY {objColumn}";

                tableLine.Objects =
                    (await conn.QueryAsync<ObjectTotalLineDto>(sql, commandTimeout: 120))
                    .ToList();
                objectTotals.Add(tableLine);
            }

            return objectTotals;
        }

        /// <summary>
        /// Parses a file in the FE Key/Object to Key/Object conversion format
        /// and searches the database for any references to the old key/object pair
        /// </summary>
        /// <param name="env"></param>
        /// <returns>A list of tables referencing the old key/object pairs</returns>
        /// <response code="200">Returns the list</response>
        /// <response code="400">If the file contains any invalid key or object codes</response>
        [HttpGet("{env}/key-obj")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<List<KeyObjTotalDto>>> GetKeyObjectTotals(string env)
        {
            var actionResult = await _conversionFileHelpers.ParseKeyObjectConversionFile("ECDEVTEN");
            var conversionFile = actionResult.Value;

            var keyObjTotals = new List<KeyObjTotalDto>();

            // Check that the value contains only digits
            Regex rx = new(@"^\d+$");

            // Creates a list of the old Object Codes to use in the where clause of the SQL query
            foreach (var line in conversionFile)
            {
                if (!rx.Match(line.OldKey).Success)
                    return BadRequest($"Invalid Org Key: {line.OldKey}");

                if (!rx.Match(line.OldObj).Success)
                    return BadRequest($"Invalid Object Code: {line.OldObj}");
            }

            await using var conn = _helperFunctions.GetSqlConnection(env);
            await conn.OpenAsync();

            foreach (var table in ConversionTableList.TableList)
            {
                var tableLine = new KeyObjTotalDto
                {
                    TableName = table.TableName,
                    Objects = new List<KeyObjTotalLineDto>()
                };

                var keyColumn = table.KeyColumn;
                var objColumn = table.ObjColumn;

                foreach (var line in conversionFile)
                {
                    var sql = $@"SELECT {keyColumn} AS OrgKey
                                ,{objColumn} AS ObjectCode
                                ,COUNT(*) AS [Count]
                                ,SUM({table.AmtColumn}) AS Amount
                            FROM {table.TableName}
                            WHERE {keyColumn} = '{line.OldKey}'
                            AND {objColumn} = '{line.OldObj}'
                            GROUP BY {keyColumn}, {objColumn}";

                    var result = (await conn.QueryAsync<KeyObjTotalLineDto>(sql, commandTimeout: 120))
                        .FirstOrDefault();

                    if (result != null)
                    {
                        tableLine.Objects.Add(result);
                    }
                }

                keyObjTotals.Add(tableLine);
            }

            return keyObjTotals;
        }
    }
}
