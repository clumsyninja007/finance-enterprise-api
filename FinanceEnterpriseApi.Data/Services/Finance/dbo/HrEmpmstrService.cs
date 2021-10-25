using FinanceEnterpriseApi.Data.Interfaces.Finance.dbo;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using FinanceEnterprise.Entities.Finance;

namespace FinanceEnterpriseApi.Data.Services.Finance.dbo
{
    public class HrEmpmstrService : IHrEmpmstrService
    {
        private readonly IDbContextFactory<FinanceContext> _financeGLContextFactory;

        public HrEmpmstrService(IDbContextFactory<FinanceContext> financeGLContextFactory)
        {
            _financeGLContextFactory = financeGLContextFactory;
        }

        public async Task<bool> EmpExistsAsync(string id)
        {
            await using var context = _financeGLContextFactory.CreateDbContext();

            return await context.HrEmpmstrs.AnyAsync(e => e.Id == id);
        }

        public async Task UpdateGenderAsync(string id, string gender)
        {
            await using var context = _financeGLContextFactory.CreateDbContext();

            var emp = await context.HrEmpmstrs.SingleAsync(e => e.Id == id);

            emp.Gender = gender;

            await context.SaveChangesAsync();
        }
    }
}
