// represents data from the "spsone.spsone_manifest_model" table

namespace FinanceEnterpriseApi.Classes.SPSOne
{
    public class MenuItem
    {
        public int Psrid { get; set; }
        public int? SpsoneManifestModelParentPsrid { get; set; }
        public string ObjectId { get; set; }
        public string ObjectDescription { get; set; }
        public string ObjectType { get; set; }
    }
}
