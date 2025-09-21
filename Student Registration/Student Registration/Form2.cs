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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public static string username;
        public static string password;



        private void button1_Click(object sender, EventArgs e)
        {
            username = textUsername.Text;
            password = textPassword.Text;
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (textUsername.Text != "" && textPassword.Text != "")
            {
                cmd.CommandText = ("SELECT COUNT(*) FROM [StudentLogin] WHERE Username='" + textUsername.Text + "' AND Password='" + textPassword.Text + "'");
                cmd.Connection = con;
                int count_username_password;
                count_username_password = (Int32)cmd.ExecuteScalar();


                if (count_username_password > 0)
                {
                    MessageBox.Show("Login Success!");
                    this.Hide();
                    StudentRegistration student = new StudentRegistration();
                    student.Show();   
                }
                else
                {
                    MessageBox.Show("Invalid username or password! Please try again!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else if (textUsername.Text == "" && textPassword.Text == "")
            {
                MessageBox.Show("Please fill in the data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textUsername.Text == "")
            {
                MessageBox.Show("Enter the username please!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textPassword.Text == "")
            {
                MessageBox.Show("Enter the password please!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Student Login.mdb;");
            con = new OleDbConnection(connectionString);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }
    }
}
