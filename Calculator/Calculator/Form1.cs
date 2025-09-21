using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double first_number;
        double second_number;
        double result = 0;
        string operation;
        bool button_clicked;
        int times_clicked = 0;
        bool operation_button;
        bool delete_button;
        bool completed_operation=false;
        bool second_number_available=false;
        bool equals_more = false;
        bool first_number_nodelete;

        public Form1()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
            }
        }

        private void Number_0_Click(object sender, EventArgs e)
            {
            if (CalculationsTextBox.Text == "0")
            {
                if (first_number != 0 && completed_operation==true || first_number==0 && completed_operation==true && second_number_available==true)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "0";
                button_clicked = false;
            }
            else if ((first_number==0 && second_number==0 && completed_operation==true) || (second_number == 0 && completed_operation == true))
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                if (second_number_available == true)
                {
                    button4_Click(sender, e);
                }
                CalculationsTextBox.Text = "0";
                button_clicked = false;
            }
            else if (completed_operation == true)
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "0";
                button_clicked = false;
            }
            else if (button_clicked == true)
            {
                CalculationsTextBox.Text = "0";
                button_clicked = false;
            }
            else
            {
                CalculationsTextBox.AppendText("0");
            }
            equals_more = false;
            Plus_Button.Enabled = true;
            Minus_Button.Enabled = true;
            Multiply_Button.Enabled = true;
            Divide_Button.Enabled = true;
            delete_button = true;
            completed_operation = false;
        }

        private void Number_1_Click(object sender, EventArgs e)
        {   
            if (CalculationsTextBox.Text=="0" && completed_operation == true)
            {
                if (second_number_available == true)
                {
                    LabelCalculations.Text = "";
                }            
                CalculationsTextBox.Text = "1";
                button_clicked = false;
            }
            else if ((first_number == 0 && second_number == 0 && completed_operation == true) || (second_number == 0 && completed_operation == true))
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                if (second_number_available == true)
                {
                    button4_Click(sender, e);
                }           
                CalculationsTextBox.Text = "1";
                button_clicked = false;
            }
            else if (CalculationsTextBox.Text == "0")
            {
                CalculationsTextBox.Text = "1";
                button_clicked = false;
            }
            else if (button_clicked == true)
            {       
                CalculationsTextBox.Text = "1";
                button_clicked = false;
            }
            else if (completed_operation == true)
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                } 
                CalculationsTextBox.Text = "1";
                button_clicked = false;
            }
            else
            {
                CalculationsTextBox.AppendText("1");
            }
            equals_more = false;
            Plus_Button.Enabled = true;
            Minus_Button.Enabled = true;
            Multiply_Button.Enabled = true;
            Divide_Button.Enabled = true;
            delete_button = true;
            completed_operation = false;
        }

        private void Number_2_Click(object sender, EventArgs e)
        {
            if (CalculationsTextBox.Text == "0" && completed_operation == true)
            {
                if (second_number_available == true)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "2";
                button_clicked = false;
            }
            else if ((first_number == 0 && second_number == 0 && completed_operation==true) || (second_number == 0 && completed_operation==true))
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                if (second_number_available == true)
                {
                    button4_Click(sender, e);
                }
                CalculationsTextBox.Text = "2";
                button_clicked = false;
            }
            else if (CalculationsTextBox.Text == "0")
            {
                CalculationsTextBox.Text = "2";
                button_clicked = false;
            }
            else if (button_clicked == true)
            {
                CalculationsTextBox.Text = "2";
                button_clicked = false;
            }
            else if (completed_operation == true)
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "2";
                button_clicked = false;
            }
            else
            {
                CalculationsTextBox.AppendText("2");
            }
            equals_more = false;
            Plus_Button.Enabled = true;
            Minus_Button.Enabled = true;
            Multiply_Button.Enabled = true;
            Divide_Button.Enabled = true;
            delete_button = true;
            completed_operation = false;
        }

        private void Number_3_Click(object sender, EventArgs e)
        {
            if (CalculationsTextBox.Text == "0" && completed_operation == true)
            {
                if (second_number_available == true)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "3";
                button_clicked = false;
            }
            else if ((first_number == 0 && second_number == 0 && completed_operation == true) || (second_number == 0 && completed_operation == true))
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                if (second_number_available == true)
                {
                    button4_Click(sender, e);
                }
                CalculationsTextBox.Text = "3";
                button_clicked = false;
            }
            else if (CalculationsTextBox.Text == "0")
            {
                CalculationsTextBox.Text = "3";
                button_clicked = false;
            }
            else if (button_clicked == true)
            {
                CalculationsTextBox.Text = "3";
                button_clicked = false;
            }
            else if (completed_operation == true)
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "3";
            }
            else
            {
                CalculationsTextBox.AppendText("3");
            }
            equals_more = false;
            Plus_Button.Enabled = true;
            Minus_Button.Enabled = true;
            Multiply_Button.Enabled = true;
            Divide_Button.Enabled = true;
            delete_button = true;
            completed_operation = false;
        }

        private void Number_4_Click(object sender, EventArgs e)
        {
            if (CalculationsTextBox.Text == "0" && completed_operation == true)
            {
                if (second_number_available == true)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "4";
                button_clicked = false;
            }
            else if ((first_number == 0 && second_number == 0 && completed_operation == true) || (second_number == 0 && completed_operation == true))
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                if (second_number_available == true)
                {
                    button4_Click(sender, e);
                }
                CalculationsTextBox.Text = "4";
                button_clicked = false;
            }
            else if (CalculationsTextBox.Text == "0")
            {
                CalculationsTextBox.Text = "4";
                button_clicked = false;
            }
            else if (button_clicked == true)
            {
                CalculationsTextBox.Text = "4";
                button_clicked = false;
            }
            else if (completed_operation == true)
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "4";
                button_clicked = false;
            }
            else
            {
                CalculationsTextBox.AppendText("4");
            }
            equals_more = false;
            Plus_Button.Enabled = true;
            Minus_Button.Enabled = true;
            Multiply_Button.Enabled = true;
            Divide_Button.Enabled = true;
            delete_button = true;
            completed_operation = false;
        }

        private void Number_5_Click(object sender, EventArgs e)
        {
            if (CalculationsTextBox.Text == "0" && completed_operation == true)
            {
                if (second_number_available == true)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "5";
                button_clicked = false;
            }
            else if ((first_number == 0 && second_number == 0 && completed_operation == true) || (second_number == 0 && completed_operation == true))
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                if (second_number_available == true)
                {
                    button4_Click(sender, e);
                }
                CalculationsTextBox.Text = "5";
                button_clicked = false;
            }
            else if (CalculationsTextBox.Text == "0")
            {
                CalculationsTextBox.Text = "5";     
                button_clicked = false;
            }
            else if (button_clicked == true)
            {
                CalculationsTextBox.Text = "5";
                button_clicked = false;
            }
            else if (completed_operation == true)
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "5";
                button_clicked = false;
            }
            else
            {
                CalculationsTextBox.AppendText("5");
            }
            equals_more = false;
            Plus_Button.Enabled = true;
            Minus_Button.Enabled = true;
            Multiply_Button.Enabled = true;
            Divide_Button.Enabled = true;
            delete_button = true;
            completed_operation = false;
        }

        private void Number_6_Click(object sender, EventArgs e)
        {
            if (CalculationsTextBox.Text == "0" && completed_operation == true)
            {
                if (second_number_available == true)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "6";
                button_clicked = false;
            }
            else if ((first_number == 0 && second_number == 0 && completed_operation == true) || (second_number == 0 && completed_operation == true))
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                if (second_number_available == true)
                {
                    button4_Click(sender, e);
                }
                CalculationsTextBox.Text = "6";
                button_clicked = false;
            }
            else if (CalculationsTextBox.Text == "0")
            {
                CalculationsTextBox.Text = "6";
                button_clicked = false;
            }
            else if (button_clicked == true)
            {
                CalculationsTextBox.Text = "6";
                button_clicked = false;
            }
            else if (completed_operation == true)
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "6";
                button_clicked = false;
            }
            else
            {
                CalculationsTextBox.AppendText("6");
            }
            equals_more = false;
            Plus_Button.Enabled = true;
            Minus_Button.Enabled = true;
            Multiply_Button.Enabled = true;
            Divide_Button.Enabled = true;
            delete_button = true;
            completed_operation = false;
        }

        private void Number_7_Click(object sender, EventArgs e)
        {
            if (CalculationsTextBox.Text == "0" && completed_operation == true)
            {
                if (second_number_available == true)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "7";
                button_clicked = false;
            }
            else if ((first_number == 0 && second_number == 0 && completed_operation == true) || (second_number == 0 && completed_operation == true))
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                if (second_number_available == true)
                {
                    button4_Click(sender, e);
                }
                CalculationsTextBox.Text = "7";
                button_clicked = false;
            }
            else if (CalculationsTextBox.Text == "0")
            { 
                CalculationsTextBox.Text = "7";
                button_clicked = false;
            }
            else if (button_clicked == true)
            {
                CalculationsTextBox.Text = "7";
                button_clicked = false;
            }
            else if (completed_operation == true)
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "7";
                button_clicked = false;
            }
            else
            {
                CalculationsTextBox.AppendText("7");
            }
            equals_more = false;
            Plus_Button.Enabled = true;
            Minus_Button.Enabled = true;
            Multiply_Button.Enabled = true;
            Divide_Button.Enabled = true;
            delete_button = true;
            completed_operation = false;
        }

        private void Number_8_Click(object sender, EventArgs e)
        {
            if (CalculationsTextBox.Text == "0" && completed_operation == true)
            {
                if (second_number_available == true)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "8";
                button_clicked = false;
            }
            else if ((first_number == 0 && second_number == 0 && completed_operation == true) || (second_number == 0 && completed_operation == true))
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                if (second_number_available == true)
                {
                    button4_Click(sender, e);
                }
                CalculationsTextBox.Text = "8";
                button_clicked = false;
            }
            else if (CalculationsTextBox.Text == "0")
            {
                CalculationsTextBox.Text = "8";
                button_clicked = false;
            }
            else if (button_clicked == true)
            {
                CalculationsTextBox.Text = "8";
                button_clicked = false;
            }
            else if (completed_operation == true)
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "8";
                button_clicked = false;
            }
            else
            {
                CalculationsTextBox.AppendText("8");
            }
            equals_more = false;
            Plus_Button.Enabled = true;
            Minus_Button.Enabled = true;
            Multiply_Button.Enabled = true;
            Divide_Button.Enabled = true;
            delete_button = true;
            completed_operation = false;
        }

        private void Number_9_Click(object sender, EventArgs e)
        {
            if (CalculationsTextBox.Text == "0" && completed_operation == true)
            {
                if (second_number_available == true)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "9";
                button_clicked = false;
            }
            else if ((first_number == 0 && second_number == 0 && completed_operation == true) || (second_number == 0 && completed_operation == true))
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                if (second_number_available == true)
                {
                    button4_Click(sender, e);
                }
                CalculationsTextBox.Text = "9";
                button_clicked = false;
            }
            else if (CalculationsTextBox.Text == "0")
            {
                CalculationsTextBox.Text = "9";
                button_clicked = false;
            }
            else if (button_clicked == true)
            {
                CalculationsTextBox.Text = "9";
                button_clicked = false;
            }
            else if (completed_operation == true)
            {
                if (second_number_available != false)
                {
                    LabelCalculations.Text = "";
                }
                CalculationsTextBox.Text = "9";
            }
            else
            {
                CalculationsTextBox.AppendText("9");
            }
            equals_more = false;
            Plus_Button.Enabled = true;
            Minus_Button.Enabled = true;
            Multiply_Button.Enabled = true;
            Divide_Button.Enabled = true;
            delete_button = true;
            completed_operation = false;
        }

        private void Plus_Button_Click(object sender, EventArgs e)
        {
            if (button_clicked == false)
            {
                times_clicked++;
                if (times_clicked >= 2 && operation_button==true)
                {
                    Equals_Button_Click(sender, e);
                }
                equals_more = false;
                delete_button = false;
                completed_operation = false;
                operation_button = true;
                button_clicked = true;
                second_number_available = true;    
                try
                {
                    first_number = double.Parse(CalculationsTextBox.Text);
                    LabelCalculations.Text = first_number + "+";
                }
                catch (System.FormatException)
                {
                    Equals_Button_Click(sender, e);
                    LabelCalculations.Text = first_number + "/0+";
                }
                operation = "+";
                first_number_nodelete = false;
            }
            else
            {
                operation = "+";
                switch (operation)
                {
                    case "+":
                        LabelCalculations.Text = first_number + "+";
                        break;
                    case "-":
                        LabelCalculations.Text = first_number + "+";
                        break;
                    case "x":
                        LabelCalculations.Text = first_number + "+";
                        break;
                    case "/":
                        LabelCalculations.Text = first_number + "+";
                        break;
                }
            }
           
        }
            

        private void Minus_Button_Click(object sender, EventArgs e)
        {
            if (button_clicked == false)
            {
                times_clicked++;
                if (times_clicked >= 2 && operation_button == true)
                {
                    Equals_Button_Click(sender, e);
                }
                equals_more = false;
                delete_button = false;
                completed_operation = false;
                operation_button = true;
                button_clicked = true;
                second_number_available = true;
                try
                {
                    first_number = double.Parse(CalculationsTextBox.Text);
                    LabelCalculations.Text = first_number + "-";
                }
                catch (System.FormatException)
                {
                    Equals_Button_Click(sender, e);
                    LabelCalculations.Text = first_number + "/0-";
                }
                operation = "-"; 
                first_number_nodelete = false;
            }
            else
            {
                operation = "-";
                switch (operation)
                {
                   
                    case "+":
                        LabelCalculations.Text = first_number + "-";         
                        break;
                    case "-":
                        LabelCalculations.Text = first_number + "-";
                        break;
                    case "x":
                        LabelCalculations.Text = first_number + "-";
                        break;
                    case "/":
                        LabelCalculations.Text = first_number + "-";
                        break;
                }
            }
            
        }

        private void Multiply_Button_Click(object sender, EventArgs e)
        {
            if (button_clicked == false)
            {
                times_clicked++;
                if (times_clicked >= 2 && operation_button == true)
                {
                    Equals_Button_Click(sender, e);
                }
                equals_more = false;
                delete_button = false;
                completed_operation = false;
                operation_button = true;
                button_clicked = true;
                second_number_available = true;
                try
                {
                    first_number = double.Parse(CalculationsTextBox.Text);
                    LabelCalculations.Text = first_number + "x";
                }
                catch (System.FormatException)
                {
                    Equals_Button_Click(sender, e);
                    LabelCalculations.Text = first_number + "/0x";
                }
                operation = "x";
                first_number_nodelete = false;
            }
            else
            {
                operation = "x";
                switch (operation)
                {
                    case "+":
                        LabelCalculations.Text = first_number + "x";
                        break;
                    case "-":
                        LabelCalculations.Text = first_number + "x";
                        break; 
                    case "x":
                        LabelCalculations.Text = first_number + "x";
                        break;
                    case "/":
                        LabelCalculations.Text = first_number + "x";
                        break;
                }
            }
           
        }

        private void Divide_Button_Click(object sender, EventArgs e)
        {
            if (button_clicked == false)
            {
                times_clicked++;
                if (times_clicked >= 2 && operation_button == true)
                {
                    Equals_Button_Click(sender, e);
                }
                equals_more = false;
                delete_button = false;
                completed_operation = false;
                operation_button = true;
                button_clicked = true;
                second_number_available = true;
                try
                {
                    first_number = double.Parse(CalculationsTextBox.Text);
                    LabelCalculations.Text = first_number + "/";
                }
                catch (System.FormatException)
                {
                    Equals_Button_Click(sender, e);
                    LabelCalculations.Text = first_number + "/0/";
                }
                operation = "/";
                first_number_nodelete = false;
            }
            else
            {
                operation = "/";
                switch (operation)
                {
                    case "+":
                        LabelCalculations.Text = first_number + "/";
                        break;
                    case "-":
                        LabelCalculations.Text = first_number + "/";
                        break;
                    case "x":
                        LabelCalculations.Text = first_number + "/";
                        break;
                    case "/":
                        LabelCalculations.Text = first_number + "/";
                        break;
                }
            } 
        }

        private void Equals_Button_Click(object sender, EventArgs e)
        {       
            if (second_number_available == true) {
                delete_button = true;
                operation_button = false;
                completed_operation = true;
                switch (operation)
                {
                    case "+":
                        if (equals_more == false)
                        {
                            if (first_number_nodelete == false)
                            {
                                second_number = double.Parse(CalculationsTextBox.Text);
                            }
                            else 
                            {
                                first_number= double.Parse(CalculationsTextBox.Text);
                            }                      
                        }
                        else
                        {
                            first_number = first_number + second_number;
                        } 
                        LabelCalculations.Text = first_number + operation + second_number+ "=";
                        result = first_number + second_number;
                        CalculationsTextBox.Text = result.ToString();
                        break;
                    case "-":
                        if (equals_more == false)
                        {
                            if (first_number_nodelete == false)
                            {
                                second_number = double.Parse(CalculationsTextBox.Text);
                            }
                            else
                            {
                                first_number = double.Parse(CalculationsTextBox.Text);
                            }
                        }
                        else
                        {
                            first_number = first_number - second_number;
                        }
                        LabelCalculations.Text = first_number + operation + second_number+ "=";
                        result = first_number - second_number;
                        CalculationsTextBox.Text = result.ToString();
                        break;
                    case "x":
                        if (equals_more == false)
                        {
                            if (first_number_nodelete== false)
                            {
                                second_number = double.Parse(CalculationsTextBox.Text);
                            }
                            else
                            {
                                first_number = double.Parse(CalculationsTextBox.Text);
                            }
                        }
                        else
                        {
                            first_number= first_number * second_number;
                        }
                        LabelCalculations.Text = first_number + operation + second_number+ "=";
                        result = first_number * second_number;
                        CalculationsTextBox.Text = result.ToString();
                        break;
                    case "/":
                        if (equals_more == false && first_number_nodelete==false)
                        {
                            second_number = double.Parse(CalculationsTextBox.Text);
                        }
                        if (first_number == 0 && second_number == 0)
                        {
                            if (equals_more == false)
                            {
                                second_number = 0;
                                result = first_number / second_number;
                                LabelCalculations.Text = first_number + operation + second_number + "=";
                                CalculationsTextBox.Text = "Result is undefined.";
                                Plus_Button.Enabled = false;
                                Minus_Button.Enabled = false;
                                Multiply_Button.Enabled = false;
                                Divide_Button.Enabled = false;
                            }
                            else {
                                if (CalculationsTextBox.Text == "You cannot divide by zero."
                               || CalculationsTextBox.Text == "Result is undefined.")
                                {
                                    LabelCalculations.Text = "";
                                    CalculationsTextBox.Text = "0";
                                    Plus_Button.Enabled = true;
                                    Minus_Button.Enabled = true;
                                    Multiply_Button.Enabled = true;
                                    Divide_Button.Enabled = true;
                                    button4_Click(sender, e);
                                }

                            } 
                        }
                        else if (second_number == 0)
                        {
                            if (equals_more == false)
                            {
                                second_number = 0;
                                result = first_number / second_number;
                                LabelCalculations.Text = first_number + operation + second_number + "=";
                                CalculationsTextBox.Text = "You cannot divide by zero.";
                                Plus_Button.Enabled = false;
                                Minus_Button.Enabled = false;
                                Multiply_Button.Enabled = false;
                                Divide_Button.Enabled = false;
                            }
                            else
                            {
                                if (CalculationsTextBox.Text == "You cannot divide by zero."
                               || CalculationsTextBox.Text == "Result is undefined.")
                                {
                                    LabelCalculations.Text = "";
                                    CalculationsTextBox.Text = "0";
                                    Plus_Button.Enabled = true;
                                    Minus_Button.Enabled = true;
                                    Multiply_Button.Enabled = true;
                                    Divide_Button.Enabled = true;
                                    button4_Click(sender, e);
                                }
                            }
                            
                        }
                        else
                        {
                            if (equals_more == false)
                            {
                                if (first_number_nodelete == false)
                                {
                                    second_number = double.Parse(CalculationsTextBox.Text);
                                }
                                else
                                {
                                    first_number = double.Parse(CalculationsTextBox.Text);
                                }
                            }
                            else
                            {
                                first_number = first_number / second_number;
                            }
                            result = first_number / second_number;
                            LabelCalculations.Text = first_number+ operation + second_number+"=";
                            CalculationsTextBox.Text = result.ToString();
                        }
                        break;
                }
                button_clicked = false;
            }
            else
            {
                delete_button = true;
                operation_button = false;
                completed_operation = true;
                first_number = double.Parse(CalculationsTextBox.Text);
                LabelCalculations.Text = first_number + "=";
                if (first_number == 0)
                {
                    LabelCalculations.Text = first_number + "=";
                }
                CalculationsTextBox.Text = Convert.ToString(first_number);
            }
            equals_more = true;
            first_number_nodelete = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            first_number = 0;
            second_number = 0;
            result = 0;
            operation = "";
            CalculationsTextBox.Text = "0";
            times_clicked = 0;
            button_clicked = false;
            equals_more = false;
            second_number_available = false;
            completed_operation = false;
            Plus_Button.Enabled = true;
            Minus_Button.Enabled = true;
            Multiply_Button.Enabled = true;
            Divide_Button.Enabled = true;
            first_number_nodelete = false;
            LabelCalculations.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (delete_button == true)
            {
                if (CalculationsTextBox.Text == "You cannot divide by zero." 
                    || CalculationsTextBox.Text=="Result is undefined.")
                {
                    CalculationsTextBox.Text = "0";
                    button4_Click(sender, e);
                }
                if (completed_operation == false)
                {
                    try
                    {     
                        CalculationsTextBox.Text = CalculationsTextBox.Text.Substring(0,
                      (CalculationsTextBox.TextLength - 1));
                        if (CalculationsTextBox.TextLength == 0)
                        {
                            CalculationsTextBox.Text = "0";
                            Plus_Button.Enabled = true;
                            Minus_Button.Enabled = true;
                            Multiply_Button.Enabled = true;
                            Divide_Button.Enabled = true;
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }
                else
                {
                    if (second_number_available == true)
                    {
                        LabelCalculations.Text = "";
                        first_number_nodelete = true;
                    }
                }
            }
            Plus_Button.Enabled = true;
            Minus_Button.Enabled = true;
            Multiply_Button.Enabled = true;
            Divide_Button.Enabled = true;
            equals_more = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {

            }
            else
            {
                if (e.KeyCode.Equals(Keys.Enter) || e.KeyCode.Equals(Keys.Oemplus))
                {
                    Equals_Button_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.D0) || e.KeyCode == Keys.NumPad0)
                {
                    Number_0_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.D1) || e.KeyCode == Keys.NumPad1)
                {
                    Number_1_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.D2) || e.KeyCode == Keys.NumPad2)
                {
                    Number_2_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.D3) || e.KeyCode == Keys.NumPad3)
                {
                    Number_3_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.D4) || e.KeyCode == Keys.NumPad4)
                {
                    Number_4_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.D5) || e.KeyCode == Keys.NumPad5)
                {
                    Number_5_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.D6) || e.KeyCode == Keys.NumPad6)
                {
                    Number_6_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.D7) || e.KeyCode == Keys.NumPad7)
                {
                    Number_7_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.D8) || e.KeyCode == Keys.NumPad8)
                {
                    if ((e.KeyCode.Equals(Keys.D8) && e.Shift))
                    {

                    }
                    else
                    {
                        Number_8_Click(sender, e);
                    }
                }
                if (e.KeyCode.Equals(Keys.D9) || e.KeyCode == Keys.NumPad9)
                {
                    Number_9_Click(sender, e);
                }

            }

            if (e.KeyCode.Equals(Keys.Escape) || e.KeyCode.Equals(Keys.Oem4))
            {
                button4_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.Back) || e.KeyCode.Equals(Keys.Delete) || e.KeyCode.Equals(Keys.Oem1))
            {
                button16_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.Oemplus) && e.Shift || e.KeyCode.Equals(Keys.Add))
            {
                Plus_Button_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.OemMinus) || e.KeyCode.Equals(Keys.Subtract))
            {
                Minus_Button_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.X) || (e.KeyCode.Equals(Keys.D8) && e.Shift) || e.KeyCode.Equals(Keys.Multiply))
            {
                Multiply_Button_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.OemQuestion) || e.KeyCode.Equals(Keys.Divide))
            {
                Divide_Button_Click(sender, e);
            }
        }
        void control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CalculationsTextBox.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {      
            string fraction = Clipboard.GetText();
            char[] calculated_fraction = fraction.ToCharArray();

            foreach(char numbers in calculated_fraction)
            {
                switch (numbers)
                {
                    case '0':
                        Number_0_Click(sender, e);
                        break;
                    case '1':
                        Number_1_Click(sender, e);
                        break;
                    case '2':
                        Number_2_Click(sender, e);
                        break;
                    case '3':
                        Number_3_Click(sender, e);
                        break;
                    case '4':
                        Number_4_Click(sender, e);
                        break;
                    case '5':
                        Number_5_Click(sender, e);
                        break;
                    case '6':
                        Number_6_Click(sender, e);
                        break;
                    case '7':
                        Number_7_Click(sender, e);
                        break;
                    case '8':
                        Number_8_Click(sender, e);
                        break;
                    case '9':
                        Number_9_Click(sender, e);
                        break; 
                    case '+':
                        Plus_Button_Click(sender, e);
                        break;
                    case '-':
                        Minus_Button_Click(sender, e);
                        break;
                    case '*':
                        Multiply_Button_Click(sender, e);
                        break;
                    case '/':
                        Divide_Button_Click(sender, e);
                        break;
                    case '=':
                        Equals_Button_Click(sender, e);
                        break;
                }
            }
        }
    }
}
