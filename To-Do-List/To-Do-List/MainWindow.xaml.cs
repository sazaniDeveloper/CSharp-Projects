using Microsoft.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace To_Do_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Refresh_Grid();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Add_Window(this);
    
            window.Show();
        }

        private void Read_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Read_Window();
            window.Show();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Update_Window(this);
            window.Show();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Remove_Window(this);
            window.Show();
        }

        public void Refresh_Grid()
        {
            String connectionString = "Data Source=DESKTOP-JP92FBD\\SQLEXPRESS;Initial Catalog=to-do-list;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    String query = "SELECT * FROM TASKS";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    TaskGrid.ItemsSource = dt.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }


        private void TaskDataGrid(object sender, RoutedEventArgs e)
        {
            Refresh_Grid();
        }

    }
}