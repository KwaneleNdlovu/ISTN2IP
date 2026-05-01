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

        public Form1()
        {
            InitializeComponent();
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

        }
    }
}
