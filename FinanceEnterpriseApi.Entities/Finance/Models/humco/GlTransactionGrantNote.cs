using System.Text.Json.Serialization;
using FinanceEnterprise.Entities.Finance.Models.dbo.GL;

namespace FinanceEnterprise.Entities.Finance.Models.humco
{
    public class GlTransactionGrantNote
    {
        public int GlTrnsId { get; set; }
        public string BillingPeriod { get; set; }
        public string GrantBillingCategory { get; set; }
        public string Comments { get; set; }
        public bool Billed { get; set; }

        [JsonIgnore]
        public GltTrnsDtl GltTrnsDtl { get; set; }

    }
}
