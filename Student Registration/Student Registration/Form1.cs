using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.IO;

namespace Student_Registration
{
    public partial class StudentRegistration : Form
    {

        public StudentRegistration()
        {
            InitializeComponent();
        }
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Path.Combine(AppDomain.CurrentDomain.BaseDirectory,@"..\..\Student Database.mdb;User Id = admin; Password=");
        OleDbConnection con = new OleDbConnection();
        OleDbDataAdapter da;
        OleDbCommand cmd = new OleDbCommand();
       
        LoginForm login = new LoginForm();
        bool adminpriveleges;
       

        void Fillgrid()
        {
            string username = LoginForm.username;
            con = new OleDbConnection(constr);
            da = new OleDbDataAdapter("Select * From [Student Table]", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        void DeleteFromTextBox()
        {
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            GenderBox.Text = "Select Gender";
            DateTimePicker dt = new DateTimePicker();
            BirthDate.Value = DateTime.Today.AddDays(0);
            CountriesBox.SelectedIndex = -1;
            IDTextBox.Clear();
            ZipCodeTextBox.Clear();
            EmailTextBox.Clear();
            PhoneNumberTextBox.Clear();
            HomeAddressTextBox.Clear();
            MartialStatusTextBox.SelectedIndex = -1;
            MajorTextBox.SelectedIndex = -1;
        }

        static bool IsDigit(string input)
        {
            foreach (char c in input)
            {
                if (c < '0' || c > '0')
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsPhoneNumber(String number)
        {
            return number[0] == '0' && number[1] == '7' && number.Length == 11 && IsDigit(number);
        }



        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            string emailvalid = EmailTextBox.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailvalid);
            
            if ((FirstNameTextBox.Text == "") || (LastNameTextBox.Text == "") || (EmailTextBox.Text=="") || (PhoneNumberTextBox.Text=="") || (ZipCodeTextBox.Text==""))
            {
                MessageBox.Show("Make sure all the important fields are entered.");
            }
            else
            {
                if (FirstNameTextBox.Text != "")
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    cmd.Connection = con;

                    Int32 count_1;
                    Int32 phone_number;
                    Int32 email;
                    cmd.CommandText = ("SELECT COUNT(*) FROM [Student Table] WHERE ([First Name]='" + FirstNameTextBox.Text + "' AND [Last Name]='" + LastNameTextBox.Text + "');");
                    count_1 = (Int32)cmd.ExecuteScalar();
                    cmd.CommandText = ("SELECT COUNT(*) FROM [Student Table] WHERE [Phone Number]='" + PhoneNumberTextBox.Text + "';");
                    phone_number = (Int32)cmd.ExecuteScalar();
                    cmd.CommandText = ("SELECT COUNT(*) FROM [Student Table] WHERE Email='" + EmailTextBox.Text + "';");
                    email = (Int32)cmd.ExecuteScalar();

                    if (count_1 == 1)
                    {
                        MessageBox.Show("Those credentials already exist.");
                    }
                    else
                    {
                        if (phone_number == 1)
                        {
                            MessageBox.Show("Those credentials already exist.");
                        }
                        else
                        {
                            if (email == 1)
                            {
                                MessageBox.Show("Those credentials already exist.");
                            }
                            else
                            {
                                if (match.Success)
                                {
                                    cmd.Connection = con;
                                    string query = "INSERT INTO [Student Table] ([First Name], [Last Name], Gender, [Date of Birth], Country, Email, [Phone Number], [Home Address], [Martial Status], Major, [Zip Code]) "
                                        + "VALUES(@FirstName, @LastName,@Gender,@DateofBirth,@Country,@Email,@PhoneNumber,@HomeAddress,@MartialStatus,@Major,@ZipCode);";
                                    cmd = new OleDbCommand(query, con);
                                    cmd.Parameters.AddWithValue("@First Name", FirstNameTextBox.Text);
                                    cmd.Parameters.AddWithValue("@Last Name", LastNameTextBox.Text);
                                    cmd.Parameters.AddWithValue("@Gender", GenderBox.Text);
                                    cmd.Parameters.AddWithValue("@DateofBirth", Convert.ToDateTime(BirthDate.Text));
                                    cmd.Parameters.AddWithValue("@Country", CountriesBox.Text);
                                    cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text);
                                    cmd.Parameters.AddWithValue("@HomeAddress", HomeAddressTextBox.Text);
                                    cmd.Parameters.AddWithValue("@MartialStatus", MartialStatusTextBox.Text);
                                    cmd.Parameters.AddWithValue("@Major", MajorTextBox.Text);
                                    cmd.Parameters.AddWithValue("@ZipCode", ZipCodeTextBox.Text);
                                    DeleteFromTextBox();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    Fillgrid();
                                }
                                else
                                {
                                    MessageBox.Show("That is not a valid email address!");
                                }                      
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Error! You must enter valid credintials!");
                }
            }

            //}
            //    //catch (System.Data.OleDb.OleDbException)
            //{
            //    MessageBox.Show("Error! You must enter all the fields!");
            //}
        }

        private void ModifyStudentButton_Click(object sender, EventArgs e)
        {
            string emailvalid = EmailTextBox.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailvalid);
            try
            {
                if (adminpriveleges == false)
                {
                    MessageBox.Show("Sorry! You are not an admin!");
                }
                else {
                    if (IDTextBox.Text != "")
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        cmd.Connection = con;
                        cmd.CommandText = ("SELECT COUNT(*) FROM [Student Table] WHERE ID=" + IDTextBox.Text + ";");

                        Int32 count = (Int32)cmd.ExecuteScalar();
                        Int32 count_1;

                        Int32 phone_number;
                        Int32 email;


                        if (count == 0)
                        {
                            MessageBox.Show("That ID does not exist.");

                        }
                        else
                        {
                            bool already_exists = false;
                            cmd.CommandText = ("SELECT COUNT(*) FROM [Student Table] WHERE ([First Name]='" + FirstNameTextBox.Text + "' AND [Last Name]='" + LastNameTextBox.Text + "');");
                            count_1 = (Int32)cmd.ExecuteScalar();

                            cmd.CommandText = ("SELECT COUNT(*) FROM [Student Table] WHERE [Phone Number]='" + PhoneNumberTextBox.Text + "';");
                            phone_number = (Int32)cmd.ExecuteScalar();

                            cmd.CommandText = ("SELECT COUNT(*) FROM [Student Table] WHERE Email='" + EmailTextBox.Text + "';");
                            email = (Int32)cmd.ExecuteScalar();


                            if (FirstNameTextBox.Text != "")
                            {
                                if (count_1 == 0)
                                {
                                    string query = "UPDATE [Student Table] SET [First Name]=@FirstName WHERE ID=" + IDTextBox.Text + ";";
                                    cmd = new OleDbCommand(query, con);
                                    cmd.Parameters.AddWithValue("@First Name", FirstNameTextBox.Text);
                                    cmd.ExecuteNonQuery();
                                }
                                else
                                {
                                    MessageBox.Show("Those credenetials already exist.");
                                }
                            }
                            if (LastNameTextBox.Text != "")
                            {
                                if (count_1 == 0)
                                {
                                    string query = "UPDATE [Student Table] SET [Last Name]=@LastName WHERE ID=" + IDTextBox.Text + ";";
                                    cmd = new OleDbCommand(query, con);
                                    cmd.Parameters.AddWithValue("@Last Name", LastNameTextBox.Text);
                                    cmd.ExecuteNonQuery();
                                }
                                already_exists = true;
                            }
                            if (GenderBox.Text != "Select Gender")
                            {
                                string query = "UPDATE [Student Table] SET [Gender]=@Gender WHERE ID=" + IDTextBox.Text + ";";
                                cmd = new OleDbCommand(query, con);
                                cmd.Parameters.AddWithValue("@Gender", GenderBox.Text);
                                cmd.ExecuteNonQuery();
                            }
                            if (BirthDate.Value.Date != DateTime.Today)
                            {
                                string query = "UPDATE [Student Table] SET [Date Of Birth]=@DateofBirth WHERE ID=" + IDTextBox.Text + ";";
                                cmd = new OleDbCommand(query, con);
                                cmd.Parameters.AddWithValue("@Date of Birth", Convert.ToDateTime(BirthDate.Text));
                                cmd.ExecuteNonQuery();
                            }
                            if (CountriesBox.SelectedIndex != -1)
                            {
                                string query = "UPDATE [Student Table] SET [Country]=@Country WHERE ID=" + IDTextBox.Text + ";";
                                cmd = new OleDbCommand(query, con);
                                cmd.Parameters.AddWithValue("@Country", CountriesBox.Text);
                                cmd.ExecuteNonQuery();
                            }
                            if (EmailTextBox.Text != "")
                            {
                              if (match.Success)
                                {
                                    if (email == 0)
                                    {
                                        string query = "UPDATE [Student Table] SET [Email]=@Email WHERE ID=" + IDTextBox.Text + ";";
                                        cmd = new OleDbCommand(query, con);
                                        cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                                        cmd.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        if (already_exists != true)
                                        {
                                            MessageBox.Show("Those credenetials already exist.");
                                        }
                                        already_exists = true;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("That is not a valid email address!");
                                }
                                
                            }
                            if (PhoneNumberTextBox.Text != "")
                            {
                                if (phone_number == 0)
                                {
                                    string query = "UPDATE [Student Table] SET [Phone Number]=@PhoneNumber WHERE ID=" + IDTextBox.Text + ";";
                                    cmd = new OleDbCommand(query, con);
                                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text);
                                    cmd.ExecuteNonQuery();
                                }
                                else
                                {
                                    if (already_exists != true)
                                    {
                                        MessageBox.Show("Those credenetials already exist.");
                                    }
                                }
                            }
                            if (HomeAddressTextBox.Text != "")
                            {
                                string query = "UPDATE [Student Table] SET [Home Address]=@HomeAddress WHERE ID=" + IDTextBox.Text + ";";
                                cmd = new OleDbCommand(query, con);
                                cmd.Parameters.AddWithValue("@HomeAddress", HomeAddressTextBox.Text);
                                cmd.ExecuteNonQuery();
                            }
                            if (MartialStatusTextBox.Text != "")
                            {
                                string query = "UPDATE [Student Table] SET [Martial Status]=@MartialStatus WHERE ID=" + IDTextBox.Text + ";";
                                cmd = new OleDbCommand(query, con);
                                cmd.Parameters.AddWithValue("@MartialStatus", MartialStatusTextBox.Text);
                                cmd.ExecuteNonQuery();
                            }
                            if (MajorTextBox.Text != "")
                            {
                                string query = "UPDATE [Student Table] SET [Major]=@Major WHERE ID=" + IDTextBox.Text + ";";
                                cmd = new OleDbCommand(query, con);
                                cmd.Parameters.AddWithValue("@Major", MajorTextBox.Text);
                                cmd.ExecuteNonQuery();
                            }
                            if (ZipCodeTextBox.Text != "")
                            {
                                string query = "UPDATE [Student Table] SET [Zip Code]=@ZipCode WHERE ID=" + IDTextBox.Text + ";";
                                cmd = new OleDbCommand(query, con);
                                cmd.Parameters.AddWithValue("@ZipCode", ZipCodeTextBox.Text);
                                cmd.ExecuteNonQuery();
                            }
                            already_exists = false;
                            con.Close();
                            Fillgrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the ID of the student.");
                    }
                }      
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Make sure all of the fields are entered.");
            }
        }

        private void SearchStudentButton_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (IDTextBox.Text != "" || FirstNameTextBox.Text != "" || LastNameTextBox.Text != "" || CountriesBox.SelectedIndex != -1 || GenderBox.Text!="Select Gender" || BirthDate.Value.Date != DateTime.Today || ZipCodeTextBox.Text != "" || EmailTextBox.Text != "" || PhoneNumberTextBox.Text != "" || HomeAddressTextBox.Text != "" || MartialStatusTextBox.Text != "" || MajorTextBox.Text!="")
                {
                if (IDTextBox.Text == "")
                {
                    cmd.Connection = con;
                    string query = "SELECT * FROM [Student Table] WHERE [First Name] LIKE '%" + FirstNameTextBox.Text + "%' AND [Last Name] Like '%" + LastNameTextBox.Text + "%' AND COUNTRY LIKE '" + CountriesBox.Text + "%' AND [Zip Code] LIKE '%" + ZipCodeTextBox.Text + "%' AND Email LIKE '%" + EmailTextBox.Text + "%' AND [Phone Number] LIKE '%" + PhoneNumberTextBox.Text + "%' AND [Home Address] LIKE '%"+HomeAddressTextBox.Text+"%' AND [Martial Status] LIKE '%" + MartialStatusTextBox.Text + "%' AND Major Like '%" + MajorTextBox.Text + "%' ";
                    if (GenderBox.Text != "Select Gender")
                    {
                        query += "AND GENDER LIKE '" + GenderBox.Text + "'";
                    }
                    if (BirthDate.Value.Date != DateTime.Today)
                    {
                        query += "AND [Date of Birth] LIKE '" + BirthDate.Text + "'";
                    }
                    cmd = new OleDbCommand(query, con);
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.Connection = con;
                    string query = "SELECT * FROM [Student Table] WHERE ID="+IDTextBox.Text+" AND [First Name] LIKE '%" + FirstNameTextBox.Text + "%' AND [Last Name] Like '%" + LastNameTextBox.Text + "%' AND COUNTRY LIKE '" + CountriesBox.Text + "%' AND [Zip Code] LIKE '%" + ZipCodeTextBox.Text + "%' AND Email LIKE '%" + EmailTextBox.Text + "%' AND [Phone Number] LIKE '%" + PhoneNumberTextBox.Text + "%' AND [Home Address] LIKE '%" + HomeAddressTextBox.Text + "%' AND [Martial Status] LIKE '%" + MartialStatusTextBox.Text + "%' AND Major Like '%" + MajorTextBox.Text + "%' ";
                    if (GenderBox.Text != "Select Gender")
                    {
                        query += "AND GENDER LIKE '" + GenderBox.Text + "'";
                    }
                    if (BirthDate.Value.Date != DateTime.Today)
                    {
                        query += "AND [Date of Birth] LIKE '" + BirthDate.Text + "'";
                    }
                    cmd = new OleDbCommand(query, con);
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cmd.ExecuteNonQuery();
                }
            }                       
            con.Close();
        }


        private void RemoveStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (adminpriveleges == false)
                {
                    MessageBox.Show("Sorry! You are not an admin!");
                }
                else
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    cmd.Connection = con;
                    cmd.CommandText = ("SELECT COUNT(*) FROM [Student Table] WHERE ID=" + IDTextBox.Text + ";");
                    Int32 count = (Int32)cmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("That ID does not exist.");

                    }
                    else
                    {
                        cmd.CommandText = ("SELECT [First Name],[Last Name] FROM [Student Table] WHERE ID=" + IDTextBox.Text + ";");
                        string first_name;
                        string last_name;
                        string message;
                        string title;
                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            first_name = reader.GetValue(0).ToString();
                            last_name = reader.GetValue(1).ToString();
                            message = "Are you sure want to delete " + first_name + " " + last_name + "?";
                            title = "Delete Student";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result = MessageBox.Show(message, title, buttons);
                            if (result == DialogResult.Yes)
                            {
                                string query = "DELETE FROM [Student Table] WHERE ID=" + IDTextBox.Text + ";";
                                cmd = new OleDbCommand(query, con);
                                DeleteFromTextBox();
                                cmd.ExecuteNonQuery();
                                DataTable dt = new DataTable();
                                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                                da.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {

                            }
                            Fillgrid();
                            con.Close();
                            dataGridView1.Refresh();

                        }
                        reader.Close();
                    }
                }
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Please enter the ID of the student");
            }
            Fillgrid();
        }

        private void FirstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter characters only.");
            }
        }

        private void LastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter characters only.");
            }
        }

        private void IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_DatabaseDataSet.Student_Table' table. You can move, or remove it, as needed.
            this.student_TableTableAdapter.Fill(this.student_DatabaseDataSet.Student_Table);
            Fillgrid();
            if (LoginForm.username == "Admin")
            {
                adminpriveleges = true;
            }
            else
            {
                adminpriveleges = false;
            }
        }
        


        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd.Connection = con;
            if (adminpriveleges == false)
            {
                MessageBox.Show("Sorry! You are not an admin!");
            }
            else
            {

                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {

                    string message = "Are you sure you want to remove these students?";
                    string title = "Delete Students";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        int rowId = Convert.ToInt32(item.Cells[0].Value);
                        dataGridView1.Rows.RemoveAt(item.Index);
                        cmd.CommandText = "DELETE FROM [Student Table] WHERE ID=" + rowId + "";
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {

                    }

                }
            } 

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Fillgrid();
            DeleteFromTextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void StudentRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            PasswordForm form = new PasswordForm();
            form.ShowDialog();
        }
    }
}










