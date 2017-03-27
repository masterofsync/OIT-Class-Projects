using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t2q1
{
    public partial class Form1 : Form
    {
        private int x,deltax;
        private int y,deltay;
        private int z, deltaz;
        
        Bitmap pic1;
        Bitmap pic2;
        Bitmap pic3;
        

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            x = 300;
            y = 200;
            z = 400;

            deltax = 2;
            deltay = 4;
            deltaz = 3;
             pic1= Properties.Resources.fish10;
             pic2 = Properties.Resources.fish2;
             pic3 = Properties.Resources.fisha;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap picture = Properties.Resources.treasures;
            picture.MakeTransparent(Color.White);
            g.DrawImage(picture, 280, 285, 100, 100);

            if (deltax< 0)
            {
                pic1 = Properties.Resources.fish10;
            }
            if (deltax>0)
            {
                pic1 = Properties.Resources.fish1right2;
            }
            pic1.MakeTransparent(Color.White);
            g.DrawImage(pic1, x, 200, 50, 50);

            if (deltay < 0)
            {
                pic2 = Properties.Resources.fish2;
            }
            if (deltay > 0)
            {
                pic2 = Properties.Resources.fish2right;
            }
            pic2.MakeTransparent(Color.White);
            g.DrawImage(pic2, y, 20, 50, 50);

            if (deltaz < 0)
            {
                pic3 = Properties.Resources.fisha;
            }
            if (deltaz > 0)
            {
                pic3 = Properties.Resources.fisharight;
            }
            pic3.MakeTransparent(Color.White);
            g.DrawImage(pic3, z, 300, 50, 50);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();

            if (x + deltax > 445 || x < 300)
            {
                deltax = -deltax;
            }
                x += deltax;

            if (y + deltay > 500 || y < 150)
            {
                    deltay = -deltay;
            }
            y += deltay;

            if (z + deltaz > 500 || z < 10)
            {
                deltaz = -deltaz;
            }
            z += deltaz;
            
            this.Invalidate();
        
           
        }
    }
}
