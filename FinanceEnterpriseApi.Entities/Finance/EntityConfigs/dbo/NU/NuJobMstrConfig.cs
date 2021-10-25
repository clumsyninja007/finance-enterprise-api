using FinanceEnterprise.Entities.Finance.Models.dbo.NU;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceEnterprise.Entities.Finance.EntityConfigs.dbo.NU
{
    internal class NuJobMstrConfig : IEntityTypeConfiguration<NuJobMstr>
    {
        public void Configure(EntityTypeBuilder<NuJobMstr> entityBuilder)
        {
            entityBuilder.HasKey(e => e.NuJobNo)
                .HasName("nu_job_mstr_PK")
                .IsClustered(false);

            entityBuilder.ToTable("nu_job_mstr");

            entityBuilder.HasIndex(e => e.UniqueId, "nu_job_mstr_A")
                .IsUnique()
                .IsClustered()
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.UniqueKey, "nu_job_mstr_B")
                .IsUnique()
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => new { e.NuJobNo, e.CreateWhen }, "nu_job_mstr_C")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => new { e.PeId, e.NuJobNo, e.CreateWhen }, "nu_job_mstr_D")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => new { e.NujType, e.NujStartDt, e.UpdateWhen }, "nu_job_mstr_E")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => e.UpdateWhen, "nu_job_mstr_F")
                .HasFillFactor((byte)80);

            entityBuilder.HasIndex(e => new { e.NujType, e.NujStartDt, e.CreateWhen, e.NuJobNo }, "nu_job_mstr_G")
                .HasFillFactor((byte)80);

            entityBuilder.Property(e => e.NuJobNo)
                .ValueGeneratedNever()
                .HasColumnName("nu_job_no");

            entityBuilder.Property(e => e.CreateWhen)
                .HasColumnType("datetime")
                .HasColumnName("create_when");

            entityBuilder.Property(e => e.CreateWho)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("create_who")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.LtermStrgInfo)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("lterm_strg_info")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.LtermStrgType)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("lterm_strg_type")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujBatchFile)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("nuj_batch_file")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujCheckDt)
                .HasColumnType("date")
                .HasColumnName("nuj_check_dt");

            entityBuilder.Property(e => e.NujCpu).HasColumnName("nuj_cpu");

            entityBuilder.Property(e => e.NujDesc)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("nuj_desc")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujDoFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("nuj_do_flag")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujDocId).HasColumnName("nuj_doc_id");

            entityBuilder.Property(e => e.NujEndCkId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("nuj_end_ck_id")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujEndCkNo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("nuj_end_ck_no")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujEndDt)
                .HasColumnType("datetime")
                .HasColumnName("nuj_end_dt");

            entityBuilder.Property(e => e.NujForm)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("nuj_form")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujLogFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("nuj_log_flag")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujMask)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nuj_mask")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujMiscKey)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("nuj_misc_key")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujMpe).HasColumnName("nuj_mpe");

            entityBuilder.Property(e => e.NujPage).HasColumnName("nuj_page");

            entityBuilder.Property(e => e.NujPostDt)
                .HasColumnType("date")
                .HasColumnName("nuj_post_dt");

            entityBuilder.Property(e => e.NujProcessId).HasColumnName("nuj_process_id");

            entityBuilder.Property(e => e.NujProgress)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("nuj_progress")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujProgressDt)
                .HasColumnType("datetime")
                .HasColumnName("nuj_progress_dt");

            entityBuilder.Property(e => e.NujStartCkId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("nuj_start_ck_id")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujStartCkNo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("nuj_start_ck_no")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujStartDt)
                .HasColumnType("datetime")
                .HasColumnName("nuj_start_dt");

            entityBuilder.Property(e => e.NujStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("nuj_status")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujType)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("nuj_type")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujUrl)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("nuj_url")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujWfFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("nuj_wf_flag")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujWfInstance)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("nuj_wf_instance")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujWfModelId)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("nuj_wf_model_id")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.NujWfModelVer).HasColumnName("nuj_wf_model_ver");

            entityBuilder.Property(e => e.PeId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("pe_id")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.StermStrgInfo)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("sterm_strg_info")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.StermStrgType)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("sterm_strg_type")
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

            entityBuilder.Property(e => e.UsId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("us_id")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.UsNo).HasColumnName("us_no");
        }
    }
}
