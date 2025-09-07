using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for Remove_Window.xaml
    /// </summary>
    public partial class Remove_Window : Window
    {

        private MainWindow _mainWindow;
        public Remove_Window(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            String id = ID_Text.Text;
            if (!String.IsNullOrEmpty(id))
            {
                String connectionString = "Data Source=DESKTOP-JP92FBD\\SQLEXPRESS;Initial Catalog=to-do-list;Integrated Security=True;Encrypt=False";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        String query = "DELETE FROM [TASKS] WHERE ID=@id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Task Deleted Succesfully!");

                            this.Close();
                            _mainWindow.Refresh_Grid();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter the task ID.");
            }
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
