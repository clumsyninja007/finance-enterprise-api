using System.Threading.Tasks;

namespace FinanceEnterpriseApi.Data.Interfaces.Finance.dbo
{
    public interface IHrHrcodeService
    {
        Task<bool> CodeExistsAsync(string id, string val);
    }
}
