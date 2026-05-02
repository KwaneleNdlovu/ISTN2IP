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
    
    public partial class Payment : Form
    {

        public double total;
        public string receiptData = "";
        double amount_due_input;
        double change;
        public Payment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void process_payment_btn_Click(object sender, EventArgs e)
        {
            if(amountDueInput.Text != "")
            {
                amount_due_input = double.Parse(amountDueInput.Text);

                if(amount_due_input > total)
                {
                    receipt_btn.Enabled = true;
                    change = amount_due_input - total;
                    change_lbl.Text = "R" + change.ToString();
                    MessageBox.Show("Payment Successful!");
                } else
                {
                    MessageBox.Show("Payament unsuccessful due to insufficient funds!");
                }
            } else
            {
                MessageBox.Show("Input amount!");
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            amount_due_lbl.Text = "R" + total.ToString();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void receipt_btn_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.data = receiptData;
            receipt.change = change;
            receipt.input_amount = amount_due_input; 
            receipt.ShowDialog();
        }
    }
}
