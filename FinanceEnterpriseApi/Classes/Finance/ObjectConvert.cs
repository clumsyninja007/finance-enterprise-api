using FinanceEnterpriseApi.Interfaces;

namespace FinanceEnterpriseApi.Classes.Finance
{
    public class ObjectConvert : IConversionFile
    {
        public string OldObj { get; set; }
        public string NewObj { get; set; }
    }
}
