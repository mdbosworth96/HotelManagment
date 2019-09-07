using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HotelManagment
{
    class ROOM
    {
        CONNECT conn = new CONNECT();


        public bool addRoom(int roomNumber, int numberOfBeds, string roomType, int roomPricePerNight, string roomDescirption)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `rooms`(`roomNumber`, `numberOfBeds`, `roomType`, `roomPricePerNight`, `roomDescription`) VALUES (@roomnum,@numbeds,@roomtype,@price,@roomdes)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@roomnum", MySqlDbType.Int32).Value = roomNumber;
            command.Parameters.Add("@numbeds", MySqlDbType.Int32).Value = numberOfBeds;
            command.Parameters.Add("@roomtype", MySqlDbType.VarChar).Value = roomType;
            command.Parameters.Add("@price", MySqlDbType.Int32).Value = roomPricePerNight;
            command.Parameters.Add("@roomdes", MySqlDbType.VarChar).Value = roomDescirption;

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




        public DataTable roomTypeList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }



        public DataTable roomByType(int type)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms` WHERE `roomType` =@type", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        //function to edit a room.

        public bool editRoom(int roomNumber, int numberOfBeds, string roomType, int roomPricePerNight, string roomDescirption)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `rooms` SET `numberOfBeds`=@nbd,`roomType`=@rmt,`roomPricePerNight`=@rppn,`roomDescription`=@rdesc WHERE `roomNumber`=@rnm";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = roomNumber;
            command.Parameters.Add("@nbd", MySqlDbType.Int32).Value = numberOfBeds;
            command.Parameters.Add("@rmt", MySqlDbType.VarChar).Value = roomType;
            command.Parameters.Add("@rppn", MySqlDbType.Int32).Value = roomPricePerNight;
            command.Parameters.Add("@rdesc", MySqlDbType.VarChar).Value = roomDescirption;

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

        public bool removeRoom(int roomNumber)
        {

            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `rooms` WHERE `roomNumber` =@rnm";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = roomNumber;
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


    }
}
