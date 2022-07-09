using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Billing b = new Billing();
            var items = b.loadAllItems();
            listBox1.DataSource= items;
            listBox1.DisplayMember = "ItemName";
            listBox1.ValueMember = "ItemName";
        }
        List<Test.Item> SelectedItems = new List<Test.Item>();
        private void button1_Click(object sender, EventArgs e)
        {
            Billing b = new Billing();
             var SelectedItem = b.loadAllItems().Where(x=>x.ItemName==listBox1.SelectedValue).First();
            SelectedItems.Add(SelectedItem);

            listBox2.DataSource = null;
            listBox2.DataSource = SelectedItems;
            listBox2.DisplayMember = "ItemName";
            listBox2.ValueMember = "ItemName";
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Billing b = new Billing();
           label1.Text= b.calculatePriceforselecteditem(SelectedItems).ToString();
        }
    }
}
