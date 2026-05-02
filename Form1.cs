using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes
{
    public partial class Form1 : Form
    {
        double airmaxprice = 2999;
        double womenJ1 = 2699;
        double menJ1 = 2999;
        double menJ1_2 = 3199;
        double adidas_samba = 1999;
        double adilette = 1199;

        int airmaxprice_qty = 0;
        int womenJ1_qty = 0;
        int menJ1_qty = 0;
        int menJ1_2_qty = 0;
        int adidas_samba_qty = 0;
        int adilette_qty = 0;

        int quantityTracker = 0;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            int totalWidth = listView1.Width;

            listView1.Columns.Add("Sneaker Name", (int)(totalWidth * 0.3)); // 40%
            listView1.Columns.Add("Price", (int)(totalWidth * 0.2));        // 20%
            listView1.Columns.Add("Quantity", (int)(totalWidth * 0.2));     // 20%
            listView1.Columns.Add("Total", (int)(totalWidth * 0.3));
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void airmax_Click(object sender, EventArgs e)
        {
            sName.Text = "Nike Air Max 90";
            sPrice.Text = "R2,999.00";

            airmaxprice_qty++;
            quantity.Text = airmaxprice_qty.ToString();
        }

        private void femaleJ1_Click(object sender, EventArgs e)
        {
            sName.Text = "Jordan Women's 1 Mid";
            sPrice.Text = "R2,699.00";

            womenJ1_qty++;
            quantity.Text = womenJ1_qty.ToString();
        }

        private void maleJ1_Click(object sender, EventArgs e)
        {
            sName.Text = "Jordan Men's 1 Mid";
            sPrice.Text = "R2,999.00";
        }

        private void manJ1_Click(object sender, EventArgs e)
        {
            sName.Text = "Jordan Men's 1 Mid";
            sPrice.Text = "R3,199.00";
        }

        private void samba_Click(object sender, EventArgs e)
        {
            sName.Text = "Adidas Samba";
            sPrice.Text = "R1,999.00";
        }

        private void slides_Click(object sender, EventArgs e)
        {
            sName.Text = "Adidas Adilette 22";
            sPrice.Text = "R1,199.00";
        }

        private void items_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            quantityTracker += 1;
            quantity.Text = quantityTracker.ToString();
        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void addToCart_Click(object sender, EventArgs e)
        {

            ListViewItem item = new ListViewItem("Nike Shoes");
            item.SubItems.Add("R999");

            listView1.Items.Add(item);
        }

        private void addToCart_Click_1(object sender, EventArgs e)
        {
            //string name = sName.Text;
            //string price = sPrice.Text;

            //ListViewItem item = new ListViewItem(name);
            //item.SubItems.Add(price);

            //listView1.Items.Add(item);
            /////////////////
            ///

            string name = sName.Text;

            
            double price = Convert.ToDouble(sPrice.Text.Replace("R", "").Replace(",", "")); // This will then remove the "R" and the comman so that we can multiply the numbers

            int qty = int.Parse(quantity.Text);

            double total = price * qty;

            // Create row
            ListViewItem item = new ListViewItem(name); // the first column
            item.SubItems.Add("R" + price.ToString("N2"));// the second column
            item.SubItems.Add(qty.ToString());           // the third column  
            item.SubItems.Add("R" + total.ToString("N2")); // the forth column

            listView1.Items.Add(item);


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<ListViewItem> itemsToSend = new List<ListViewItem>();

            foreach (ListViewItem item in listView1.Items)
            {
                itemsToSend.Add(item);
            }

            // Open Form2 and pass data
            RemoveItem f2 = new RemoveItem(itemsToSend);
            f2.Show();
        }
    }
}
