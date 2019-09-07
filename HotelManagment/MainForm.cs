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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageClients manageClientPage = new ManageClients();
            manageClientPage.Show();
        }

        private void ManageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRooms manageRoomsPage = new ManageRooms();
            manageRoomsPage.Show();
        }

        private void ManageReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageReservations manageReservationsPage = new ManageReservations();
            manageReservationsPage.Show();
        }
    }
}
