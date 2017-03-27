using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_238_Lab_7
{
    public partial class Form1 : Form
    {
        private ObjectSource source;
        public Form1()
        {
            InitializeComponent();
            source = new ObjectSource();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categID = (int)comboBox1.SelectedValue;
            IList<Product> currentList = source.GetProducts(categID);
            listBox1.DataSource = currentList;
            listBox1.DisplayMember = "ProductName";

            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            checkBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", currentList, "ProductName");
            textBox2.DataBindings.Add("Text", currentList, "UnitPrice");
            checkBox1.DataBindings.Add("Checked", currentList, "OnSale");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "CategoryID";
            comboBox1.DataSource = source.GetCategory();
            comboBox1.DisplayMember = "CategoryName";
        }


    }
}
