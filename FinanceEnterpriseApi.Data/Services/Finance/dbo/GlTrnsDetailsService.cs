using FinanceEnterpriseApi.Data.Dtos.Finance.dbo;
using FinanceEnterpriseApi.Data.Extensions;
using FinanceEnterpriseApi.Data.Interfaces.Finance.dbo;
using FinanceEnterpriseApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FinanceEnterprise.Entities.Finance;
using FinanceEnterprise.Entities.Finance.Models.humco;

namespace FinanceEnterpriseApi.Data.Services.Finance.dbo
{
    public class GlTrnsDetailsService : IGlTrnsDetailsService
    {
        private readonly IDbContextFactory<FinanceContext> _financeGLContextFactory;

        public GlTrnsDetailsService(IDbContextFactory<FinanceContext> financeGLContextFactory)
        {
            _financeGLContextFactory = financeGLContextFactory;
        }

        public async Task<PagedModel<GlTrnsDetailsDto>> GetByPageAsync(GetGlTrnsDetailsListParamsDto paramsDto,
            CancellationToken cancellationToken)
        {
            await using var context = _financeGLContextFactory.CreateDbContext();

            var query = context.GltTrnsDtls
                .AsNoTracking()
                .Where(t => t.GltDate >= paramsDto.StartDate)
                .Where(t => t.GltDate <= paramsDto.EndDate);

            if (paramsDto.GlKey != null)
            {
                query = query.Where(t => t.GltGlKey == paramsDto.GlKey);
            }

            if (paramsDto.GlObj != null)
            {
                query = query.Where(t => t.GltGlObj == paramsDto.GlObj);
            }

            return await query
                .Include(t => t.GlkKeyMstr)
                .Where(t => t.GlkKeyMstr.GlkGrpPart04 == "25")
                .Include(t => t.GloObjMstr)
                .Include(t => t.GlTransactionGrantNote)
                .OrderBy(t => t.UniqueId)
                .Select(t => new GlTrnsDetailsDto
                {
                    GlKey = t.GltGlKey.TrimEnd(),
                    GlKeyName = t.GlkKeyMstr.GlkTitleDl.TrimEnd(),
                    GlObj = t.GltGlObj.TrimEnd(),
                    GlObjName = t.GloObjMstr.GloObjDl.TrimEnd(),
                    TrnsDate = t.GltDate,
                    Subsystem = t.GltSubsId.TrimEnd(),
                    Ref = t.GltRef.TrimEnd(),
                    Ref2 = t.GltRef2.TrimEnd(),
                    PEID = t.GltPeId.TrimEnd(),
                    TrnsDesc = t.GltDesc.TrimEnd(),
                    Debits = t.GltDr,
                    Credits = t.GltCr,
                    GlTransactionGrantNote = t.GlTransactionGrantNote ?? new GlTransactionGrantNote { GlTrnsId = t.UniqueId }
                })
                .PaginateAsync(paramsDto.Page, paramsDto.Limit, cancellationToken);
        }
    }
}
