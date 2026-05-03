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
    public partial class RemoveItem : Form
    {
        private Form1 mainform;
        string theValue;
        public RemoveItem(List<ListViewItem> items, Form1 form) // when i create a new window, i have to get the data from the previous window so that i can  use that data for this window
        {
            InitializeComponent();
            mainform = form;
            LoadData(items); // I have to load the data i got from the previus window
            namelabel.Text = "ITEM NOT SELECTED";
            priceLabel.Text = "ITEM NOT SELECTED";
            totalLabel.Text = "ITEM NOT SELECTED";

            imagePictureBox.Image = Properties.Resources.loading;
            imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox2.Image = Properties.Resources.guidebook;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom; // so the image can fit neatly in the picturebox

            

            Image resized = new Bitmap(Properties.Resources.trash, new Size(20, 20)); // will then retrieve the image from the resource folder in the project folder, and resize it neatly to fit in the buttons

            button1.Image = resized;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.ImageAlign = ContentAlignment.MiddleRight;

            Image resizedBack = new Bitmap(Properties.Resources.arrow, new Size(20, 20)); // will then retrieve the image from the resource folder in the project folder

            backbtn.Image = resizedBack;
            backbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            backbtn.ImageAlign = ContentAlignment.MiddleRight;

            
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // this method will allow me to specifically select the row, one at a time
        {
            // Only act on checkbox column (column 0)
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[0].Value = false;
                }

                dataGridView1.Rows[e.RowIndex].Cells[0].Value = true;

                // we then have to update labels when selecting item
                namelabel.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); // retrive the name of the sneaker
                theValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); 
                string first = "Nike Air Max 90";
                string second = "Jordan Women's 1 Mid";
                string third = "Jordan Men's 1 Mid";
                string forth = "Adidas Samba";
                string fifth = "Adidas Adilette 22";
                
                if (string.Equals(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), first, StringComparison.OrdinalIgnoreCase)) // I want to compare the strings so that i can allocate the correct image in the picture box //
                {
                    imagePictureBox.Image = Properties.Resources.original;
                    imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                } else if (string.Equals(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), second, StringComparison.OrdinalIgnoreCase))
                {
                    imagePictureBox.Image = Properties.Resources.Jordans_Women_s_1_Mid;
                    imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                }
                else if (string.Equals(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), third, StringComparison.OrdinalIgnoreCase))
                {
                    imagePictureBox.Image = Properties.Resources.Jordan1_male_;
                    imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                }
                else if (string.Equals(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), forth, StringComparison.OrdinalIgnoreCase))
                {
                    imagePictureBox.Image = Properties.Resources.adidas_samba;
                    imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                }
                else if (string.Equals(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), fifth, StringComparison.OrdinalIgnoreCase))
                {
                    imagePictureBox.Image = Properties.Resources.adidas_adilette;
                    imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                }

                priceLabel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();// retrive the price of the sneaker

                double price = double.Parse(priceLabel.Text.Replace("R", "").Replace(",", ""));

                int quantity = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Replace("R", "").Replace(",", ""));// I have to remove the strings in the number so that i can convert into a double
                quantityTextBox.Text = quantity.ToString();

                double finalValue = price * quantity;
                totalLabel.Text = "R" + finalValue.ToString("N2");
            }
        }

        private void LoadData(List<ListViewItem> items) // This method will then allow me to add all of the elements into the datagridview 
        {
            foreach (ListViewItem item in items)
            {
                dataGridView1.Rows.Add(
                    false,
                    item.SubItems[0].Text,
                    item.SubItems[2].Text,
                    item.SubItems[1].Text
                );
            }
        }

        private void setToDefault() // so, after removing the product, i have to set these products back to their default images and labels
        {
            namelabel.Text = "ITEM NOT SELECTED";
            priceLabel.Text = "ITEM NOT SELECTED";
            totalLabel.Text = "ITEM NOT SELECTED";
            quantityTextBox.Clear();

            imagePictureBox.Image = Properties.Resources.loading;
            imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // this method will allow me to delete what  i had selected in the datagridview, then i will pass this method above
        {
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                bool isChecked = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);

                if (isChecked)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    setToDefault();
                    mainform.RemoveItem(theValue);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Hide(); // when i click back, i show should leave this window and continue on the other window
            
        }

        
    }
}
