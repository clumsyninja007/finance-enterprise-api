using System;

#nullable disable

namespace FinanceEnterprise.Entities.Finance.Models.dbo.NU
{
    public class NuJobMstr
    {
        public short UsNo { get; set; }
        public string NujMask { get; set; }
        public string NujStatus { get; set; }
        public int? NujMpe { get; set; }
        public int? NujCpu { get; set; }
        public string NujProgress { get; set; }
        public string NujForm { get; set; }
        public string NujLogFlag { get; set; }
        public string NujDoFlag { get; set; }
        public string NujWfFlag { get; set; }
        public string UniqueKey { get; set; }
        public int UniqueId { get; set; }
        public int NuJobNo { get; set; }
        public string PeId { get; set; }
        public string UsId { get; set; }
        public string NujType { get; set; }
        public string NujDesc { get; set; }
        public int? NujPage { get; set; }
        public string NujUrl { get; set; }
        public string StermStrgType { get; set; }
        public string StermStrgInfo { get; set; }
        public string LtermStrgType { get; set; }
        public string LtermStrgInfo { get; set; }
        public string NujBatchFile { get; set; }
        public DateTime? NujPostDt { get; set; }
        public DateTime? NujCheckDt { get; set; }
        public DateTime? NujStartDt { get; set; }
        public DateTime? NujEndDt { get; set; }
        public DateTime? NujProgressDt { get; set; }
        public string NujStartCkId { get; set; }
        public string NujStartCkNo { get; set; }
        public string NujEndCkId { get; set; }
        public string NujEndCkNo { get; set; }
        public int? NujDocId { get; set; }
        public string NujWfModelId { get; set; }
        public int? NujWfModelVer { get; set; }
        public string NujWfInstance { get; set; }
        public string NujMiscKey { get; set; }
        public int? NujProcessId { get; set; }
        public DateTime? CreateWhen { get; set; }
        public string CreateWho { get; set; }
        public DateTime? UpdateWhen { get; set; }
        public string UpdateWho { get; set; }
    }
}
