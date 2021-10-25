// represents data from the "spsone.spsone_manifest_model__spsone_role" table

namespace FinanceEnterpriseApi.Classes.SPSOne
{
    public class RoleMenuSecurity
    {
        public int Psrid { get; set; }
        public int SpsoneManifestModelPsrid { get; set; }
        public int SpsoneRolePsrid { get; set; }
        public char AccessExecute { get; set; }
    }
}
