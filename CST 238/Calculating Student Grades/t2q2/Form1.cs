using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t2q2
{
    public partial class Form1 : Form
    {
       /* public string num1{get;}*/
        /*,num2,num3,num4,num5,num6,num7,num8,num9,num10,num11,num12,num13,num14,num15,num16,num17,num18,num19,num20;
        
         */

        
          bool nonNumberEntered;
        
        float n1,n2,n3,n4,n5,n6,n7,n8,n9,n10,n11,n12,n13,n14,n15,n16,n17,n18,n19,n20,total;
        int []a;
        int student;
        float average;

       

        public Form1()
        {
            InitializeComponent();
            a = new int[21];
            student = 0;
            average = 0;
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
              
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            

            if (e.KeyCode != Keys.OemPeriod)
            {
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {

                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    {

                        if (e.KeyCode != Keys.Back)
                        {

                            nonNumberEntered = true;
                        }
                    }
                }
            }


            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "" || textBox19.Text == "" || textBox20.Text == "")
            {
                MessageBox.Show("Please Enter 0 for no student");
            }
            else
            {
                n1 = Convert.ToSingle(textBox1.Text);
                n2 = Convert.ToSingle(textBox2.Text);
                n3 = Convert.ToSingle(textBox3.Text);
                n4 = Convert.ToSingle(textBox4.Text);
                n5 = Convert.ToSingle(textBox5.Text);
                n6 = Convert.ToSingle(textBox6.Text);
                n7 = Convert.ToSingle(textBox7.Text);
                n8 = Convert.ToSingle(textBox8.Text);
                n9 = Convert.ToSingle(textBox9.Text);
                n10 = Convert.ToSingle(textBox10.Text);
                n11 = Convert.ToSingle(textBox11.Text);
                n12 = Convert.ToSingle(textBox12.Text);
                n13 = Convert.ToSingle(textBox13.Text);
                n14 = Convert.ToSingle(textBox14.Text);
                n15 = Convert.ToSingle(textBox15.Text);
                n16 = Convert.ToSingle(textBox16.Text);
                n17 = Convert.ToSingle(textBox17.Text);
                n18 = Convert.ToSingle(textBox18.Text);
                n19 = Convert.ToSingle(textBox19.Text);
                n20 = Convert.ToSingle(textBox20.Text);

                if (n1 > 100 || n2 > 100 || n3 > 100 || n4 > 100 || n5 > 100 || n6 > 100 || n7 > 100 || n8 > 100 || n9 > 100 || n10 > 100 || n11 > 100 || n12 > 100 || n13 > 100 || n14 > 100 || n15 > 100 || n16 > 100 || n17 > 100 || n18 > 100 || n19 > 100 || n20 > 100)
                {
                    MessageBox.Show("Please enter Test Score below 100");
                }
                else
                {
                    if (n1 == 0)
                    {
                        a[1] = 0;
                    }
                    else
                    {
                        a[1] = 1;
                    }

                    if (n2 == 0)
                    {
                        a[2] = 0;
                    }
                    else
                    {
                        a[2] = 1;
                    }

                    if (n3 == 0)
                    {
                        a[3] = 0;
                    }
                    else
                    {
                        a[3] = 1;
                    }

                    if (n4 == 0)
                    {
                        a[4] = 0;
                    }
                    else
                    {
                        a[4] = 1;
                    }

                    if (n5 == 0)
                    {
                        a[5] = 0;
                    }
                    else
                    {
                        a[5] = 1;
                    }

                    if (n6 == 0)
                    {
                        a[6] = 0;
                    }
                    else
                    {
                        a[6] = 1;
                    }

                    if (n7 == 0)
                    {
                        a[7] = 0;
                    }
                    else
                    {
                        a[7] = 1;
                    }

                    if (n8 == 0)
                    {
                        a[8] = 0;
                    }
                    else
                    {
                        a[8] = 1;
                    }

                    if (n9 == 0)
                    {
                        a[9] = 0;
                    }
                    else
                    {
                        a[9] = 1;
                    }

                    if (n10 == 0)
                    {
                        a[10] = 0;
                    }
                    else
                    {
                        a[10] = 1;
                    }

                    if (n11 == 0)
                    {
                        a[11] = 0;
                    }
                    else
                    {
                        a[11] = 1;
                    }

                    if (n12 == 0)
                    {
                        a[12] = 0;
                    }
                    else
                    {
                        a[12] = 1;
                    }

                    if (n13 == 0)
                    {
                        a[13] = 0;
                    }
                    else
                    {
                        a[13] = 1;
                    }

                    if (n14 == 0)
                    {
                        a[14] = 0;
                    }
                    else
                    {
                        a[14] = 1;
                    }
                    if (n15 == 0)
                    {
                        a[15] = 0;
                    }
                    else
                    {
                        a[15] = 1;
                    }

                    if (n16 == 0)
                    {
                        a[16] = 0;
                    }
                    else
                    {
                        a[16] = 1;
                    }

                    if (n17 == 0)
                    {
                        a[17] = 0;
                    }
                    else
                    {
                        a[17] = 1;
                    }

                    if (n18 == 0)
                    {
                        a[18] = 0;
                    }
                    else
                    {
                        a[18] = 1;
                    }

                    if (n19 == 0)
                    {
                        a[19] = 0;
                    }
                    else
                    {
                        a[19] = 1;
                    }

                    if (n20 == 0)
                    {
                        a[20] = 0;
                    }
                    else
                    {
                        a[20] = 1;
                    }

                    for (int i = 1; i <= 20; i++)
                    {
                        student += a[i];
                    }

                    total = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10 + n11 + n12 + n13 + n14 + n15 + n16 + n17 + n18 + n19 + n20;

                    average = total/student;

                    StudentNumber.Text = Convert.ToString(student);
                    AverageScore.Text = Convert.ToString(average);
                    student = 0;
                    average = 0;
                }
            }
        }

      
        

        
        public TextBox studentNumber
        {
            get
            {
                return StudentNumber;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StudentNumber.Text == "")
            {
                MessageBox.Show("No Data Available");
            }
            else
            {
                Form2 achildform = new Form2();
                achildform.totalstudents = StudentNumber.Text;
                achildform.num1 =textBox1.Text;
                achildform.num2 = textBox2.Text;
                achildform.num3 = textBox3.Text;
                achildform.num4 = textBox4.Text;
                achildform.num5 = textBox5.Text;
                achildform.num6 = textBox6.Text;
                achildform.num7 = textBox7.Text;
                achildform.num8 = textBox8.Text;
                achildform.num9 = textBox9.Text;
                achildform.num10 = textBox10.Text;
                achildform.num11 = textBox11.Text;
                achildform.num12 = textBox12.Text;
                achildform.num13 = textBox13.Text;
                achildform.num14 = textBox14.Text; 
                achildform.num15 = textBox15.Text;
                achildform.num16 = textBox16.Text;
                achildform.num17 = textBox17.Text;
                achildform.num18 = textBox18.Text;
                achildform.num19 = textBox19.Text;
                achildform.num20 = textBox20.Text;
                
                achildform.Text = "Histogram";
                achildform.Show();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
            
        }
        
            
    }
}
