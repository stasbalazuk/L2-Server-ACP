using MySql.Data.MySqlClient;
 
namespace Tutorial.SqlConn
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection( )
        {
            string host = "localhost";
            int port = 3306;
            string database = "acis";
            string username = "root";
            string password = "";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
        
    }
}