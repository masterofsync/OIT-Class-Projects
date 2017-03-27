using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        private int counter;
       
        public Form1()
        {
            InitializeComponent();
            counter = 0;
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter++;
                       child achildform  = new child();
            achildform.Text = "This is window " + counter.ToString();
                achildform.Show();
            achildform.MdiParent = this;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                child achildform =(child)this.ActiveMdiChild;

                achildform.document.Undo();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child achildform = (child)this.ActiveMdiChild;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text File |*.rtf";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                achildform.document.LoadFile(dlg.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child achildform = (child)this.ActiveMdiChild;
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text File|*.rtf";
            dlg.AddExtension = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                achildform.document.SaveFile(dlg.FileName);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child achildform = (child)this.ActiveMdiChild;
            achildform.document.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child achildform = (child)this.ActiveMdiChild;
            achildform.document.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child achildform = (child)this.ActiveMdiChild;
            achildform.document.Paste();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            child achildform = (child)this.ActiveMdiChild;   
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                achildform.document.SelectionFont  = dlg.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child achildform = (child)this.ActiveMdiChild;
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                achildform.document.SelectionColor = dlg.Color;
            }
        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
