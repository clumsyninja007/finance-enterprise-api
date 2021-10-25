using FinanceEnterprise.Entities.Finance.Models.dbo.GL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceEnterprise.Entities.Finance.EntityConfigs.dbo.GL
{
    internal class GltTrnsDtlConfig : IEntityTypeConfiguration<GltTrnsDtl>
    {
        public void Configure(EntityTypeBuilder<GltTrnsDtl> entityBuilder)
        {
            entityBuilder.HasKey(e => e.UniqueKey)
                    .HasName("glt_trns_dtl_PK")
                    .IsClustered(false);

            entityBuilder.ToTable("glt_trns_dtl");

            entityBuilder.HasIndex(e => e.UniqueId, "glt_trns_dtl_A")
                .IsUnique()
                .IsClustered()
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => new { e.GltGlGr, e.GltGlKey, e.GltGlObj, e.GltGlFy, e.GltGlPr, e.GltDate }, "glt_trns_dtl_B")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => new { e.GltGlGr, e.GltGlKey, e.GltGlObj, e.GltGlFy, e.GltGlPr }, "glt_trns_dtl_C")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => new { e.GltJlGr, e.GltJlKey, e.GltJlObj, e.GltJlFy, e.GltJlPr, e.GltDate }, "glt_trns_dtl_D")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => new { e.GltJlGr, e.GltJlKey, e.GltJlObj, e.GltJlFy, e.GltJlPr }, "glt_trns_dtl_E")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.GltRef, "glt_trns_dtl_F")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.GltPeId, "glt_trns_dtl_G")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.GltRef2, "glt_trns_dtl_H")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.GltJobNo, "glt_trns_dtl_I")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.GltWo, "glt_trns_dtl_J")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.GltDate, "glt_trns_dtl_K")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.GltBatchId, "glt_trns_dtl_L")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => new { e.GltBatchId, e.GltRef, e.GltGlGr, e.GltGlKey, e.GltGlObj }, "glt_trns_dtl_M")
                .HasFillFactor((byte)80);

            entityBuilder.Property(e => e.UniqueKey)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("unique_key")
                .HasDefaultValueSql("(newid())")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltBatchId)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("glt_batch_id")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltCkId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glt_ck_id")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltCkNo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glt_ck_no")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltContractNo)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("glt_contract_no")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltCr)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("glt_cr");

            entityBuilder.Property(e => e.GltCurrCd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("glt_curr_cd")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltCurrRate)
                .HasColumnType("numeric(10, 7)")
                .HasColumnName("glt_curr_rate");

            entityBuilder.Property(e => e.GltDate)
                .HasColumnType("date")
                .HasColumnName("glt_date");

            entityBuilder.Property(e => e.GltDate2)
                .HasColumnType("date")
                .HasColumnName("glt_date2");

            entityBuilder.Property(e => e.GltDeleteFlag).HasColumnName("glt_delete_flag");

            entityBuilder.Property(e => e.GltDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("glt_desc")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltDr)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("glt_dr");

            entityBuilder.Property(e => e.GltEntryDate)
                .HasColumnType("date")
                .HasColumnName("glt_entry_date");

            entityBuilder.Property(e => e.GltEntryTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glt_entry_time")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltFcCr)
                .HasColumnType("numeric(20, 3)")
                .HasColumnName("glt_fc_cr");

            entityBuilder.Property(e => e.GltFcDr)
                .HasColumnType("numeric(20, 3)")
                .HasColumnName("glt_fc_dr");

            entityBuilder.Property(e => e.GltGlFy)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("glt_gl_fy")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltGlGr)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glt_gl_gr")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltGlKey)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glt_gl_key")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltGlObj)
                .IsRequired()
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glt_gl_obj")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltGlPr)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glt_gl_pr")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltJeidAcg)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("glt_jeid_acg")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltJlFy)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("glt_jl_fy")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltJlGr)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glt_jl_gr")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltJlKey)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("glt_jl_key")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltJlObj)
                .IsRequired()
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("glt_jl_obj")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltJlPr)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glt_jl_pr")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltJobNo).HasColumnName("glt_job_no");

            entityBuilder.Property(e => e.GltMisc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("glt_misc")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltOrigFy)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("glt_orig_fy")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltOrigSource)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glt_orig_source")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltPeId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("glt_pe_id")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltPedbCd)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glt_pedb_cd")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltPer)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glt_per")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltPostState)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glt_post_state")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltPrepId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("glt_prep_id")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltRef)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("glt_ref")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltRef2)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("glt_ref2")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltSeqNo).HasColumnName("glt_seq_no");

            entityBuilder.Property(e => e.GltSubsId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glt_subs_id")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltTrnsAcg)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("glt_trns_acg")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("glt_type")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltUnits)
                .HasColumnType("numeric(20, 5)")
                .HasColumnName("glt_units");

            entityBuilder.Property(e => e.GltUserNo).HasColumnName("glt_user_no");

            entityBuilder.Property(e => e.GltViewA)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glt_view_a")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltViewC)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glt_view_c")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltViewM)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glt_view_m")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltViewU)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("glt_view_u")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.GltWo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("glt_wo")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.UniqueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("unique_id");

            entityBuilder.HasOne(t => t.GlTransactionGrantNote)
                .WithOne(n => n.GltTrnsDtl);

            entityBuilder.HasOne(t => t.GlkKeyMstr)
                .WithMany(k => k.GltTrnsDtls)
                .HasForeignKey(t => t.GltGlKey)
                .HasPrincipalKey(k => k.GlkKey);

            entityBuilder.HasOne(t => t.GloObjMstr)
                .WithMany(k => k.GltTrnsDtls)
                .HasForeignKey(t => t.GltGlObj)
                .HasPrincipalKey(k => k.GloObj);
        }
    }

}
