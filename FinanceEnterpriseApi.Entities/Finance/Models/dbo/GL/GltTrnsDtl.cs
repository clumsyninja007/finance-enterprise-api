using System;
using FinanceEnterprise.Entities.Finance.Models.humco;

namespace FinanceEnterprise.Entities.Finance.Models.dbo.GL
{
    public class GltTrnsDtl
    {
        public string GltGlGr { get; set; }
        public string GltGlKey { get; set; }
        public string GltGlObj { get; set; }
        public string GltGlFy { get; set; }
        public string GltGlPr { get; set; }
        public string GltJlGr { get; set; }
        public string GltJlKey { get; set; }
        public string GltJlObj { get; set; }
        public string GltJlFy { get; set; }
        public string GltJlPr { get; set; }
        public string GltRef { get; set; }
        public string GltPeId { get; set; }
        public string GltPer { get; set; }
        public string GltType { get; set; }
        public string GltDesc { get; set; }
        public string GltMisc { get; set; }
        public string GltRef2 { get; set; }
        public DateTime? GltDate2 { get; set; }
        public string GltBatchId { get; set; }
        public decimal? GltDr { get; set; }
        public decimal? GltCr { get; set; }
        public string GltSubsId { get; set; }
        public string GltPedbCd { get; set; }
        public string GltCkId { get; set; }
        public string GltCkNo { get; set; }
        public decimal? GltUnits { get; set; }
        public int? GltJobNo { get; set; }
        public string GltWo { get; set; }
        public decimal? GltFcDr { get; set; }
        public decimal? GltFcCr { get; set; }
        public string GltCurrCd { get; set; }
        public decimal? GltCurrRate { get; set; }
        public short? GltUserNo { get; set; }
        public short? GltSeqNo { get; set; }
        public DateTime? GltDate { get; set; }
        public string GltPrepId { get; set; }
        public string GltContractNo { get; set; }
        public string GltOrigFy { get; set; }
        public string GltJeidAcg { get; set; }
        public string GltTrnsAcg { get; set; }
        public DateTime? GltEntryDate { get; set; }
        public string GltEntryTime { get; set; }
        public string GltViewA { get; set; }
        public string GltViewC { get; set; }
        public string GltViewM { get; set; }
        public string GltViewU { get; set; }
        public string GltPostState { get; set; }
        public short? GltDeleteFlag { get; set; }
        public string UniqueKey { get; set; }
        public int UniqueId { get; set; }
        public string GltOrigSource { get; set; }

        public GlTransactionGrantNote GlTransactionGrantNote { get; set; }
        public GlkKeyMstr GlkKeyMstr { get; set; }
        public GloObjMstr GloObjMstr { get; set; }

    }
}
