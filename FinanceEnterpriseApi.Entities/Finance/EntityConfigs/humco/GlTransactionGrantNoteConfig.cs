using FinanceEnterprise.Entities.Finance.Models.dbo.GL;
using FinanceEnterprise.Entities.Finance.Models.humco;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceEnterprise.Entities.Finance.EntityConfigs.humco
{
    internal class GlTransactionGrantNoteConfig : IEntityTypeConfiguration<GlTransactionGrantNote>
    {
        public void Configure(EntityTypeBuilder<GlTransactionGrantNote> entityBuilder)
        {
            entityBuilder.HasKey(e => e.GlTrnsId)
                .HasName("PK__gl_trans__4BA89E991F7C0405");

            entityBuilder.ToTable("gl_transaction_grant_notes", "humco");

            entityBuilder.Property(e => e.GlTrnsId)
                .ValueGeneratedNever()
                .HasColumnName("gl_trns_id");

            entityBuilder.Property(e => e.BillingPeriod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("billing_period");

            entityBuilder.Property(e => e.Comments)
                .IsUnicode(false)
                .HasColumnName("comments");

            entityBuilder.Property(e => e.GrantBillingCategory)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grant_billing_category");

            entityBuilder.Property(e => e.Billed)
                .HasColumnName("billed");

            entityBuilder.HasOne(t => t.GltTrnsDtl)
                .WithOne(n => n.GlTransactionGrantNote)
                .HasForeignKey<GlTransactionGrantNote>(n => n.GlTrnsId)
                .HasPrincipalKey<GltTrnsDtl>(t => t.UniqueId);
        }
    }

}
