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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LinkLabelNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUpSheet = new SignUp();
            signUpSheet.Show();
        }

        private void LinkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            PasswordReset PasswordResetSheet = new PasswordReset();
            PasswordResetSheet.Show();
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPassword.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `userdetails` WHERE `username`=@username AND `password`=@pass";

            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();

                
            }
            else
            {
                if(textBoxUsername.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your username");
                }
                else if(textBoxPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your password");
                }
                else
                {
                    MessageBox.Show("Useranme/Password combination incorrect, Please try again.");
                }
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
