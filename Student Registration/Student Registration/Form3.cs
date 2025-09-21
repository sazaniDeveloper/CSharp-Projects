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
using System.Data.OleDb;
using System.IO;

namespace Student_Registration
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (textusername.Text!="" || textpassword.Text!="" || textconfirmpassword.Text != "")
            {
                cmd.Connection = con;
                if (textpassword.Text == textconfirmpassword.Text)
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM [StudentLogin] WHERE Username='"+textusername.Text+"'";
                    Int32 count_username = (Int32)cmd.ExecuteScalar();
                    if (count_username > 0)
                    {
                        MessageBox.Show("That username already exists! Try another one!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string query = "INSERT INTO StudentLogin (Username, [Password]) VALUES (@username,@password)";
                        cmd = new OleDbCommand(query, con);
                        cmd.Parameters.AddWithValue("username", textusername.Text);
                        cmd.Parameters.AddWithValue("password", textpassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration success! Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        LoginForm login = new LoginForm();
                        login.Show();

                    }   
                }
                else
                {
                    MessageBox.Show("Enter the same passord please!","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter all the values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Student Login.mdb;");
            con = new OleDbConnection(connectionString);
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }

        private void textconfirmpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }

        private void textpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }
    }
}
