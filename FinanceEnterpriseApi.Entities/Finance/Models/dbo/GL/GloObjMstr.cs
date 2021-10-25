using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinanceEnterprise.Entities.Finance.Models.dbo.GL
{
    public class GloObjMstr
    {
        public string GloGr { get; set; }
        public string GloObj { get; set; }
        public string GloGrpPart01 { get; set; }
        public string GloGrpPart02 { get; set; }
        public string GloGrpPart03 { get; set; }
        public string GloGrpPart04 { get; set; }
        public string GloGrpPart05 { get; set; }
        public string GloGrpPart06 { get; set; }
        public string GloGrpPart07 { get; set; }
        public string GloGrpPart08 { get; set; }
        public string GloObjDm { get; set; }
        public string GloObjDl { get; set; }
        public string GloDir { get; set; }
        public string GloObjFlag01 { get; set; }
        public string GloObjFlag02 { get; set; }
        public string GloObjFlag03 { get; set; }
        public string GloObjFlag04 { get; set; }
        public string GloObjFlag05 { get; set; }
        public string GloObjFlag06 { get; set; }
        public string GloObjFlag07 { get; set; }
        public string GloObjFlag08 { get; set; }
        public string GloObjFlag09 { get; set; }
        public string GloObjFlag10 { get; set; }
        public string GloType { get; set; }
        public string GloBalType { get; set; }
        public DateTime? GloStartDt { get; set; }
        public DateTime? GloEndDt { get; set; }
        public string GloAllowSubs01 { get; set; }
        public string GloAllowSubs02 { get; set; }
        public string GloAllowSubs03 { get; set; }
        public string GloAllowSubs04 { get; set; }
        public string GloAllowSubs05 { get; set; }
        public string GloAllowSubs06 { get; set; }
        public string GloAllowSubs07 { get; set; }
        public string GloAllowSubs08 { get; set; }
        public string GloAllowSubs09 { get; set; }
        public string GloAllowSubs10 { get; set; }
        public string GloAllowSubs11 { get; set; }
        public string GloAllowSubs12 { get; set; }
        public string GloAllowSubs13 { get; set; }
        public string GloAllowSubs14 { get; set; }
        public string GloAllowSubs15 { get; set; }
        public string GloAllowSubs16 { get; set; }
        public string GloAllowSubs17 { get; set; }
        public string GloAllowSubs18 { get; set; }
        public string GloAllowSubs19 { get; set; }
        public string GloAllowSubs20 { get; set; }
        public string GloOldNo { get; set; }
        public string GloCurrCd { get; set; }
        public string GloRecalcFlag { get; set; }
        public string GloStatus { get; set; }
        public string GloRequireJl { get; set; }
        public string CreateWho { get; set; }
        public DateTime? CreateWhen { get; set; }
        public string UpdateWho { get; set; }
        public DateTime? UpdateWhen { get; set; }
        public string UniqueKey { get; set; }
        public string GloSecPart01 { get; set; }
        public string GloSecPart02 { get; set; }
        public string GloSecPart03 { get; set; }
        public string GloSecPart04 { get; set; }
        public string GloSecPart05 { get; set; }
        public string GloSecPart06 { get; set; }
        public string GloSecPart07 { get; set; }
        public string GloSecPart08 { get; set; }
        public string GloSecPart09 { get; set; }
        public string GloSecPart10 { get; set; }
        public string GloSecPart11 { get; set; }
        public string GloSecPart12 { get; set; }
        public string GloSecPart13 { get; set; }
        public string GloSecPart14 { get; set; }
        public string GloSecPart15 { get; set; }
        public string GloSecPart16 { get; set; }
        public string GloSecPart17 { get; set; }
        public string GloSecPart18 { get; set; }
        public string GloSecPart19 { get; set; }
        public string GloSecPart20 { get; set; }
        public string GloSecPart21 { get; set; }
        public string GloSecPart22 { get; set; }
        public string GloSecPart23 { get; set; }
        public string GloSecPart24 { get; set; }
        public string GloSecPart25 { get; set; }
        public string GloSecPart26 { get; set; }
        public string GloSecPart27 { get; set; }
        public string GloSecPart28 { get; set; }
        public string GloSecPart29 { get; set; }
        public string GloSecPart30 { get; set; }
        public string GloSecPart31 { get; set; }
        public string GloSecPart32 { get; set; }
        public int UniqueId { get; set; }

        [JsonIgnore]
        public List<GltTrnsDtl> GltTrnsDtls { get; set; }

    }
}
