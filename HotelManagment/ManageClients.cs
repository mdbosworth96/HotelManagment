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
    public partial class ManageClients : Form
    {

        CLIENT client = new CLIENT();
        public ManageClients()
        {
            InitializeComponent();
        }

        private void ButtonClearFields_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFirstName.Text = "";
            textBoxSurname.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxEmailAddress.Text = "";
            textBoxCountry.Text = "";
        }

        private void ButtonAddNewClient_Click(object sender, EventArgs e)
        {
            String fname = textBoxFirstName.Text;
            String sname = textBoxSurname.Text;
            String phone = textBoxPhoneNumber.Text;
            String email = textBoxEmailAddress.Text;
            String country = textBoxCountry.Text;

            //check for empty fields (id not needed due to auto increment in database)
            if (fname.Trim().Equals("") || sname.Trim().Equals("") || phone.Trim().Equals("") || email.Trim().Equals("") || country.Trim().Equals(""))
            {
                MessageBox.Show("ERROR: Some details may be missing, check detials and try again","CLIENT ADD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Boolean insertClient = client.insertClient(fname, sname, phone, email, country);

                if(insertClient)
                {
                    dataGridViewClients.DataSource = client.getClients();
                    MessageBox.Show("Client Added Succesfully!","Add Client",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR: Client Could Not Be Added!","Add Client Error", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }

        }

        private void ButtonEditClient_Click(object sender, EventArgs e)
        {
            int id;// = Convert.ToInt32(textBoxID.Text);
            String fname = textBoxFirstName.Text;
            String sname = textBoxSurname.Text;
            String phone = textBoxPhoneNumber.Text;
            String email = textBoxEmailAddress.Text;
            String country = textBoxCountry.Text;

            try
            {
                id = Convert.ToInt32(textBoxID.Text);
                if (fname.Trim().Equals("") || sname.Trim().Equals("") || phone.Trim().Equals("") || email.Trim().Equals("") || country.Trim().Equals(""))
                {
                    MessageBox.Show("ERROR: Some details may be missing, check detials and try again", "CLIENT EDIT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = client.editClient(id, fname, sname, phone, email, country);

                    if (insertClient)
                    {
                        dataGridViewClients.DataSource = client.getClients();
                        MessageBox.Show("Client Updated Succesfully!", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Client Could Not Be Updated!", "Add Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"ID ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRemoveClient_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                id = Convert.ToInt32(textBoxID.Text);

                Boolean removeClient = client.removeClient(id);

                if (removeClient)
                {
                    dataGridViewClients.DataSource = client.getClients();
                    MessageBox.Show("Client Removed Succesfully!", "Remove Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxID.Text = "";
                    textBoxFirstName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxPhoneNumber.Text = "";
                    textBoxEmailAddress.Text = "";
                    textBoxCountry.Text = "";
                }
                else
                {
                    MessageBox.Show("ERROR: Client Could Not Be Removed!", "Remove Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ManageClients_Load(object sender, EventArgs e)
        {
            dataGridViewClients.DataSource = client.getClients();
        }

        private void DataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewClients.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridViewClients.CurrentRow.Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridViewClients.CurrentRow.Cells[2].Value.ToString();
            textBoxPhoneNumber.Text = dataGridViewClients.CurrentRow.Cells[3].Value.ToString();
            textBoxEmailAddress.Text = dataGridViewClients.CurrentRow.Cells[4].Value.ToString();
            textBoxCountry.Text = dataGridViewClients.CurrentRow.Cells[5].Value.ToString();


        }
    }
}
