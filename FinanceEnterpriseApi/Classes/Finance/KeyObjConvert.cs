using FinanceEnterpriseApi.Interfaces;

namespace FinanceEnterpriseApi.Classes.Finance
{
    public class KeyObjConvert : IConversionFile
    {
        public string OldKey { get; set; }
        public string OldObj { get; set; }
        public string NewKey { get; set; }
        public string NewObj { get; set; }
    }
}
