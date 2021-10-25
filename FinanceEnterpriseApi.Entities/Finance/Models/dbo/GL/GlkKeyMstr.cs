using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinanceEnterprise.Entities.Finance.Models.dbo.GL
{
    public class GlkKeyMstr
    {
        public string GlkGr { get; set; }
        public string GlkKey { get; set; }
        public string GlkGrpPart01 { get; set; }
        public string GlkGrpPart02 { get; set; }
        public string GlkGrpPart03 { get; set; }
        public string GlkGrpPart04 { get; set; }
        public string GlkGrpPart05 { get; set; }
        public string GlkGrpPart06 { get; set; }
        public string GlkGrpPart07 { get; set; }
        public string GlkGrpPart08 { get; set; }
        public string GlkTitleDm { get; set; }
        public string GlkTitleDl { get; set; }
        public string GlkDir { get; set; }
        public string GlkStat { get; set; }
        public string GlkType { get; set; }
        public string GlkGroup { get; set; }
        public string GlkBudgClCd { get; set; }
        public string GlkAllocBw { get; set; }
        public string GlkAllocLev { get; set; }
        public string GlkOverKey { get; set; }
        public string GlkBlockWarn { get; set; }
        public string GlkBudgLev { get; set; }
        public string GlkOverVers { get; set; }
        public string GlkReqAssoc { get; set; }
        public string GlkObjTypes01 { get; set; }
        public string GlkObjTypes02 { get; set; }
        public string GlkObjTypes03 { get; set; }
        public string GlkObjTypes04 { get; set; }
        public string GlkObjTypes05 { get; set; }
        public string GlkObjTypes06 { get; set; }
        public string GlkDerived { get; set; }
        public string GlkAcceptTr { get; set; }
        public string GlkRequireJl { get; set; }
        public string GlkMisc01 { get; set; }
        public string GlkMisc02 { get; set; }
        public string GlkMisc03 { get; set; }
        public string GlkMisc04 { get; set; }
        public string GlkMisc05 { get; set; }
        public string GlkMisc06 { get; set; }
        public string GlkMisc07 { get; set; }
        public string GlkMisc08 { get; set; }
        public string GlkCopyKey { get; set; }
        public DateTime? GlkStartDt { get; set; }
        public DateTime? GlkEndDt { get; set; }
        public string GlkKeyFlag01 { get; set; }
        public string GlkKeyFlag02 { get; set; }
        public string GlkKeyFlag03 { get; set; }
        public string GlkKeyFlag04 { get; set; }
        public string GlkKeyFlag05 { get; set; }
        public string GlkKeyFlag06 { get; set; }
        public string GlkKeyFlag07 { get; set; }
        public string GlkKeyFlag08 { get; set; }
        public string GlkKeyFlag09 { get; set; }
        public string GlkKeyFlag10 { get; set; }
        public string GlkOldKey { get; set; }
        public string GlkSelCode01 { get; set; }
        public string GlkSelCode02 { get; set; }
        public string GlkSelCode03 { get; set; }
        public string GlkSelCode04 { get; set; }
        public string GlkSelCode05 { get; set; }
        public string GlkSelCode06 { get; set; }
        public string GlkSelCode07 { get; set; }
        public string GlkSelCode08 { get; set; }
        public string CreateWho { get; set; }
        public DateTime? CreateWhen { get; set; }
        public string UpdateWho { get; set; }
        public DateTime? UpdateWhen { get; set; }
        public string UniqueKey { get; set; }
        public string GlkSecPart01 { get; set; }
        public string GlkSecPart02 { get; set; }
        public string GlkSecPart03 { get; set; }
        public string GlkSecPart04 { get; set; }
        public string GlkSecPart05 { get; set; }
        public string GlkSecPart06 { get; set; }
        public string GlkSecPart07 { get; set; }
        public string GlkSecPart08 { get; set; }
        public string GlkSecPart09 { get; set; }
        public string GlkSecPart10 { get; set; }
        public string GlkSecPart11 { get; set; }
        public string GlkSecPart12 { get; set; }
        public string GlkSecPart13 { get; set; }
        public string GlkSecPart14 { get; set; }
        public string GlkSecPart15 { get; set; }
        public string GlkSecPart16 { get; set; }
        public string GlkSecPart17 { get; set; }
        public string GlkSecPart18 { get; set; }
        public string GlkSecPart19 { get; set; }
        public string GlkSecPart20 { get; set; }
        public string GlkSecPart21 { get; set; }
        public string GlkSecPart22 { get; set; }
        public string GlkSecPart23 { get; set; }
        public string GlkSecPart24 { get; set; }
        public string GlkSecPart25 { get; set; }
        public string GlkSecPart26 { get; set; }
        public string GlkSecPart27 { get; set; }
        public string GlkSecPart28 { get; set; }
        public string GlkSecPart29 { get; set; }
        public string GlkSecPart30 { get; set; }
        public string GlkSecPart31 { get; set; }
        public string GlkSecPart32 { get; set; }
        public int UniqueId { get; set; }
        public string GlkFqa { get; set; }
        public DateTime? GlkPlanStart { get; set; }
        public DateTime? GlkPlanEnd { get; set; }

        [JsonIgnore]
        public List<GltTrnsDtl> GltTrnsDtls { get; set; }

    }
}
