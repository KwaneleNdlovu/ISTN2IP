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
        public RemoveItem(List<ListViewItem> items)
        {
            InitializeComponent();
            LoadData(items);
            namelabel.Text = "ITEM NOT SELECTED";
            priceLabel.Text = "ITEM NOT SELECTED";
            totalLabel.Text = "ITEM NOT SELECTED";

            pictureBox1.Image = Properties.Resources.loading;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox2.Image = Properties.Resources.guidebook;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom; 

            

            Image resized = new Bitmap(Properties.Resources.trash, new Size(20, 20)); // will then retrieve the image from the resource folder in the project folder

            button1.Image = resized;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void LoadData(List<ListViewItem> items)
        {
            foreach (ListViewItem item in items)
            {
                dataGridView1.Rows.Add(
                    false,
                    item.SubItems[0].Text,
                    item.SubItems[1].Text,
                    item.SubItems[2].Text
                );
            }
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
    }
}
