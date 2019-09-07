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
    public partial class ManageReservations : Form
    {
        RESERVATION reservation = new RESERVATION();
        ROOM room = new ROOM();
        public ManageReservations()
        {
            InitializeComponent();
        }


        private void ManageReservations_Load(object sender, EventArgs e)
        {
            comboBoxRoomType.DataSource = room.roomTypeList();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

            comboBoxRoomNum.ValueMember = "";
            dataGridViewReservations.DataSource = reservation.getAllReservations();
        }

        private void ButtonAddNewReservation_Click(object sender, EventArgs e)
        {

        }

        private void ButtonEditReservation_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRemoveReservation_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClearFields_Click(object sender, EventArgs e)
        {
            textBoxClientId.Text = "";
            textBoxReservationId.Text = "";
            textBoxRoomNumber.Text = "";
            comboBoxRoomNum.SelectedIndex = 0;
            comboBoxRoomType.SelectedIndex = 0;
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;

        }

        private void dataGridViewReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxClientId.Text = dataGridViewReservations.CurrentRow.Cells[0].Value.ToString();
            textBoxReservationId.Text = dataGridViewReservations.CurrentRow.Cells[1].Value.ToString();

            textBoxRoomNumber.Text = dataGridViewReservations.CurrentRow.Cells[2].Value.ToString();
            comboBoxRoomNum.Text = dataGridViewReservations.CurrentRow.Cells[2].Value.ToString();

            comboBoxRoomType.Text = dataGridViewReservations.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerIn.Text = dataGridViewReservations.CurrentRow.Cells[4].Value.ToString();
            dateTimePickerOut.Text = dataGridViewReservations.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
