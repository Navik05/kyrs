using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrs
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("server=megaba08.beget.tech;port=3306;username=megaba08_kyrs;password=PI23kyrs;database=megaba08_kyrs");

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed) 
            { 
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        { 
            return connection; 
        }
    }
}
