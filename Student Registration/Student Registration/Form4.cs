using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;

namespace Student_Registration
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        LoginForm login = new LoginForm();
        StudentRegistration student = new StudentRegistration();
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();


        private void button1_Click(object sender, EventArgs e)
        {
            if (currentPasswordText.Text!="")
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                cmd.CommandText = ("SELECT COUNT(*) FROM [StudentLogin] WHERE Username='" + usernameTextBox.Text + "' AND Password='" + currentPasswordText.Text + "'");
                cmd.Connection = con;
                int count_username_password;
                count_username_password = (Int32)cmd.ExecuteScalar();

                if (count_username_password > 0)
                {
                    if (newPasswordText.Text != "" || ConfirmPasswordText.Text!="")
                    {
                        if (newPasswordText.Text == ConfirmPasswordText.Text)
                        {
                            if (newPasswordText.Text==currentPasswordText.Text && ConfirmPasswordText.Text==currentPasswordText.Text)
                            {
                                MessageBox.Show("Enter the same password please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string query = "UPDATE StudentLogin Set [Password]=@password WHERE Username='" + usernameTextBox.Text + "';";
                                cmd = new OleDbCommand(query, con);
                                cmd.Parameters.AddWithValue("@password", newPasswordText.Text);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Password successfully changed!");
                                currentPasswordText.Clear();
                                newPasswordText.Clear();
                                ConfirmPasswordText.Clear();
                            }
                                
                        }    
                        else
                        {
                            MessageBox.Show("Enter the same password please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("That is not the current password. Please enter the correct one.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter the current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = LoginForm.username;
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Student Login.mdb;");
            con = new OleDbConnection(connectionString);
        }

        private void PasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
           
        }

        private void currentPasswordText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }

        private void newPasswordText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }

        private void ConfirmPasswordText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }
    }
}
