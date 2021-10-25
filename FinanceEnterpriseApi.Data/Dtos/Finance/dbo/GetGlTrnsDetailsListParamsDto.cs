using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinanceEnterpriseApi.Data.Dtos.Finance.dbo
{
    public record GetGlTrnsDetailsListParamsDto
    {
        [Required]
        public DateTime? StartDate { get; init; }
        [Required]
        public DateTime? EndDate { get; set; }
        public string GlKey { get; init; }
        public string GlObj { get; init; }
        [DefaultValue(50)]
        public int Limit { get; init; } = 50;
        [DefaultValue(1)]
        public int Page { get; init; } = 1;
    }
}
