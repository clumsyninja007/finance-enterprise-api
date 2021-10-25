using System.Collections.Generic;

namespace FinanceEnterpriseApi.Dtos.SPSOne
{
    public class MenuSecurityDto
    {
        public string Role { get; set; }
        public List<MenuSecurityItemDto> Permissions { get; set; }
    }
}
