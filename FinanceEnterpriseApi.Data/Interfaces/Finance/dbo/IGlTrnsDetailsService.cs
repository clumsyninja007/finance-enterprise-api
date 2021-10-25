using FinanceEnterpriseApi.Data.Dtos.Finance.dbo;
using FinanceEnterpriseApi.Data.Models;
using System.Threading;
using System.Threading.Tasks;

namespace FinanceEnterpriseApi.Data.Interfaces.Finance.dbo
{
    public interface IGlTrnsDetailsService
    {
        Task<PagedModel<GlTrnsDetailsDto>> GetByPageAsync(GetGlTrnsDetailsListParamsDto paramsDto,
            CancellationToken cancellationToken);
    }
}
