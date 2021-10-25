using System.Threading.Tasks;

namespace FinanceEnterpriseApi.Data.Interfaces.Finance.dbo
{
    public interface INuJobMstrService
    {
        Task<string> GetJobStatusAsync(int jobNo);
    }
}
