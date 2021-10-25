using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinanceEnterpriseApi.Data.Dtos.Finance.humco
{
    public record PutGlTransactionGrantNotesParamsDto
    {
        [Required]
        public int? GlTrnsId { get; set; }
        public string BillingPeriod { get; set; }
        public string GrantBillingCategory { get; set; }
        public string Comments { get; set; }
        [Required]
        [DefaultValue(false)] public bool Billed { get; set; } = false;
    }
}
