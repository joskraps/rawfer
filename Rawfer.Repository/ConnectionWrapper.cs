using System.Data.SqlClient;

namespace Rawfer.Repository
{
    public interface IConnectionWrapper
    {
        SqlConnection GetConnection();
    }

    public class ConnectionWrapper : IConnectionWrapper
    {
        private SqlConnection connection;

        public ConnectionWrapper(ConnectionConfig config)
        {
            this.connection = new SqlConnection(config.DbConnection);
        }

        public SqlConnection GetConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open) connection.Open();

            return connection;
        }
    }
}
