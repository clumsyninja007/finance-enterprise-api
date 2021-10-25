// represents data from the "spsone.spsone_datasecurity_model" table

namespace FinanceEnterpriseApi.Classes.SPSOne
{
    public class DataItem
    {
        public int Psrid { get; set; }
        public int? SpsoneDatasecurityModelParentPsrid { get; set; }
        public string ObjectName { get; set; }
        public string ObjectDescription { get; set; }
        public string ObjectType { get; set; }
    }
}
