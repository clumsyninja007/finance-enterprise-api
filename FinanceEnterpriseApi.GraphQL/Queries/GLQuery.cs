using FinanceEnterpriseApi.GraphQL.Extensions;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceEnterprise.Entities.Finance;
using FinanceEnterprise.Entities.Finance.Models.dbo.GL;
using FinanceEnterprise.Entities.Finance.Models.humco;

namespace FinanceEnterpriseApi.GraphQL.Queries
{
    public class GLQuery
    {
        [UseDbContext(typeof(FinanceContext))]
        [UsePaging(IncludeTotalCount = true)]
        public Task<List<GltTrnsDtl>> GetGltTrnsDtlsByPageConnectionAsync(
            [ScopedService] FinanceContext glContext,
            DateTime startDate,
            DateTime endDate,
            string glKey,
            string glObj)
        {
            var transactions = glContext.GltTrnsDtls
                .AsNoTracking()
                .Include(t => t.GlkKeyMstr)
                .Where(t => t.GlkKeyMstr.GlkGrpPart04 == "25")
                .Include(t => t.GloObjMstr)
                .Include(t => t.GlTransactionGrantNote)
                .Where(t => t.GltDate >= startDate)
                .Where(t => t.GltDate <= endDate);

            if (glKey != null)
            {
                transactions = transactions.Where(t => t.GltGlKey == glKey);
            }

            if (glObj != null)
            {
                transactions = transactions.Where(t => t.GltGlObj == glObj);
            }

            return transactions
                .OrderBy(t => t.UniqueId)
                .ToListAsync();
        }

        [UseDbContext(typeof(FinanceContext))]
        [UseOffsetPaging(IncludeTotalCount = true, MaxPageSize = 100)]
        public Task<List<GltTrnsDtl>> GetGltTrnsDtlsByPageOffsetAsync(
            [ScopedService] FinanceContext glContext,
            DateTime startDate,
            DateTime endDate,
            int? skip,
            int? take,
            string glKey,
            string glObj,
            string sortBy,
            int? sortOrder)
        {
            var transactions = glContext.GltTrnsDtls
                .AsNoTracking()
                .Include(t => t.GlkKeyMstr)
                .Where(t => t.GlkKeyMstr.GlkGrpPart04 == "25")
                .Include(t => t.GloObjMstr)
                .Include(t => t.GlTransactionGrantNote)
                .Where(t => t.GltDate >= startDate)
                .Where(t => t.GltDate <= endDate);

            if (glKey != null)
            {
                transactions = transactions.Where(t => t.GltGlKey == glKey);
            }

            if (glObj != null)
            {
                transactions = transactions.Where(t => t.GltGlObj == glObj);
            }

            if (sortBy != null)
            {
                // properties coming from JS will have a lowercase first letter
                sortBy = sortBy.FirstCharToUpper();

                transactions = sortOrder is null or -1 ?
                    transactions.OrderByDescending(t => EF.Property<GltTrnsDtl>(t, sortBy))
                    : transactions.OrderBy(t => EF.Property<GltTrnsDtl>(t, sortBy));
            }

            return transactions
                .ToListAsync();
        }

        [UseDbContext(typeof(FinanceContext))]
        public Task<List<GltTrnsDtl>> GetGltTrnsDtlsAsync(
            [ScopedService] FinanceContext glContext,
            DateTime startDate,
            DateTime endDate,
            string glKey,
            string glObj,
            string sortBy = "UniqueId")
        {
            var transactions = glContext.GltTrnsDtls
                .AsNoTracking()
                .Include(t => t.GlkKeyMstr)
                .Where(t => t.GlkKeyMstr.GlkGrpPart04 == "25")
                .Include(t => t.GloObjMstr)
                .Include(t => t.GlTransactionGrantNote)
                .Where(t => t.GltDate >= startDate)
                .Where(t => t.GltDate <= endDate);

            if (glKey != null)
            {
                transactions = transactions.Where(t => t.GltGlKey == glKey);
            }

            if (glObj != null)
            {
                transactions = transactions.Where(t => t.GltGlObj == glObj);
            }

            return transactions
                .OrderBy(t => EF.Property<GltTrnsDtl>(t, sortBy))
                .ToListAsync();
        }

        [UseDbContext(typeof(FinanceContext))]
        public Task<GlTransactionGrantNote> GetGlTransactionGrantNoteByIdAsync(
            [ScopedService] FinanceContext glContext, int id)
            => glContext.GlTransactionGrantNotes.Where(n => n.GlTrnsId == id).FirstOrDefaultAsync();
    }
}
