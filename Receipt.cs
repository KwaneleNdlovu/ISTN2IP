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
    public partial class Receipt : Form
    {
        public string data = "";
        public double change = 0;
        public double input_amount = 0;
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            data += "\nInput Amount:".PadRight(45) + "R" +input_amount +
                "\nChange:".PadRight(45) + "R" +change +
                "\n_________________________________________________________";

            receipt_data.Text = data;
        }
    }
}
