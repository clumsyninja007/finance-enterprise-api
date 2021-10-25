using System;
using FinanceEnterprise.Entities.Finance.Models.humco;

namespace FinanceEnterpriseApi.Data.Dtos.Finance.dbo
{
    public record GlTrnsDetailsDto
    {
        public string GlKey { get; init; }
        public string GlKeyName { get; init; }
        public string GlObj { get; init; }
        public string GlObjName { get; init; }
        public DateTime? TrnsDate { get; init; }
        public string Subsystem { get; init; }
        public string Ref { get; init; }
        public string Ref2 { get; init; }
        public string PEID { get; init; }
        public string TrnsDesc { get; init; }
        public decimal? Debits { get; init; }
        public decimal? Credits { get; init; }
        public int UniqueId { get; init; }
        public GlTransactionGrantNote GlTransactionGrantNote { get; init; }
    }
}
