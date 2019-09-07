using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagment
{
    public partial class ManageRooms : Form
    {
        ROOM room = new ROOM();
        public ManageRooms()
        {
            InitializeComponent();
            comboBoxRoomType.SelectedIndex = 0;
        }

        private void ButtonClearFields_Click(object sender, EventArgs e)
        {
            textBoxRoomNumber.Text = "";
            textBoxPricePerNight.Text = "";
            textBoxNumberOfBeds.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            textBoxDescription.Text = "";
        }

        private void ManageRooms_Load(object sender, EventArgs e)
        {
            dataGridViewRooms.DataSource = room.roomTypeList();
        }

        private void ButtonAddNewRoom_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBoxRoomNumber.Text);
            int numBeds = Convert.ToInt32(textBoxNumberOfBeds.Text);
            string type = comboBoxRoomType.Text;
            int price = Convert.ToInt32(textBoxPricePerNight.Text);
            string description = textBoxDescription.Text;
            if(room.addRoom(number, numBeds, type, price, description))
            {
                MessageBox.Show("Room Added Succesfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewRooms.DataSource = room.roomTypeList();
            }
            else
            {
                MessageBox.Show("Unable to Add Room", "Add Room Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DataGridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxRoomNumber.Text = dataGridViewRooms.CurrentRow.Cells[0].Value.ToString();
            textBoxNumberOfBeds.Text =dataGridViewRooms.CurrentRow.Cells[1].Value.ToString();
            comboBoxRoomType.Text = dataGridViewRooms.CurrentRow.Cells[2].Value.ToString();
            textBoxPricePerNight.Text = dataGridViewRooms.CurrentRow.Cells[3].Value.ToString();
            textBoxDescription.Text = dataGridViewRooms.CurrentRow.Cells[4].Value.ToString();
        }

        private void ButtonEditRoom_Click(object sender, EventArgs e)
        {
            int roomNumber;// = Convert.ToInt32(textBoxRoomNumber.Text);
            int numberOfBeds = Convert.ToInt32(textBoxNumberOfBeds.Text);
            String roomType = comboBoxRoomType.Text;
            int pricePerNight = Convert.ToInt32(textBoxPricePerNight.Text);
            String roomDescription = textBoxDescription.Text;

            try
            {
                roomNumber = Convert.ToInt32(textBoxRoomNumber.Text);
                if (numberOfBeds.Equals("") || roomType.Trim().Equals("") || pricePerNight.Equals("") || roomDescription.Trim().Equals(""))
                {
                    MessageBox.Show("ERROR: Some details may be missing, check detials and try again", "CLIENT EDIT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertRoom = room.editRoom(roomNumber, numberOfBeds, roomType, pricePerNight, roomDescription);

                    if (insertRoom)
                    {
                        dataGridViewRooms.DataSource = room.roomTypeList();
                        MessageBox.Show("Room Updated Succesfully!", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Room Could Not Be Updated!", "Edit Room Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ROOM NUMBER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRemoveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int roomNumber;
                roomNumber = Convert.ToInt32(textBoxRoomNumber.Text);

                Boolean removeRoom = room.removeRoom(roomNumber);

                if (removeRoom)
                {
                    dataGridViewRooms.DataSource = room.roomTypeList();
                    MessageBox.Show("Room Removed Succesfully!", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxRoomNumber.Text = "";
                    textBoxNumberOfBeds.Text = "";
                    comboBoxRoomType.Text = "";
                    textBoxPricePerNight.Text = "";
                    textBoxDescription.Text = "";
                }
                else
                {
                    MessageBox.Show("ERROR: Room Could Not Be Removed!", "Remove Room Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ROOM NUMBER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
