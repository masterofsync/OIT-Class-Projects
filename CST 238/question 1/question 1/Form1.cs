using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace question_1
{
    public partial class child : Form
    {

        bool nonNumberEntered;
        int ages;

        public child()
        {
            InitializeComponent();
           
        }

        private void Agebox_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            
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

            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }

        }

        private void Agebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void hidePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void loadPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Photo";
            dlg.Filter = "jpg files (*.jpg)|*.jpg" + "|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(dlg.OpenFile());
                pictureBox1.Load(dlg.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                if (Agebox.Text != "")
                {
                    ages = Convert.ToInt32(Agebox.Text);
                }


                if (ages < 2 && ages > 0)
                {
                    
                    Datastatus.Text = NameData.Text + " is a Baby";
                }

                if (ages < 5 && ages > 3)
                {
                    Datastatus.Text = NameData.Text + " is a Toddler";
                }

                if (ages < 9 && ages > 6)
                {
                    Datastatus.Text = NameData.Text + " is a Kid";
                }

                if (ages < 12 && ages > 10)
                {
                    Datastatus.Text = NameData.Text + " is a Pre-Teen";
                }

                if (ages < 17 && ages > 13)
                {
                    Datastatus.Text = NameData.Text + " is a Teen";
                }

                if (ages < 20 && ages > 18)
                {
                    Datastatus.Text = NameData.Text + " is a Young adult";
                }

                if (ages < 39 && ages > 21)
                {
                    Datastatus.Text = NameData.Text + " is an Adult";
                }

                if (ages < 59 && ages > 40)
                {
                    Datastatus.Text = NameData.Text + " is a Middle-Aged";
                }

                if (ages > 60)
                {
                    Datastatus.Text = NameData.Text + " is a Senior";
                }
                
                 
            }


        }

        private void NameData_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Text = NameData.Text;
            }
        }




    }
}
