using System.Collections.Generic;

namespace FinanceEnterpriseApi.Dtos.Finance
{
    public class ObjectTotalDto
    {
        public string TableName { get; set; }
        public List<ObjectTotalLineDto> Objects { get; set; }
    }
}
