using System.Data;
using System.Data.SqlClient;

namespace BusinessConsoleApp
{
    internal class ConnectionFactory
    {
        public IDbConnection Create()
        {
            return new SqlConnection();
        }
    }
}