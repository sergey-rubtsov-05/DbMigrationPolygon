using System.Data;
using System.Data.SqlClient;

namespace BusinessConsoleApp
{
    public class ConnectionFactory
    {
        public string ConnectionString =>
            "";
        public IDbConnection Create()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}