using FinanceEnterpriseApi.Data.Dtos.Finance.humco;
using System.Threading.Tasks;
using FinanceEnterprise.Entities.Finance.Models.humco;

namespace FinanceEnterpriseApi.Data.Interfaces.Finance.humco
{
    public interface IGlTransactionGrantNotesService
    {
        Task<GlTransactionGrantNote> GetByIdAsync(int id);
        Task AddAsync(PutGlTransactionGrantNotesParamsDto noteDto);
        Task UpdateAsync(PutGlTransactionGrantNotesParamsDto noteDto);
    }
}
