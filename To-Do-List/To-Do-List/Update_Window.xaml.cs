using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace To_Do_List
{
    /// <summary>
    /// Interaction logic for Update_Window.xaml
    /// </summary>
    public partial class Update_Window : Window
    {

        private MainWindow _mainWindow;
        public Update_Window(MainWindow window)
        {
            InitializeComponent();
            _mainWindow = window;

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            string id = ID_Text.Text;
            string task_name = Task_Name.Text;
            string task_description = Description.Text;
            DateTime? date = Date.SelectedDate;
            bool? checkedValue = Status_Check.IsChecked;

            if (!string.IsNullOrEmpty(id) && (!string.IsNullOrEmpty(task_name) || !string.IsNullOrEmpty(task_description) || date != null || checkedValue.HasValue))
            {
                string connectionString = @"Data Source=DESKTOP-JP92FBD\SQLEXPRESS;Initial Catalog=to-do-list;Integrated Security=True;Encrypt=False";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string query = "UPDATE Tasks SET ";
                        List<string> updates = new List<string>();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;

                        if (!string.IsNullOrEmpty(task_name))
                        {
                            updates.Add("task = @task");
                            cmd.Parameters.AddWithValue("@task", task_name.Trim());
                        }

                        if (!string.IsNullOrEmpty(task_description))
                        {
                            updates.Add("description_task = @desc");
                            cmd.Parameters.AddWithValue("@desc", task_description.Trim());
                        }

                        if (date.HasValue)
                        {
                            updates.Add("date_task = @date");
                            cmd.Parameters.AddWithValue("@date", date.Value.Date);
                        }

                        if (checkedValue.HasValue)
                        {
                            updates.Add("completed = @completed");
                            cmd.Parameters.AddWithValue("@completed", checkedValue.Value ? 1 : 0);
                        }

                        if (updates.Count == 0)
                        {
                            MessageBox.Show("Please enter at least one field to update.");
                            return;
                        }

                        query += string.Join(", ", updates);
                        query += " WHERE id = @ID";
                        cmd.Parameters.AddWithValue("@ID", int.Parse(id));

                        cmd.CommandText = query;
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Task updated successfully!");
                            this.Close();
                            _mainWindow.Refresh_Grid();
                        }
                        else
                        {
                            MessageBox.Show("No task found with that ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter the task ID and at least one field to update.");
            }
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
