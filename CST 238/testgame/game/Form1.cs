using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        private int x,y,u,v,a,b;
        private int deltax, deltay;

        public Form1()
        {
            InitializeComponent();
            x = 100;
            y = 290;
            u = 120;
            v = 279;
            a = 300;
            b = 100;

            deltax = 5;
            deltay = 5;
            DoubleBuffered = true; 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(x, y, 50, 10);
            Bitmap image = Properties.Resources.base1;
            image.MakeTransparent(Color.White);
            g.DrawImage(image, rec);

            Rectangle rect = new Rectangle(u, v, 10, 10);
            Bitmap image1 = Properties.Resources.Basketball;
            image.MakeTransparent(Color.Black);
            g.DrawImage(image1, rect);

            Rectangle req = new Rectangle(a, b, 50, 50);
            Bitmap image2 = Properties.Resources.board;
            image2.MakeTransparent(Color.White);
            g.DrawImage(image2, req);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Start();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                timer1.Stop();
            }


            if (timer1.Enabled == false)
            {
                if (e.KeyCode == Keys.Right)
                {
                    if (u == (x + 20) && v == 279)
                    {
                        if (x < 400)
                        {
                            x += 5;
                            u = x + 20;
                        }
                    }

                }
                else if (e.KeyCode == Keys.Left)
                {
                    if(u == (x+20) && v== 279)
                    {
                        if (x > 5)
                        {
                            x -= 5;
                            u = x + 20;
                        }
                    }

                }

                this.Invalidate();
            }



            if (e.KeyCode == Keys.Left)
            {
                if (timer1.Enabled == true)
                {
                   
                    if (x > 5)
                    {
                       
                        x -= 5;
                        
                    }
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (timer1.Enabled == true)
                {
                   
                        
                    if (x < 400)
                    {

                        x += 5;
                        
                    }
                }
                this.Invalidate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (u + deltax > 445 || u < 10)
                deltax = -deltax;
            if (((v + deltay) > 280 && (u + deltax > (x - 4)) && (u + deltax < (x + 54))) || v < 0 )
                deltay = -deltay;
            u += deltax;
            v += deltay;

            if(v>290)
            {
                timer1.Stop();
                MessageBox.Show("Game Over");
                v = 279;
                u = x+20;
            }


            this.Invalidate();


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lab.Text = e.X + ", " + e.Y;
        }

       


    }


}
