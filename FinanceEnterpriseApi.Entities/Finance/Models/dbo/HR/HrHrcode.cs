using System;

namespace FinanceEnterprise.Entities.Finance.Models.dbo.HR
{
    public class HrHrcode
    {
        public string Codeid { get; set; }
        public string Codeval { get; set; }
        public int? CreateErrors { get; set; }
        public int? CreateTime { get; set; }
        public DateTime? CreateWhen { get; set; }
        public string CreateWho { get; set; }
        public int LockFlag { get; set; }
        public string LongDesc { get; set; }
        public string ShortDesc { get; set; }
        public int UniqueId { get; set; }
        public string UniqueKey { get; set; }
        public DateTime? UpdateWhen { get; set; }
        public string UpdateWho { get; set; }

    }
}
