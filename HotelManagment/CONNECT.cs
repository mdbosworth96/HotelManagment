using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HotelManagment
{

    /*
    *  this class conects to the database to retreive data.
    */
    class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=hotelmanagment");

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
