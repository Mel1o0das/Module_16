using System.Data.OleDb;
using System.Diagnostics;

namespace ClassLibrary.ConnectDB
{
    public class AccessConnect
    {
        private static readonly string _pathToAccessDB = 
            @$"{Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)}\" + "AccessDB.accdb";

        private string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={_pathToAccessDB}";

        public void ConnectToAccessDB()
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            Debug.Print(connection.State.ToString());
        }
    }
}
