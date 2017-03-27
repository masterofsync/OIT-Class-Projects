using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sign = null;
            Value1 = null;
            Value2 = null;
            MemoryData = null;
            result = 0;
        }

        bool nonNumberEntered;
        static string Sign;
        static string Value1;
        static string Value2;
        private string MemoryData;
        static double result;


        private void button21_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (UserData.TextLength < 10)
            {
                if (UserData.TextLength == 1 && UserData.Text == "0")
                {
                    UserData.Text = "";
                }

                UserData.Text = UserData.Text + "1";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UserData_TextChanged(object sender, EventArgs e)
        {
            UserData.Focus();
        }

        private void UserData_KeyDown(object sender, KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard. 
            if (e.KeyCode != Keys.OemPeriod)
            {
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {
                    // Determine whether the keystroke is a number from the keypad. 
                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    {
                        // Determine whether the keystroke is a backspace. 
                        if (e.KeyCode != Keys.Back)
                        {
                            // A non-numerical keystroke was pressed. 
                            // Set the flag to true and evaluate in KeyPress event.
                            nonNumberEntered = true;
                        }
                    }
                }
            }

            //If shift key was pressed, it's not a number. 
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }

        }

        private void UserData_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event. 
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }

        }

        private void UserData_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.OemMinus)
            {
                Sign = "-";

                Value1 = UserData.Text;
                equation.Text = Value1 + " " + Sign;
                UserData.Clear();
            }

            if (e.KeyCode == Keys.Oemplus)
            {
                Sign = "+";

                Value1 = UserData.Text;
                equation.Text = Value1 + " " + Sign;
                UserData.Clear();
            }

            if (e.KeyCode == Keys.P)
            {
                Sign = "*";

                Value1 = UserData.Text;
                equation.Text = Value1 + " " + Sign ;
                UserData.Clear();
            }

            if (e.KeyCode == Keys.D)
            {
                Sign = "/";

                Value1 = UserData.Text;
                
                equation.Text = Value1 + " " + Sign;
                UserData.Clear();
            }


            
            
            if (e.KeyCode == Keys.Enter && Sign != null)
            {
                double val1 = Convert.ToDouble(Value1);
                double val2;

                Value2 = UserData.Text;
                val2 = Convert.ToDouble(Value2);

                equation.Text = "";
                
                if(Sign == "+")
                {
                    result = val1 + val2;
                }

                if (Sign == "-")
                {
                    result = val1 - val2;
                }

                if (Sign == "*")
                {
                    result = val1 * val2;
                }

                if (Sign == "/")
                {
                    result = val1 / val2;   
                }

                if (Sign == "%")
                {
                    result = val1 % val2;
                }
                UserData.Text = result.ToString();
                process.Text = Value1 + " " + Sign + " " + Value2;
                result = 0;
                Value1 = null;
                Value2 = null;
                UserData.Focus();
                
            }

            
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            Sign = "-";
            
            Value1 = UserData.Text;
            equation.Text = Value1 + " " + Sign;
            UserData.Clear();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Sign = "+";

            Value1 = UserData.Text;
            
            equation.Text = Value1 + " " + Sign;
            UserData.Clear();
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            Sign = "/";
            Value1 = UserData.Text;

            equation.Text = Value1 + " " + Sign;
            UserData.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Sign = "%";
           
                Value1 = UserData.Text;
                equation.Text = Value1 + " " + Sign;
                UserData.Clear();
        }

        private void ButtonSquare_Click(object sender, EventArgs e)
        {
            double tempval = Convert.ToDouble (UserData.Text);
            result = tempval * tempval;
            UserData.Text = result.ToString();
            process.Text = tempval + " " + "^" + " " + "2"; 
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            Sign = "*";
            
                Value1 = UserData.Text;

                equation.Text = Value1 + " " + Sign;
                UserData.Clear();
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (UserData.TextLength < 10)
            {
                if (UserData.TextLength == 1 && UserData.Text == "0")
                {
                    UserData.Text = "";
                }
                UserData.Text = UserData.Text + "2";
            }
        }


        private void three_Click(object sender, EventArgs e)
        {
            if (UserData.TextLength < 10)
            {
                if (UserData.TextLength == 1 && UserData.Text == "0")
                {
                    UserData.Text = "";
                }
                UserData.Text = UserData.Text + "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (UserData.TextLength < 10)
            {
                if (UserData.TextLength == 1 && UserData.Text == "0")
                {
                    UserData.Text = "";
                }
                UserData.Text = UserData.Text + "4";

            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (UserData.TextLength < 10)
            {
                if (UserData.TextLength == 1 && UserData.Text == "0")
                {
                    UserData.Text = "";
                }
                UserData.Text = UserData.Text + "5";

            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (UserData.TextLength < 10)
            {
                if (UserData.TextLength == 1 && UserData.Text == "0")
                {
                    UserData.Text = "";
                }
                UserData.Text = UserData.Text + "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (UserData.TextLength < 10)
            {
                if (UserData.TextLength == 1 && UserData.Text == "0")
                {
                    UserData.Text = "";
                }
                UserData.Text = UserData.Text + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (UserData.TextLength < 10)
            {
                if (UserData.TextLength == 1 && UserData.Text == "0")
                {
                    UserData.Text = "";
                }
                UserData.Text = UserData.Text + "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (UserData.TextLength < 10)
            {
                if (UserData.TextLength == 1 && UserData.Text == "0")
                {
                    UserData.Text = "";
                }
                UserData.Text = UserData.Text + "9";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (UserData.TextLength < 10)
            {
                if (UserData.TextLength == 1 && UserData.Text == "0")
                {
                    UserData.Text = "";
                }
                UserData.Text = UserData.Text + "0";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (UserData.TextLength < 10)
            {
                if (UserData.TextLength == 1 && UserData.Text == "0")
                {
                    UserData.Text = "";
                }
                UserData.Text = UserData.Text + ".";
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            process.Text = "";
            Sign = null;
            Value1 = null;
            Value2 = null;
            result = 0;
            UserData.Text = "0";
        }

        

        private void ButtonMc_Click(object sender, EventArgs e)
        {
            MemoryData = null;
            UserData.Focus();
        }

        private void ButtonMr_Click(object sender, EventArgs e)
        {
            UserData.Text = MemoryData;
            UserData.Focus();
        }

        private void ButtonMplus_Click(object sender, EventArgs e)
        {
            double val1;
            double val2;
            double total;
            if (MemoryData == null)
            {
                MemoryData = UserData.Text;
            }
            else
            {
               
                if (UserData.Text != "0" && UserData.Text != "")
                {
                    val1 = Convert.ToDouble(MemoryData);
                    val2 = Convert.ToDouble(UserData.Text);

                    total = val1 + val2;
                    MemoryData = (total).ToString();
                }
            }
            UserData.Focus();
        }

        private void ButtonMminus_Click(object sender, EventArgs e)
        {
            double val1;
            double val2;
            double total;
            if (MemoryData != null)
            {
               
                if (UserData.Text != "0" && UserData.Text != "")
                {
                    val1 = Convert.ToDouble(MemoryData);
                    val2 = Convert.ToDouble(UserData.Text);

                    total = val1 - val2;
                    MemoryData = (total).ToString();
                }
            }
            UserData.Focus();
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {

        }

        private void ButtonEquals_Click_1(object sender, EventArgs e)
        {
            if (Sign != null)
            {
                double val1 = Convert.ToDouble(Value1);
                double val2;

                Value2 = UserData.Text;
                val2 = Convert.ToDouble(Value2);

                equation.Text = "";

                if (Sign == "+")
                {
                    result = val1 + val2;
                }

                if (Sign == "-")
                {
                    result = val1 - val2;
                }

                if (Sign == "*")
                {
                    result = val1 * val2;
                }

                if (Sign == "/")
                {
                    result = val1 / val2;
                }

                if (Sign == "%")
                {
                    result = val1 % val2;
                }
                UserData.Text = result.ToString();

                result = 0;
                Value1 = null;
                Value2 = null;

                process.Text = Value1 + " " + Sign + " " + Value2; 
            }

        }
    }
}




