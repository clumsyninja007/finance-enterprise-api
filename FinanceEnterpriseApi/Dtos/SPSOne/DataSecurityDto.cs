using System.Collections.Generic;

namespace FinanceEnterpriseApi.Dtos.SPSOne
{
    public class DataSecurityDto
    {
        public string Role { get; set; }
        public List<DataSecurityItemDto> Permissions { get; set; }
    }
}
