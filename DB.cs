using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class DB
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "192.168.70.5";
            int port = 3306;
            string database = "Temper";
            string username = "appuser";
            string password = "pass";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

        MySqlConnection connection = new MySqlConnection("server=192.168.70.5;port=3306;username=appuser;password=pass;database=Temper");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
