using System.Data;
using System.Data.SqlClient;

namespace DbMigrationConsoleApp
{
    internal class ConnectionFactory
    {
        public IDbConnection Create()
        {
            return new SqlConnection();
        }
    }
}