using Accessibility;
using Microsoft.Data.SqlClient;
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
    /// Interaction logic for ReadTasks.xaml
    /// </summary>
    public partial class ReadTasks : Window
    { 
        public string TaskId {  get; set; }
        public string Task_Name { get; set; }
        public string Description { get; set; }

        public DateTime? Date {  get; set; }

        public bool? Checked { get; set; }

        public ReadTasks()
        {
            InitializeComponent();
            this.Loaded += ReadTasks_Loaded;
        }

        private void ReadTasks_Loaded(object sender, RoutedEventArgs e)
        {
            LoadTask();
        }

       private void LoadTask()
       {
       string connectionString = @"Data Source=DESKTOP-JP92FBD\SQLEXPRESS;Initial Catalog=to-do-list;Integrated Security=True;Encrypt=False";

       using (SqlConnection conn = new SqlConnection(connectionString)) {
        try
        {
            conn.Open();

            string query = "SELECT * FROM TASKS WHERE 1=1";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

       
            if (!string.IsNullOrEmpty(TaskId))
            {
                query += " AND id = @ID";
                cmd.Parameters.AddWithValue("@ID", int.Parse(TaskId));
            }

            if (!string.IsNullOrEmpty(Task_Name))
            {
                 query += " AND task LIKE @task";
                 cmd.Parameters.AddWithValue("@task", "%" + Task_Name.Trim() + "%");
            }

            if (!string.IsNullOrEmpty(Description))
            {
                 query += " AND description_task LIKE @desc";
                 cmd.Parameters.AddWithValue("@desc", "%" + Description.Trim() + "%");
            }

            if (Date.HasValue)
            {
                 query += " AND CAST(date_task AS DATE) = @date";
                 cmd.Parameters.AddWithValue("@date", Date.Value.Date);
            }

            if (Checked.HasValue)
            {
                query += " AND completed = @completed";
                cmd.Parameters.AddWithValue("@completed", Checked.Value ? 1 : 0);
            } 


            cmd.CommandText = query;

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
  }
}
