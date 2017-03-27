using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int textlength = 0;
            string usertext = showMessageBox.Text;
            string reverse = "";

            for (textlength = usertext.Length-1; textlength >= 0; textlength--)
            {
                reverse += usertext[textlength];
            }

            reverselabel.Text = reverse;

            
        }
    }
}
