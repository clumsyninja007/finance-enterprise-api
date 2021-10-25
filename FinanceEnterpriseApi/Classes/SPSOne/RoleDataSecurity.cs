// represents data from the "spsone.spsone_datasecurity_model__spsone_role" table

namespace FinanceEnterpriseApi.Classes.SPSOne
{
    public class RoleDataSecurity
    {
        public int Psrid { get; set; }
        public int SpsoneDatasecurityModelPsrid { get; set; }
        public int SpsoneRolePsrid { get; set; }
        public char AccessRead { get; set; }
        public char AccessWrite { get; set; }
        public char AccessUpdate { get; set; }
        public char AccessDelete { get; set; }
        public char AccessExecute { get; set; }
        public string AccessXml { get; set; }
    }
}
