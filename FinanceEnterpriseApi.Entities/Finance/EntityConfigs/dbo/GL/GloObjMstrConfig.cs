using FinanceEnterprise.Entities.Finance.Models.dbo.GL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceEnterprise.Entities.Finance.EntityConfigs.dbo.GL
{
    internal class GloObjMstrConfig : IEntityTypeConfiguration<GloObjMstr>
    {
        public void Configure(EntityTypeBuilder<GloObjMstr> entityBuilder)
        {
            entityBuilder.HasKey(e => new { e.GloGr, e.GloObj })
                    .HasName("glo_obj_mstr_PK")
                    .IsClustered(false);

            entityBuilder.ToTable("glo_obj_mstr");

            entityBuilder.HasIndex(e => new { e.GloObj, e.GloGr }, "GL_OBJ_FASTKEY")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.UniqueId, "glo_obj_mstr_A")
                .IsUnique()
                .IsClustered()
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.UniqueKey, "glo_obj_mstr_B")
                .IsUnique()
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.GloOldNo, "glo_obj_mstr_C")
                .HasFillFactor((byte)80);

            entityBuilder.Property(e => e.GloGr)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_gr")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloObj)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_obj")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.CreateWhen)
                .HasColumnType("datetime")
                .HasColumnName("create_when");

            entityBuilder.Property(e => e.CreateWho)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("create_who")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs01)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs01")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs02)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs02")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs03)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs03")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs04)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs04")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs05)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs05")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs06)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs06")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs07)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs07")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs08)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs08")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs09)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs09")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs10)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs10")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs11)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs11")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs12)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs12")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs13)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs13")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs14)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs14")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs15)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs15")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs16)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs16")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs17)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs17")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs18)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs18")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs19)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs19")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloAllowSubs20)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glo_allow_subs20")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloBalType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_bal_type")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloCurrCd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("glo_curr_cd")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloDir)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("glo_dir")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloEndDt)
                .HasColumnType("date")
                .HasColumnName("glo_end_dt");

            entityBuilder.Property(e => e.GloGrpPart01)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_grp_part01")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloGrpPart02)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_grp_part02")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloGrpPart03)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_grp_part03")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloGrpPart04)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_grp_part04")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloGrpPart05)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_grp_part05")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloGrpPart06)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_grp_part06")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloGrpPart07)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_grp_part07")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloGrpPart08)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_grp_part08")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloObjDl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("glo_obj_dl")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloObjDm)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("glo_obj_dm")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloObjFlag01)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_obj_flag01")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloObjFlag02)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_obj_flag02")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloObjFlag03)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_obj_flag03")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloObjFlag04)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_obj_flag04")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloObjFlag05)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_obj_flag05")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloObjFlag06)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_obj_flag06")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloObjFlag07)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_obj_flag07")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloObjFlag08)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_obj_flag08")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloObjFlag09)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_obj_flag09")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloObjFlag10)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_obj_flag10")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloOldNo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_old_no")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloRecalcFlag)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_recalc_flag")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloRequireJl)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_require_jl")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart01)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part01")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart02)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part02")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart03)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part03")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart04)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part04")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart05)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part05")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart06)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part06")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart07)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part07")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart08)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part08")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart09)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part09")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart10)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part10")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart11)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part11")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart12)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part12")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart13)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part13")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart14)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part14")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart15)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part15")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart16)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part16")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart17)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part17")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart18)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part18")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart19)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part19")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart20)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part20")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart21)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part21")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart22)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part22")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart23)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part23")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart24)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part24")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart25)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part25")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart26)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part26")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart27)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part27")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart28)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part28")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart29)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part29")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart30)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part30")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart31)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part31")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloSecPart32)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glo_sec_part32")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloStartDt)
                .HasColumnType("date")
                .HasColumnName("glo_start_dt");

            entityBuilder.Property(e => e.GloStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_status")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GloType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glo_type")
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
