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
    /// Interaction logic for Read_Window.xaml
    /// </summary>
    public partial class Read_Window : Window
    {
   
        public Read_Window()
        {
            InitializeComponent();
          
        }

        private void Read_Tasks_Click(object sender, RoutedEventArgs e)
        {
            String id = ID_Text.Text;
            String task_name = Task_Name.Text;
            String task_description = Description.Text;
            DateTime? date = Date.SelectedDate;
            bool? checkedValue = Status_Check.IsChecked;

            if (!String.IsNullOrEmpty(id) || !String.IsNullOrEmpty(task_name) || !String.IsNullOrEmpty(task_description) || date!=null || checkedValue.HasValue)
            {
                ReadTasks window = new ReadTasks();
                window.TaskId = id;
                window.Task_Name = task_name;
                window.Description = task_description;
                window.Date = date;
                window.Checked = checkedValue;
                window.Show();
            }
            else
            {
                MessageBox.Show("Please enter at least one field.");
            }

        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
