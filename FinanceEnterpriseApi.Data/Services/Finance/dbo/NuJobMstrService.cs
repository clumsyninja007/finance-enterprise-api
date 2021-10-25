using FinanceEnterpriseApi.Data.Interfaces.Finance.dbo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using FinanceEnterprise.Entities.Finance;

namespace FinanceEnterpriseApi.Data.Services.Finance.dbo
{
    public class NuJobMstrService : INuJobMstrService
    {
        private readonly IDbContextFactory<FinanceContext> _financeGlContextFactory;

        public NuJobMstrService(IDbContextFactory<FinanceContext> financeGlContextFactory)
        {
            _financeGlContextFactory = financeGlContextFactory;
        }

        public async Task<string> GetJobStatusAsync(int jobNo)
        {
            await using var context = _financeGlContextFactory.CreateDbContext();

            var job = await context.NuJobMstrs
                .AsNoTracking()
                .FirstOrDefaultAsync(j => j.NuJobNo == jobNo);

            if (job == null)
            {
                throw new ArgumentException("Job not found", nameof(jobNo));
            }

            return job.NujStatus;
        }
    }
}
