using FinanceEnterprise.Entities.Finance.Models.dbo.HR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceEnterprise.Entities.Finance.EntityConfigs.dbo.HR
{
    internal class HrEmpmstrConfig : IEntityTypeConfiguration<HrEmpmstr>
    {
        public void Configure(EntityTypeBuilder<HrEmpmstr> entityBuilder)
        {
            entityBuilder.HasKey(e => new { e.EntityId, e.Id })
                    .HasName("hr_empmstr_PK")
                    .IsClustered(false);

            entityBuilder.ToTable("hr_empmstr");

            entityBuilder.HasIndex(e => e.UniqueId, "hr_empmstr_A")
                .IsUnique()
                .IsClustered()
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.EntityId, "hr_empmstr_B")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => new { e.EntityId, e.Bargunit }, "hr_empmstr_C")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.UniqueKey, "hr_empmstr_D")
                .IsUnique()
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => new { e.ApprvCd01, e.DefPay }, "hr_empmstr_E")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => new { e.EntityId, e.Ssn }, "hr_empmstr_F")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.Name, "hr_empmstr_G")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.Ssn, "hr_empmstr_H")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => new { e.EntityId, e.Id, e.ActionCd, e.ApprvCd01 }, "hr_empmstr_I")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => new { e.Lname, e.Fname }, "hr_empmstr_J")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.Lname, "hr_empmstr_K")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.Fname, "hr_empmstr_L")
                .HasFillFactor((byte)80);

            entityBuilder.Property(e => e.EntityId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ENTITY_ID")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Id)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ID")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.ActionCd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ACTION_CD")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Addl1)
                .HasColumnType("date")
                .HasColumnName("ADDL_1");

            entityBuilder.Property(e => e.Addl2)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("ADDL_2");

            entityBuilder.Property(e => e.Addl3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ADDL_3")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Addl4)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ADDL_4")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Age)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("age")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.ApprvCd01)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("APPRV_CD01")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.ApprvCd02)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("APPRV_CD02")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.ApprvCd03)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("APPRV_CD03")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Bargunit)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("BARGUNIT")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Bdt)
                .HasColumnType("date")
                .HasColumnName("BDT");

            entityBuilder.Property(e => e.Beg)
                .HasColumnType("date")
                .HasColumnName("BEG");

            entityBuilder.Property(e => e.BeneFte)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("BENE_FTE");

            entityBuilder.Property(e => e.Birthplace)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BIRTHPLACE")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Calendar)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CALENDAR")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Citizenshp)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CITIZENSHP")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CITY")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Ckdist)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CKDIST")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.ClassServ)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CLASS_SERV")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.ClassificationCd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("classification_cd")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Country)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("COUNTRY")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.County)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COUNTY")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.CreateErrors).HasColumnName("CREATE_ERRORS");

            entityBuilder.Property(e => e.CreateTime).HasColumnName("CREATE_TIME");

            entityBuilder.Property(e => e.CreateWhen)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_WHEN");

            entityBuilder.Property(e => e.CreateWho)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CREATE_WHO")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Cycle)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CYCLE")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.DayPatch)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DAY_PATCH")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Dayswork)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("DAYSWORK");

            entityBuilder.Property(e => e.DefPay)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DEF_PAY")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.DefPayCd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DEF_PAY_CD")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Department)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DEPARTMENT")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Dflt39)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DFLT_39")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Disability)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DISABILITY")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Distsenr)
                .HasColumnType("date")
                .HasColumnName("DISTSENR");

            entityBuilder.Property(e => e.Division)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DIVISION")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.EMail)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("E_MAIL")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.EducCd01)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("EDUC_CD01")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.EducCd02)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("EDUC_CD02")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.EmpPin)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("EMP_PIN")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.EmpPinhex)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("EMP_PINHEX")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.EmpSwitch)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("EMP_SWITCH")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Enddt)
                .HasColumnType("date")
                .HasColumnName("ENDDT");

            entityBuilder.Property(e => e.Ethnic)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ETHNIC")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.EthnicCd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ETHNIC_CD")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Expire39)
                .HasColumnType("date")
                .HasColumnName("EXPIRE_39");

            entityBuilder.Property(e => e.Ext2)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("EXT_2")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.FAdmin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("F_ADMIN")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.FlsaCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FLSA_CODE")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Fname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FNAME")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Former)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FORMER")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Fte)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("FTE");

            entityBuilder.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GENDER")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hdt)
                .HasColumnType("date")
                .HasColumnName("HDT");

            entityBuilder.Property(e => e.Hr1)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR1")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr10)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR10")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr11)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR11")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr12)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR12")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr13)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR13")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr14)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR14")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr15)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR15")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr16)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR16")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr17)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR17")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr18)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR18")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr19)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR19")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr2)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR2")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr20)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR20")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr21)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR21")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr22)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR22")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr23)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR23")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr24)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR24")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr25)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR25")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr26)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR26")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr27)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR27")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr28)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR28")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr29)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR29")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr3)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR3")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr30)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR30")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr31)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR31")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr32)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HR32")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr4)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR4")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr5)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR5")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr6)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR6")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr7)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR7")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr8)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR8")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hr9)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("HR9")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.HrStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("HR_STATUS")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Hrdate1)
                .HasColumnType("date")
                .HasColumnName("HRDATE1");

            entityBuilder.Property(e => e.Hrdate2)
                .HasColumnType("date")
                .HasColumnName("HRDATE2");

            entityBuilder.Property(e => e.Hrdate3)
                .HasColumnType("date")
                .HasColumnName("HRDATE3");

            entityBuilder.Property(e => e.Hrdate4)
                .HasColumnType("date")
                .HasColumnName("HRDATE4");

            entityBuilder.Property(e => e.Hrdate5)
                .HasColumnType("date")
                .HasColumnName("HRDATE5");

            entityBuilder.Property(e => e.Hrdate6)
                .HasColumnType("date")
                .HasColumnName("HRDATE6");

            entityBuilder.Property(e => e.Idauto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IDAUTO")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Lastdaywrk)
                .HasColumnType("date")
                .HasColumnName("LASTDAYWRK");

            entityBuilder.Property(e => e.Lastpaydt)
                .HasColumnType("date")
                .HasColumnName("LASTPAYDT");

            entityBuilder.Property(e => e.Lname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LNAME")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.LockFlag)
                .HasColumnName("LOCK_FLAG")
                .HasDefaultValueSql("((0))");

            entityBuilder.Property(e => e.Longevity)
                .HasColumnType("date")
                .HasColumnName("LONGEVITY");

            entityBuilder.Property(e => e.Lumpsum)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LUMPSUM")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.MiscCd01).HasColumnName("MISC_CD01");

            entityBuilder.Property(e => e.Mname)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MNAME")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.MnthPaid)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("MNTH_PAID");

            entityBuilder.Property(e => e.Mrt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MRT")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAME")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NclbCred)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NCLB_CRED")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Nomonths)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("NOMONTHS");

            entityBuilder.Property(e => e.Notes)
                .HasMaxLength(58)
                .IsUnicode(false)
                .HasColumnName("NOTES")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Numb1)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("NUMB1");

            entityBuilder.Property(e => e.Numb2)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("NUMB2");

            entityBuilder.Property(e => e.Numb3)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("NUMB3");

            entityBuilder.Property(e => e.Numb4)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("NUMB4");

            entityBuilder.Property(e => e.Numb5)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("NUMB5");

            entityBuilder.Property(e => e.Numb6)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("NUMB6");

            entityBuilder.Property(e => e.Numb7)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NUMB7");

            entityBuilder.Property(e => e.Numb8)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NUMB8");

            entityBuilder.Property(e => e.Numb9)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NUMB9");

            entityBuilder.Property(e => e.Over40)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OVER_40")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.PhoneCd)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PHONE_CD")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.PhoneCd2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PHONE_CD2")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.PhoneExt)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PHONE_EXT")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.PhoneNo)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("PHONE_NO")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.PhoneNo2)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("PHONE_NO2")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Possenr)
                .HasColumnType("date")
                .HasColumnName("POSSENR");

            entityBuilder.Property(e => e.Prefname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PREFNAME")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.PublPriv)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PUBL_PRIV")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.ReasAccom)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("REAS_ACCOM")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.ReqNum)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("REQ_NUM")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.RptFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RPT_FLAG")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Salannmnth).HasColumnName("SALANNMNTH");

            entityBuilder.Property(e => e.Salute)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SALUTE")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.SelCd02)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SEL_CD02")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.SenAdj).HasColumnName("SEN_ADJ");

            entityBuilder.Property(e => e.SessTime).HasColumnName("SESS_TIME");

            entityBuilder.Property(e => e.SkillCd05)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SKILL_CD05")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Ssn)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SSN")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.St1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ST_1")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.St2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ST_2")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Stat)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("STAT")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("STATE")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Suffix)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SUFFIX")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Termcode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("TERMCODE")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Termcode2)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("TERMCODE2")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Type)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("TYPE")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.UniqueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UNIQUE_ID");

            entityBuilder.Property(e => e.UniqueKey)
                .IsRequired()
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("UNIQUE_KEY")
                .HasDefaultValueSql("(newid())")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.UpdateWhen)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_WHEN");

            entityBuilder.Property(e => e.UpdateWho)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("UPDATE_WHO")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.UserOpt1)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("USER_OPT1")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.UserOpt2)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("USER_OPT2")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.UserOpt3)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("USER_OPT3")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.UserOpt4)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("USER_OPT4")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Veteran)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("VETERAN")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Worksite)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("WORKSITE")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ZIP")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Zipext)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ZIPEXT")
                .IsFixedLength(true);
        }
    }

}
