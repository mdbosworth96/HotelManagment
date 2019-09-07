using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagment
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelSurname_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {


            using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=hotelmanagment"))
            {
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;            // <== lacking
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO userdetails (`forename`, `surname`, `email`, `password`, `username`, `dateOfBirth`) VALUES (@fname,@sname,@email,@pass,@username,@dob)";

                    command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = textBoxForename.Text;
                    command.Parameters.Add("@sname", MySqlDbType.VarChar).Value = textBoxSurname.Text;
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
                    command.Parameters.Add("@username", MySqlDbType.VarChar).Value = textBoxUsername.Text;
                    command.Parameters.Add("@dob", MySqlDbType.DateTime).Value = dateTimePickerDOB.Value.Date;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;


                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonReturnToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginpage = new Login();
            loginpage.Show();
        }
    }
}
