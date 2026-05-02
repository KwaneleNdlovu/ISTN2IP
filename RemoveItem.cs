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
        public RemoveItem(List<ListViewItem> items, Form1 form)
        {
            InitializeComponent();
            mainform = form;
            LoadData(items);
            namelabel.Text = "ITEM NOT SELECTED";
            priceLabel.Text = "ITEM NOT SELECTED";
            totalLabel.Text = "ITEM NOT SELECTED";

            imagePictureBox.Image = Properties.Resources.loading;
            imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox2.Image = Properties.Resources.guidebook;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom; 

            

            Image resized = new Bitmap(Properties.Resources.trash, new Size(20, 20)); // will then retrieve the image from the resource folder in the project folder

            button1.Image = resized;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.ImageAlign = ContentAlignment.MiddleRight;

            Image resizedBack = new Bitmap(Properties.Resources.arrow, new Size(20, 20)); // will then retrieve the image from the resource folder in the project folder

            backbtn.Image = resizedBack;
            backbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            backbtn.ImageAlign = ContentAlignment.MiddleRight;

            // ⭐ THIS IS THE MISSING PART
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
                namelabel.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                theValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string first = "Nike Air Max 90";
                string second = "Jordan Women's 1 Mid";
                string third = "Jordan Men's 1 Mid";
                string forth = "Adidas Samba";
                string fifth = "Adidas Adilette 22";
                string sixth = "";

                if (string.Equals(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), first, StringComparison.OrdinalIgnoreCase))
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

                priceLabel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                double price = double.Parse(priceLabel.Text.Replace("R", "").Replace(",", ""));

                int quantity = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Replace("R", "").Replace(",", ""));
                quantityTextBox.Text = quantity.ToString();

                double finalValue = price * quantity;
                totalLabel.Text = "R" + finalValue.ToString("N2");
            }
        }

        private void LoadData(List<ListViewItem> items)
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

        private void setToDefault()
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

        private void button1_Click(object sender, EventArgs e)
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
           
            this.Hide();
            
        }

        
    }
}
