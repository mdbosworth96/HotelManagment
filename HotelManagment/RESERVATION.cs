using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HotelManagment
{
    class RESERVATION
    {
        CONNECT conn = new CONNECT();

        public DataTable getAllReservations()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservations`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }



        //add res
  
        public bool addReservation(int reservationId, int clientId, int roomNumber, string roomType, int dateIn, int dateOut)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `reservations`(`reservationId`, `clientId`, `roomNumber`, `roomType`, `dateIn`, `dateOut`) VALUES (@reservationid,@clientid,@roomnum,@roomtype,@datein,@dateout)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@reservationid", MySqlDbType.Int32).Value = reservationId;
            command.Parameters.Add("@clientid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@roomnum", MySqlDbType.Int32).Value = roomNumber;
            command.Parameters.Add("@roomtype", MySqlDbType.VarChar).Value = roomType;
            command.Parameters.Add("@datein", MySqlDbType.VarChar).Value = dateIn;
            command.Parameters.Add("@dateout", MySqlDbType.Int32).Value = dateOut;

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }


        public bool editReservation(int reservationId, int clientId, int roomNumber, string roomType, int dateIn, int dateOut)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `reservations` SET `clientId`=@clientid,`roomNumber`=@roomnum,`roomType`=@roomtype,`dateIn`=@datein,`dateOut`=@dateout  WHERE `reservationId`=@reservationid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@clientid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@roomnum", MySqlDbType.Int32).Value = roomNumber;
            command.Parameters.Add("@roomtype", MySqlDbType.VarChar).Value = roomType;
            command.Parameters.Add("@datein", MySqlDbType.Int32).Value = dateIn;
            command.Parameters.Add("@dateout", MySqlDbType.Int32).Value = dateOut;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }


        public bool removeReservation(int reservationId)
        {

            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `reservations` WHERE `reservationId` =@reservationid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@reservationid", MySqlDbType.Int32).Value = reservationId;
            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }








        //end class
    }
}
