using FinanceEnterprise.Entities.Finance.EntityConfigs.dbo.GL;
using FinanceEnterprise.Entities.Finance.EntityConfigs.dbo.HR;
using FinanceEnterprise.Entities.Finance.EntityConfigs.dbo.NU;
using FinanceEnterprise.Entities.Finance.EntityConfigs.humco;
using FinanceEnterprise.Entities.Finance.Models.dbo.GL;
using FinanceEnterprise.Entities.Finance.Models.dbo.HR;
using FinanceEnterprise.Entities.Finance.Models.dbo.NU;
using FinanceEnterprise.Entities.Finance.Models.humco;
using Microsoft.EntityFrameworkCore;

namespace FinanceEnterprise.Entities.Finance
{
    public class FinanceContext : DbContext
    {
        public FinanceContext(DbContextOptions<FinanceContext> options)
            : base(options)
        {
        }

        #region GL
        public virtual DbSet<GlTransactionGrantNote> GlTransactionGrantNotes { get; set; }
        public virtual DbSet<GltTrnsDtl> GltTrnsDtls { get; set; }
        public virtual DbSet<GlkKeyMstr> GlkKeyMstrs { get; set; }
        public virtual DbSet<GloObjMstr> GloObjMstrs { get; set; }
        #endregion

        #region HR
        public virtual DbSet<HrEmpmstr> HrEmpmstrs { get; set; }
        public virtual DbSet<HrHrcode> HrHrcodes { get; set; }
        #endregion

        #region NU
        public virtual DbSet<NuJobMstr> NuJobMstrs { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            #region GL Config
            modelBuilder.ApplyConfiguration(new GlTransactionGrantNoteConfig());
            modelBuilder.ApplyConfiguration(new GltTrnsDtlConfig());
            modelBuilder.ApplyConfiguration(new GlkKeyMstrConfig());
            modelBuilder.ApplyConfiguration(new GloObjMstrConfig());
            #endregion

            #region HR Config
            modelBuilder.ApplyConfiguration(new HrEmpmstrConfig());
            modelBuilder.ApplyConfiguration(new HrHrcodeConfig());
            #endregion

            #region NU Config
            modelBuilder.ApplyConfiguration(new NuJobMstrConfig());
            #endregion
        }
    }
}
