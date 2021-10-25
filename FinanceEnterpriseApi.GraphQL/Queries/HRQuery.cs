using HotChocolate;
using HotChocolate.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceEnterprise.Entities.Finance;
using FinanceEnterprise.Entities.Finance.Models.dbo.HR;

namespace FinanceEnterpriseApi.GraphQL.Queries
{
    public class HRQuery
    {
        [UseDbContext(typeof(FinanceContext))]
        public Task<List<HrEmpmstr>> GetHrEmpmstrActiveAsync(
            [ScopedService] FinanceContext financeContext)
            => financeContext.HrEmpmstrs.AsNoTracking().Where(n => n.Stat == "A").ToListAsync();

        [UseDbContext(typeof(FinanceContext))]
        public Task<HrEmpmstr> GetHrEmpmstrByIdAsync(
            [ScopedService] FinanceContext financeContext, string id)
            => financeContext.HrEmpmstrs.AsNoTracking().Where(n => n.Id == id).FirstOrDefaultAsync();

        [UseDbContext(typeof(FinanceContext))]
        public Task<List<HrHrcode>> GetHrHrcodesByCodeIdAsync(
            [ScopedService] FinanceContext financeContext, string id)
            => financeContext.HrHrcodes.AsNoTracking().Where(c => c.Codeid == id).ToListAsync();
    }
}
