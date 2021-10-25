namespace FinanceEnterpriseApi.Auth.Interfaces
{
    public interface IAuthenticationService
    {
        string GetDepartmentByUsername(string username);
        string GetUsernameByEmployeeId(string id);
        string GetGroupSid(string groupname);
    }
}
