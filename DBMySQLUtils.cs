using System;
using MySql.Data.MySqlClient;
 
namespace Tutorial.SqlConn
{
    class DBMySQLUtils
    {
 
        public static MySqlConnection
                 GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password+";SSL Mode=None;";
 
            MySqlConnection conn = new MySqlConnection(connString);
 
            return conn;
        }
        
    }
}