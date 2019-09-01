using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> color_img;
        Image<Gray, byte> Gray_img;
        Image<Gray, byte> binary_img;

        public Form1()
        {
            InitializeComponent();
        }
        // ************************* Open tusu basinca ******************************************************
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_img = new Image<Bgr, byte>(islem.getFileName());
            color_img_box.Image = color_img;
        }
        // ************************* Exit tusu basinca ******************************************************
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are u sure u want to close?","System message",MessageBoxButtons.YesNo)==DialogResult.Yes)
            this.Close();
        }
        // ************************* BGR-GRAY ****************************************************************
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (color_img == null)
            {
                MessageBox.Show("Please select an image");
                return;
            }
            Gray_img = islem.GriGetir(color_img);
            grey_img_box.Image = Gray_img;
        }
        // ************************* GRAY-Histogram **********************************************************
        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Gray_img==null)
            {
                MessageBox.Show("First click the gray color,please");
                return;
            }

            Mat m = islem.HistogramGetir(Gray_img);
            histogramBox.ClearHistogram();
            histogramBox.AddHistogram("Gri Histogram", Color.Gray, m, 256, new float[] { 0.0f, 256.0f });
            histogramBox.Refresh();
        }
        // ************************* GRAY-Binary ****************************************************************
        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Gray_img == null)
            {
                MessageBox.Show("First click the gray color,please");
                return;
            }
            binary_img = islem.BinaryGetir(Gray_img);
           binary_img_box.Image = binary_img;
        }

        private void color_img_box_Click(object sender, EventArgs e)
        {
            color_img = new Image<Bgr, byte>(islem.getFileName());
            color_img_box.Image = color_img;
        }

        private void color_img_box_MouseHover(object sender, EventArgs e)
        {
            
        }
        // ************************** The End :) *************************************************************
    }
}
