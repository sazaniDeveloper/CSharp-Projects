using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Add_Window.xaml
    /// </summary>
    public partial class Add_Window : Window
    {
        private MainWindow _mainWindow; 

        public Add_Window(MainWindow window)
        {
            InitializeComponent();
            _mainWindow = window;
        }

        private void Add_Task_Click(object sender, RoutedEventArgs e)
        {
            String task_name = Task_Name.Text;
            String task_description = Description.Text;
            DateTime dueDate = Date.SelectedDate ?? DateTime.Today;

            if (!string.IsNullOrEmpty(task_name) && !string.IsNullOrEmpty(task_description))
            {
                String connectionString = "Data Source=DESKTOP-JP92FBD\\SQLEXPRESS;Initial Catalog=to-do-list;Integrated Security=True;Encrypt=False";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        String query = "INSERT INTO [TASKS] (task, description_task, date_task, COMPLETED) VALUES (@task, @description_task,  @date_task, @COMPLETED)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@task", task_name);
                            cmd.Parameters.AddWithValue("@description_task", task_description);
                            cmd.Parameters.AddWithValue("@date_task", dueDate);
                            cmd.Parameters.AddWithValue("@COMPLETED", 0);
                            conn.Open();
                            cmd.ExecuteNonQuery();
       
                            MessageBox.Show("Task Added Succesfully!");


                            this.Close();
                            _mainWindow.Refresh_Grid();
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                }


            else {
                    MessageBox.Show("Please fill in all fields.");
                }

            }
        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
