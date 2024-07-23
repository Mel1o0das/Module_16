using System.Data.SqlClient;
using System.Diagnostics;

namespace ClassLibrary.ConnectDB
{
    public class SqlConnect
    {
        private SqlConnectionStringBuilder _connectionString = new()
        {
            DataSource = @"localhost\SQLExpress",
            InitialCatalog = "MSSQLLocalDB",
            IntegratedSecurity = true
        };

        public void ConnectToSqlDB()
        {
            SqlConnection sqlConnection = new(_connectionString.ConnectionString);
            sqlConnection.Open();
            Debug.Print(sqlConnection.State.ToString());
        }
    }
}
