using FinanceEnterpriseApi.Data.Interfaces.Finance.dbo;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using FinanceEnterprise.Entities.Finance;

namespace FinanceEnterpriseApi.Data.Services.Finance.dbo
{
    public class HrHrcodeService : IHrHrcodeService
    {
        private readonly IDbContextFactory<FinanceContext> _financeGLContextFactory;

        public HrHrcodeService(IDbContextFactory<FinanceContext> financeGLContextFactory)
        {
            _financeGLContextFactory = financeGLContextFactory;
        }

        public Task<bool> CodeExistsAsync(string id, string val)
        {
            using var context = _financeGLContextFactory.CreateDbContext();

            return context.HrHrcodes
                .AsNoTracking()
                .AnyAsync(c => c.Codeid == id && c.Codeval == val);
        }
    }
}
