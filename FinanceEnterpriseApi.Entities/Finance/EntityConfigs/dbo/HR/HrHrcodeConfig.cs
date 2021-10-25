using FinanceEnterprise.Entities.Finance.Models.dbo.HR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceEnterprise.Entities.Finance.EntityConfigs.dbo.HR
{
    internal class HrHrcodeConfig : IEntityTypeConfiguration<HrHrcode>
    {
        public void Configure(EntityTypeBuilder<HrHrcode> entityBuilder)
        {
            entityBuilder.HasKey(e => e.UniqueKey)
                    .HasName("hr_hrcode_PK")
                    .IsClustered(false);

            entityBuilder.ToTable("hr_hrcode");

            entityBuilder.Property(e => e.Codeid)
                .HasMaxLength(16)
                .HasColumnName("CODEID")
                .IsUnicode(false)
                .IsFixedLength(true);

            entityBuilder.Property(e => e.Codeval)
                .HasMaxLength(17)
                .HasColumnName("CODEVAL")
                .IsUnicode(false)
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

            entityBuilder.Property(e => e.LockFlag)
                .HasColumnName("LOCK_FLAG")
                .HasDefaultValue(0);

            entityBuilder.Property(e => e.LongDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LONG_DESC")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.ShortDesc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SHORT_DESC")
                .IsFixedLength(true);

            entityBuilder.Property(e => e.UniqueId)
                .HasColumnName("UNIQUE_ID")
                .HasDefaultValueSql();

            entityBuilder.Property(e => e.UniqueKey)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("UNIQUE_KEY")
                .IsFixedLength(true)
                .HasDefaultValueSql();

            entityBuilder.Property(e => e.UpdateWhen)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_WHEN");

            entityBuilder.Property(e => e.UpdateWho)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("UDPATE_WHO")
                .IsFixedLength(true);
        }
    }

}
