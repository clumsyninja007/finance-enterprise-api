using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace FinanceEnterpriseApi.Services
{
    public class SqlConnectionHelpers
    {
        private readonly string _connectionString;
        private readonly string _connectionStringTest;

        public SqlConnectionHelpers(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("FinanceDb");
            _connectionStringTest = configuration.GetConnectionString("TEST_FinanceDb");
        }

        public SqlConnection GetSqlConnection(string env)
        {
            string connectionString;

            switch (env.ToLower())
            {
                case "production":
                case "prod":
                    connectionString = _connectionString;
                    break;
                case "test":
                    connectionString = _connectionStringTest;
                    break;
                default:
                    return null;
            }

            return new SqlConnection(connectionString);
        }
    }
}
