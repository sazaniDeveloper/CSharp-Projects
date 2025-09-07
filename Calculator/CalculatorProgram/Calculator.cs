using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApplicationInTwoYears
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            Results_TextBox.Text = "0";
        }

        double operand_1;
        double operand_2;
        string operation_op;
        bool operator_chosen = false;
        bool result=false;
        bool operation_1_chosen=false;
        


        private void calculation(double operand_1,double operand_2,string operation)
        {
            double final_result;
            result = true;
            operand_2 = Convert.ToDouble(Results_TextBox.Text.ToString());
            operator_chosen = true;
          
            switch (operation_op)
            {
                case "+":
                    final_result = operand_1 + operand_2;
                    labelMath.Text = final_result.ToString() + "+";
                    Results_TextBox.Text = final_result.ToString();
                    break;

                case "-":
                    final_result = operand_1 - operand_2;
                    labelMath.Text = final_result.ToString() + "-";
                    Results_TextBox.Text = final_result.ToString();
                    break;

                case "x":
                    final_result = operand_1 * operand_2;
                    labelMath.Text = final_result.ToString() + "x";
                    Results_TextBox.Text = final_result.ToString();
                    break;

                case "/":
                    try
                    {
                        final_result = operand_1 / operand_2;
                        labelMath.Text = final_result.ToString() + "/";
                        Results_TextBox.Text = final_result.ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        if (operand_1 == 0 && operand_2 == 0)
                        {

                            Results_TextBox.Text = "Result is undefined";
                        }
                        else
                        {
                            Results_TextBox.Text = "Cannot divide by Zero";
                        }
                    }
                    break;
            }
        }
        

        private void Number_1_Click(object sender, EventArgs e)
        {
            if (operator_chosen == true)
            {
                Results_TextBox.Text = "1";
            }
            else if (result == true)
            {
                Results_TextBox.Text = "1";
                labelMath.Text = "";
            }
            else if (Results_TextBox.Text == "0")
            {
                Results_TextBox.Text = "1";
            }
            else if (operator_chosen == false)
            {
                Results_TextBox.Text += "1";
                
            }
            result = false;
            operator_chosen = false;

        }

        private void Number_2_Click(object sender, EventArgs e)
        {
            if (operator_chosen == true)
            {
                Results_TextBox.Text = "2";
            }
            else if (result == true)
            {
                Results_TextBox.Text = "2";
                labelMath.Text = "";
               
            }
            else if (Results_TextBox.Text == "0")
            {
                Results_TextBox.Text = "2";
            }
            else if (operator_chosen == false)
            {
                Results_TextBox.Text += "2";
               
            }
            result = false;
            operator_chosen = false;
        }

        private void Number_3_Click(object sender, EventArgs e)
        {
            if (operator_chosen == true)
            {
                Results_TextBox.Text = "3";
            }
            else if (result == true)
            {
                Results_TextBox.Text = "3";
                labelMath.Text = "";
               
            }
            else if (Results_TextBox.Text == "0")
            {
                Results_TextBox.Text = "3";
            }
            else if (operator_chosen == false)
            {
                Results_TextBox.Text += "3";

            }
            result = false;
            operator_chosen = false;
        }

        private void Number_4_Click(object sender, EventArgs e)
        {
            if (operator_chosen == true)
            {
                Results_TextBox.Text = "4";
            }
            else if (result == true)
            {
                Results_TextBox.Text = "4";
                labelMath.Text = "";
               
            }
            else if (Results_TextBox.Text == "0")
            {
                Results_TextBox.Text = "4";
            }
            else if (operator_chosen == false)
            {
                Results_TextBox.Text += "4";
                
            }
            result = false;
            operator_chosen = false;
        }

        private void Number_5_Click(object sender, EventArgs e)
        {
            if (operator_chosen == true)
            {
                Results_TextBox.Text = "5";
            }
            else if (result == true)
            {
                Results_TextBox.Text = "5";
                labelMath.Text = "";
               
            }
            else if (Results_TextBox.Text == "0")
            {
                Results_TextBox.Text = "5";
            }
            else if (operator_chosen == false)
            {
                Results_TextBox.Text += "5";

            }
            result = false;
            operator_chosen = false;
        }

        private void Number_6_Click(object sender, EventArgs e)
        {
            if (operator_chosen == true)
            {
                Results_TextBox.Text = "6";
            }
            else if (result == true)
            {
                Results_TextBox.Text = "6";
                labelMath.Text = "";
            }
            else if (Results_TextBox.Text == "0")
            {
                Results_TextBox.Text = "6";
            }
            else if (operator_chosen == false)
            {
                Results_TextBox.Text += "6";

            }
            result = false;
            operator_chosen = false;
        }

        private void Number_7_Click(object sender, EventArgs e)
        {
            if (operator_chosen == true)
            {
                Results_TextBox.Text = "7";
            }
            else if (result == true)
            {
                Results_TextBox.Text = "7";
                labelMath.Text = "";
               
            }
            else if (Results_TextBox.Text == "0")
            {
                Results_TextBox.Text = "7";
            }
            else if (operator_chosen == false)
            {
                Results_TextBox.Text += "7";
                
            }
            result = false;
            operator_chosen = false;
        }

        private void Number_8_Click(object sender, EventArgs e)
        {
            if (operator_chosen == true)
            {
                Results_TextBox.Text = "8";
            }
            else if (result == true)
            {
                Results_TextBox.Text = "8";
                labelMath.Text = "";
               
            }
            else if (Results_TextBox.Text == "0")
            {
                Results_TextBox.Text = "8";
            }
            else if (operator_chosen == false)
            {
                Results_TextBox.Text += "8";

            }
            result = false;
            operator_chosen = false;
        }

        private void Number_9_Click(object sender, EventArgs e)
        {
            if (operator_chosen == true)
            {
                Results_TextBox.Text = "9";
            }
            else if (result == true)
            {
                Results_TextBox.Text = "9";
                labelMath.Text = "";
            }
            else if (Results_TextBox.Text == "0")
            {
                Results_TextBox.Text = "9";
            }
            else if (operator_chosen==false)
            {
                Results_TextBox.Text += "9";

            }
            result = false;
            operator_chosen = false;
        }

        private void Number_0_Click(object sender, EventArgs e)
        {
            if (operator_chosen == true)
            {
                Results_TextBox.Text = "";
            }
            else if (result == true)
            {
                Results_TextBox.Text = "";
                labelMath.Text = "";
            }

            if (Results_TextBox.Text == "0")
            {
                Results_TextBox.Text = "0";
            }
            else {
                Results_TextBox.Text += "0";
            }
            result = false;
            operator_chosen = false;
        }

        private void plus_operator_Click(object sender, EventArgs e)
        {
            if (operation_1_chosen == true && operator_chosen==false)
            {
                calculation(operand_1, operand_2, operation_op);
               
            } else 
            {
                operand_1 = Convert.ToDouble(Results_TextBox.Text.ToString());
                operation_op = "+";
                labelMath.Text = operand_1.ToString() + operation_op.ToString();
                operator_chosen = true;
                operation_1_chosen = true;
            }         
        }

        private void minus_operator_Click(object sender, EventArgs e)
        {
            if (operation_1_chosen == true && operator_chosen == false)
            {
                calculation(operand_1, operand_2, operation_op);
            }
            else
            {
                operand_1 = Convert.ToDouble(Results_TextBox.Text.ToString());
                operation_op = "-";
                labelMath.Text = operand_1.ToString() + operation_op.ToString();
                operator_chosen = true;
                operation_1_chosen = true;
            }
        }

        private void multiply_operator_Click(object sender, EventArgs e)
        {
            if (operation_1_chosen == true && operator_chosen == false)
            {
                calculation(operand_1, operand_2, operation_op);
            }
            else
            {
                operand_1 = Convert.ToDouble(Results_TextBox.Text.ToString());
                operation_op = "x";
                labelMath.Text = operand_1.ToString() + operation_op.ToString();
                operator_chosen = true;
                operation_1_chosen = true;
            }    
        }

        private void division_operator_Click(object sender, EventArgs e)
        {
            if (operation_1_chosen == true && operator_chosen == false)
            {
                calculation(operand_1, operand_2, operation_op);
            } 
            else
            {
                operand_1 = Convert.ToDouble(Results_TextBox.Text.ToString());
                operation_op = "/";
                labelMath.Text = operand_1.ToString() + operation_op.ToString();
                operator_chosen = true;
                operation_1_chosen = true;
            }
        }

        private void equals_button_Click(object sender, EventArgs e)
        {
            double final_result;
            result = true;
            operation_1_chosen = false;
            operand_2 = Convert.ToDouble(Results_TextBox.Text.ToString());
            labelMath.Text = operand_1.ToString() + operation_op.ToString()+operand_2.ToString()+"=";
            switch (operation_op)
            {
                case "+":
                    final_result = operand_1 + operand_2;
                    Results_TextBox.Text = final_result.ToString();
                    break;

                case "-":
                    final_result = operand_1 - operand_2;
                    Results_TextBox.Text = final_result.ToString();
                    break;

                case "x":
                    final_result = operand_1 * operand_2;
                    Results_TextBox.Text = final_result.ToString();
                    break;

                case "/":
                    try
                    {
                        final_result = operand_1 / operand_2;
                        Results_TextBox.Text = final_result.ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        if (operand_1 == 0 && operand_2 == 0)
                        {
                            Results_TextBox.Text = "Result is undefined";
                        }
                        else
                        {
                            Results_TextBox.Text = "Cannot divide by Zero";
                        }
                    }
                    break;
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (Results_TextBox.Text.ToString().Length!=1 && result!=true)
            {
                string delete = Results_TextBox.Text.ToString();
                Results_TextBox.Text = delete.Substring(0, delete.Length - 1);
            }
            else if (Results_TextBox.Text.Length == 1)
            {
                Results_TextBox.Text = "0";
            }
            else if (result == true)
            {
                labelMath.Text = "";
            }
        }

        private void Number_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                Number_1_Click(sender, e);  
            }
        }

        private void Number_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D2)
            {
                Number_2_Click(sender, e);
            }
        }

        private void Number_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D3)
            {
                Number_3_Click(sender, e);
            }
        }

        private void Number_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D4)
            {
                Number_4_Click(sender, e);
            }
          
        }

        private void Number_5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D5)
            {
                Number_5_Click(sender, e);
            }
        }

        private void Number_6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D6)
            {
                Number_6_Click(sender, e);
            }
        }

        private void Number_7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D7)
            {
                Number_7_Click(sender, e);
            }
        }

        private void Number_8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D8)
            {
                Number_8_Click(sender, e);
            }
        }

        private void Number_9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D9)
            {
                Number_9_Click(sender, e);
            }
        }
        private void Number_0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0)
            {
                Number_0_Click(sender, e);
            }
        }

        private void plus_operator_KeyDown(object sender, KeyEventArgs e)
        {
            plus_operator_Click(sender, e);
        }

        private void minus_operator_KeyDown(object sender, KeyEventArgs e)
        {
            minus_operator_Click(sender , e);
        }

        private void multiply_operator_KeyDown(object sender, KeyEventArgs e)
        {
            multiply_operator_Click(sender, e);
        }

        private void division_operator_KeyDown(object sender, KeyEventArgs e)
        {
            division_operator_Click(sender , e);
        }

        private void equals_button_KeyDown(object sender, KeyEventArgs e)
        {
            equals_button_Click(sender, e);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
