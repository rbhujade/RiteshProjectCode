using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace MVC_Core_Project.Database
{
    public class SqlDataAccess 
    {
        private readonly IConfiguration _configuration;
        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IEnumerable<T>> GetData<T, P>(string spName, P parameters, string connectionId = "conn")
        {
            try
            {
                string connectionString = _configuration.GetConnectionString(connectionId);
                using (IDbConnection dbConnection = new SqlConnection(connectionString))
                {
                    return await dbConnection.QueryAsync<T>(spName, parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public async Task<bool> SaveData<T>(string spName, T parameters, string connectionId = "conn")
        {
            try
            {
                using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));
                await connection.ExecuteAsync(spName, parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
