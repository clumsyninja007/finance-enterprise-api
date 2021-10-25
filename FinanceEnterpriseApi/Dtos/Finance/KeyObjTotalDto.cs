using System.Collections.Generic;

namespace FinanceEnterpriseApi.Dtos.Finance
{
    public class KeyObjTotalDto
    {
        public string TableName { get; set; }
        public List<KeyObjTotalLineDto> Objects { get; set; }
    }
}
