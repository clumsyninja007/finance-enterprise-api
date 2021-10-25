using FinanceEnterprise.Entities.Finance.Models.dbo.GL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceEnterprise.Entities.Finance.EntityConfigs.dbo.GL
{
    internal class GlkKeyMstrConfig : IEntityTypeConfiguration<GlkKeyMstr>
    {
        public void Configure(EntityTypeBuilder<GlkKeyMstr> entityBuilder)
        {
            entityBuilder.HasKey(e => new { e.GlkGr, e.GlkKey })
                    .HasName("glk_key_mstr_PK")
                    .IsClustered(false);

            entityBuilder.ToTable("glk_key_mstr");

            entityBuilder.HasIndex(e => new { e.GlkKey, e.GlkGr }, "GL_KEY_FASTKEY")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.UniqueId, "glk_key_mstr_A")
                .IsUnique()
                .IsClustered()
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.UniqueKey, "glk_key_mstr_B")
                .IsUnique()
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.GlkOldKey, "glk_key_mstr_C")
                .HasFillFactor((byte)80);

            entityBuilder.Property(e => e.GlkGr)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_gr")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkKey)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_key")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.CreateWhen)
                .HasColumnType("datetime")
                .HasColumnName("create_when");

            entityBuilder.Property(e => e.CreateWho)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("create_who")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkAcceptTr)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_accept_tr")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkAllocBw)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glk_alloc_bw")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkAllocLev)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_alloc_lev")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkBlockWarn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glk_block_warn")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkBudgClCd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("glk_budg_cl_cd")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkBudgLev)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_budg_lev")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkCopyKey)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_copy_key")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkDerived)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_derived")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkDir)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("glk_dir")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkEndDt)
                .HasColumnType("date")
                .HasColumnName("glk_end_dt");

            entityBuilder.Property(e => e.GlkFqa)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("glk_fqa")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkGroup)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_group")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkGrpPart01)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_grp_part01")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkGrpPart02)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_grp_part02")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkGrpPart03)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_grp_part03")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkGrpPart04)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_grp_part04")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkGrpPart05)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_grp_part05")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkGrpPart06)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_grp_part06")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkGrpPart07)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_grp_part07")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkGrpPart08)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_grp_part08")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkKeyFlag01)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_key_flag01")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkKeyFlag02)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_key_flag02")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkKeyFlag03)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_key_flag03")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkKeyFlag04)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_key_flag04")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkKeyFlag05)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_key_flag05")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkKeyFlag06)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_key_flag06")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkKeyFlag07)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_key_flag07")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkKeyFlag08)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_key_flag08")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkKeyFlag09)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_key_flag09")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkKeyFlag10)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_key_flag10")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkMisc01)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_misc01")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkMisc02)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_misc02")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkMisc03)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_misc03")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkMisc04)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_misc04")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkMisc05)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_misc05")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkMisc06)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_misc06")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkMisc07)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_misc07")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkMisc08)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_misc08")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkObjTypes01)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_obj_types01")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkObjTypes02)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_obj_types02")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkObjTypes03)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_obj_types03")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkObjTypes04)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_obj_types04")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkObjTypes05)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_obj_types05")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkObjTypes06)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_obj_types06")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkOldKey)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_old_key")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkOverKey)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_over_key")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkOverVers)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_over_vers")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkPlanEnd)
                .HasColumnType("date")
                .HasColumnName("glk_plan_end");

            entityBuilder.Property(e => e.GlkPlanStart)
                .HasColumnType("date")
                .HasColumnName("glk_plan_start");

            entityBuilder.Property(e => e.GlkReqAssoc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_req_assoc")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkRequireJl)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glk_require_jl")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart01)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part01")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart02)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part02")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart03)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part03")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart04)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part04")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart05)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part05")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart06)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part06")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart07)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part07")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart08)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part08")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart09)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part09")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart10)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part10")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart11)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part11")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart12)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part12")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart13)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part13")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart14)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part14")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart15)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part15")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart16)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part16")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart17)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part17")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart18)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part18")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart19)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part19")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart20)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part20")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart21)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part21")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart22)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part22")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart23)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part23")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart24)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part24")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart25)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part25")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart26)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part26")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart27)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part27")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart28)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part28")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart29)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part29")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart30)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part30")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart31)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part31")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSecPart32)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glk_sec_part32")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSelCode01)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_sel_code01")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSelCode02)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_sel_code02")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSelCode03)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_sel_code03")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSelCode04)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_sel_code04")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSelCode05)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_sel_code05")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSelCode06)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_sel_code06")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSelCode07)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_sel_code07")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkSelCode08)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glk_sel_code08")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkStartDt)
                .HasColumnType("date")
                .HasColumnName("glk_start_dt");

            entityBuilder.Property(e => e.GlkStat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glk_stat")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkTitleDl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("glk_title_dl")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkTitleDm)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("glk_title_dm")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GlkType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glk_type")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.UniqueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("unique_id");

            entityBuilder.Property(e => e.UniqueKey)
                .IsRequired()
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("unique_key")
                .HasDefaultValueSql("(newid())")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.UpdateWhen)
                .HasColumnType("datetime")
                .HasColumnName("update_when");

            entityBuilder.Property(e => e.UpdateWho)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("update_who")
                .IsFixedLength(true);
        }

    }
}
