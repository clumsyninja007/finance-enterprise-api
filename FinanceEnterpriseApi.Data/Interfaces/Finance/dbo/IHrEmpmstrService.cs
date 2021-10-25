using System.Threading.Tasks;

namespace FinanceEnterpriseApi.Data.Interfaces.Finance.dbo
{
    public interface IHrEmpmstrService
    {
        Task<bool> EmpExistsAsync(string id);
        Task UpdateGenderAsync(string id, string gender);
    }
}
