namespace FinanceEnterpriseApi.Dtos.SPSOne
{
    public class DataSecurityItemDto
    {
        public string Data { get; set; }
        public char AccessRead { get; set; }
        public char AccessWrite { get; set; }
        public char AccessUpdate { get; set; }
        public char AccessDelete { get; set; }
        public char AccessExecute { get; set; }
        public string AccessXml { get; set; }
    }
}
