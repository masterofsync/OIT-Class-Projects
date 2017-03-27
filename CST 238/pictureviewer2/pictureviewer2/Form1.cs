using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureviewer2
{
    public partial class Form1 : Form
    {
        private Image[] myPictures;
        private int currentIndex;
        private int maxNumberofPictures;
        private string[] caption;

        public Form1()
        {
            InitializeComponent();
            myPictures = new Image[3];
            caption = new string[3];

            myPictures[0] = Properties.Resources.scenery1;
            myPictures[1] = Properties.Resources.scenery2;
            myPictures[2] = Properties.Resources.scenery3;

            caption[0] = "Koala";
            caption[1] = "Light House";
            caption[2] = "Penguins";

            currentIndex = 0;
            maxNumberofPictures = 5;
        }

        

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;*/
        }

        
    }
}
