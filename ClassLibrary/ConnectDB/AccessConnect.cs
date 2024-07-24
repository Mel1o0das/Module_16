using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

namespace ClassLibrary.ConnectDB
{
    public class AccessConnect
    {
        private static readonly string _pathToAccessDB = 
            @$"{Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)}\" + "AccessDB.accdb";

        private string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={_pathToAccessDB}";

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Проверка совместимости платформы", Justification = "<Ожидание>")]
        public ConnectionState ConnectToAccessDB()
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            return connection.State;
        }
    }
}
