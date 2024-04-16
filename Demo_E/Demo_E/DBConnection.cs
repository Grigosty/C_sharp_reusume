using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


//полезные команды
/*
            private static string connectionString = "database=userwsr1; user=root; password=2000Grisha007; server=127.0.0.1";
            public MySqlCommand Command;
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            Command.Connection = conn;
            Command.CommandText = script;
            Command.ExecuteNonQuery() > 0
            conn.Open();
 */
namespace Demo_E
{
    internal class DBConnection
    {
        private static string connectionString = "database=cafe; user=root; password=2000Grisha007; server=localhost";
        MySqlConnection con = new MySqlConnection(connectionString);
        public void OpenConn()
        {
            con.Open();
        }

        public void CloseConn()
        {
            if (con.State != System.Data.ConnectionState.Open) con.Close();
        }


        public MySqlConnection getConnection()
        {
            return con;
        }

        
    }
}
