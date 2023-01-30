using System.Data;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;

namespace Ecommerce.Infrastructure.Data
{
    public class DbConnector
    {
        private readonly IConfiguration _configuration;

        public DbConnector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            return new SqliteConnection(connectionString);
        }
    }
}