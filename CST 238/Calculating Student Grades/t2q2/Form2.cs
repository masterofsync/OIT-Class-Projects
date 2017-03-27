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
    public partial class Form2 : Form
    {
       
        private string name;
        private string []num;
        private float []nums;
        int a, b, c, d, t, f, q, h, i, j;
        int x;

        public int size(int comp)
        {
            return ((25)*comp);
        }

        public string totalstudents
        {
            get { return name; }
            set { name = value; }
            
            
        }
        
       

        public Form2()
        {
            InitializeComponent();
            num = new string[21];
            nums = new float[21];
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            t = 0;
            f = 0;
            q = 0; 
            h = 0;
            i = 0;
            j = 0;
            x = 0; 
           
        }

        public string num1
        {
            get {return num[1];}
            set { num[1] = value; }

        }

        public string num2
        {
            get { return num[2]; }
            set { num[2] = value; }

        }
        public string num3
        {
            get { return num[3]; }
            set { num[3] = value; }

        }
        public string num4
        {
            get { return num[4]; }
            set { num[4] = value; }

        }
        public string num5
        {
            get { return num[5]; }
            set { num[5] = value; }

        }
        public string num6
        {
            get { return num[6]; }
            set { num[6] = value; }

        }
        public string num7
        {
            get { return num[7]; }
            set { num[7] = value; }

        }

        public string num8
        {
            get { return num[8]; }
            set { num[8] = value; }

        }

        public string num9
        {
            get { return num[9]; }
            set { num[9] = value; }

        }

        public string num10
        {
            get { return num[10]; }
            set { num[10] = value; }

        }

        public string num11
        {
            get { return num[11]; }
            set { num[11] = value; }

        }

        public string num12
        {
            get { return num[12]; }
            set { num[12] = value; }

        }

        public string num13
        {
            get { return num[13]; }
            set { num[13] = value; }

        }

        public string num14
        {
            get { return num[14]; }
            set { num[14] = value; }

        }

        public string num15
        {
            get { return num[15]; }
            set { num[15] = value; }

        }

        public string num16
        {
            get { return num[16]; }
            set { num[16] = value; }

        }

        public string num17
        {
            get { return num[17]; }
            set { num[17] = value; }

        }

        public string num18
        {
            get { return num[18]; }
            set { num[18] = value; }

        }

        public string num19
        {
            get { return num[19]; }
            set { num[19] = value; }

        }

        public string num20
        {
            get { return num[20]; }
            set { num[20] = value; }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            x = size(a);   
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Purple, 12);
            Rectangle rect = new Rectangle(0, 0, x, 40);
            e.Graphics.DrawRectangle(pen, rect);
            Brush brush = new SolidBrush(Color.Purple);
            e.Graphics.FillRectangle(brush, rect);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            studentnumbers.Text = name;
            
            nums[1] = Convert.ToSingle(num1);
            nums[2] =Convert.ToSingle(num2);
            nums[3] =Convert.ToSingle(num3);
            nums[4] =Convert.ToSingle(num4);
            nums[5] =Convert.ToSingle(num5);
            nums[6] =Convert.ToSingle(num6);
            nums[7] = Convert.ToSingle(num7);
            nums[8] =Convert.ToSingle(num8);
            nums[9] =Convert.ToSingle(num9);
            nums[10] =Convert.ToSingle(num10);
            nums[11] =Convert.ToSingle(num11);
            nums[12] =Convert.ToSingle(num12);
            nums[13] = Convert.ToSingle(num13);
            nums[14] =Convert.ToSingle(num14);
            nums[15] =Convert.ToSingle(num15);
            nums[16] =Convert.ToSingle(num16);
            nums[17] =Convert.ToSingle(num17);
            nums[18] =Convert.ToSingle(num18);
            nums[19] = Convert.ToSingle(num19);
            nums[20] =Convert.ToSingle(num20);

            for (int m = 1; m <= 20; m++)
            {
                if (nums[m] == 100)
                    a += 1;
                else if (nums[m] < 100 && nums[m] >= 90)
                    b += 1;
                else if (nums[m] < 90 && nums[m] >= 80)
                    c += 1;
                else if (nums[m] < 80 && nums[m] >= 70)
                    d += 1;
                else if (nums[m] < 70 && nums[m] >= 60)
                    t += 1;
                else if (nums[m] < 60 && nums[m] >= 50)
                    f += 1;
                else if (nums[m] < 50 && nums[m] >= 40)
                    q += 1;
                else if (nums[m] < 40 && nums[m] >= 30)
                    h += 1;
                else if (nums[m] < 30 && nums[m] >= 20)
                    i += 1;
                else if (nums[m] < 20 && nums[m] >= 1)
                    j += 1;
            }
            
            
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            x = size(b);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Purple, 12);
            Rectangle rect = new Rectangle(0, 0, x, 200);
            e.Graphics.DrawRectangle(pen, rect);
            Brush brush = new SolidBrush(Color.Purple);
            e.Graphics.FillRectangle(brush, rect);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            x = size(c);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Purple, 12);
            Rectangle rect = new Rectangle(0, 0, x, 200);
            e.Graphics.DrawRectangle(pen, rect);
            Brush brush = new SolidBrush(Color.Purple);
            e.Graphics.FillRectangle(brush, rect);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            x = size(d);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Purple, 12);
            Rectangle rect = new Rectangle(0, 0, x, 200);
            e.Graphics.DrawRectangle(pen, rect);
            Brush brush = new SolidBrush(Color.Purple);
            e.Graphics.FillRectangle(brush, rect);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            x = size(t);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Purple, 12);
            Rectangle rect = new Rectangle(0, 0, x, 200);
            e.Graphics.DrawRectangle(pen, rect);
            Brush brush = new SolidBrush(Color.Purple);
            e.Graphics.FillRectangle(brush, rect);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            x = size(f);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Purple, 12);
            Rectangle rect = new Rectangle(0, 0, x, 200);
            e.Graphics.DrawRectangle(pen, rect);
            Brush brush = new SolidBrush(Color.Purple);
            e.Graphics.FillRectangle(brush, rect);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            x = size(q);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Purple, 12);
            Rectangle rect = new Rectangle(0, 0, x, 200);
            e.Graphics.DrawRectangle(pen, rect);
            Brush brush = new SolidBrush(Color.Purple);
            e.Graphics.FillRectangle(brush, rect);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            x = size(h);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Purple, 12);
            Rectangle rect = new Rectangle(0, 0, x, 200);
            e.Graphics.DrawRectangle(pen, rect);
            Brush brush = new SolidBrush(Color.Purple);
            e.Graphics.FillRectangle(brush, rect);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            x = size(i);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Purple, 12);
            Rectangle rect = new Rectangle(0, 0, x, 200);
            e.Graphics.DrawRectangle(pen, rect);
            Brush brush = new SolidBrush(Color.Purple);
            e.Graphics.FillRectangle(brush, rect);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            x = size(j);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Purple, 12);
            Rectangle rect = new Rectangle(0, 0, x, 200);
            e.Graphics.DrawRectangle(pen, rect);
            Brush brush = new SolidBrush(Color.Purple);
            e.Graphics.FillRectangle(brush, rect);
        }
    }
}
