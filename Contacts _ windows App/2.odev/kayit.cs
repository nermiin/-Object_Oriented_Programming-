using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2.odev
{
    public partial class kayit : Form
    {      
        public kayit()
        {
            InitializeComponent();
        }
       
        private void kayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            text_isim.ForeColor = Color.Blue;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            text_isim.ForeColor=Color.Red;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "veriler.txt";
            if (!File.Exists(path))
            {
                File.CreateText(path);
            }
            using (StreamWriter dosyaYaz = File.AppendText(path))
            {
                try
                {
                    if (kr1.Checked)
                        dosyaYaz.Write("k");
                    else if (ma1.Checked)
                        dosyaYaz.Write("m");
                    else if (ye1.Checked)
                        dosyaYaz.Write("y");
                    ////////////////////////////////////////////
                    if (kr2.Checked)
                        dosyaYaz.Write("k");
                    else if (ma2.Checked)
                        dosyaYaz.Write("m");
                    else if (ye2.Checked)
                        dosyaYaz.Write("y");
                    ////////////////////////////////////////////
                    if (kr3.Checked)
                        dosyaYaz.Write("k");
                    else if (ma3.Checked)
                        dosyaYaz.Write("m");
                    else if (ye3.Checked)
                        dosyaYaz.Write("y");
                    ////////////////////////////////////////////////////////////////////////////////////////
                    dosyaYaz.Write(" " + text_isim.Text + " " + text_soyad.Text + " " + text_numara.Text+" "+Environment.NewLine);
                    dosyaYaz.Close();
                    MessageBox.Show("Dosyanız başarıyla kaydedildi..");

                }
                catch(Exception )
                {
                    if (text_isim.Text.Length < 3)
                        MessageBox.Show("isminiz 3 harftan kisa olamaz ..");
                    else if (text_isim.Text.Length > 10)
                        MessageBox.Show("isminiz 10 harftan fazla olamaz ..");
                    else if (text_isim.Text.Length == 0)
                        MessageBox.Show("lutfen isminizi yaziniz ..");
                    /////////////////////////////////////////////////////////////////////////////////////////
                    else if (text_soyad.Text.Length < 2)
                        MessageBox.Show("soyadiniz 2 harftan kisa olamaz ..");
                    else if (text_soyad.Text.Length > 15)
                        MessageBox.Show("soyadiniz 15 harftan fazla olamaz ..");
                    else if (text_soyad.Text.Length == 0)
                        MessageBox.Show("lutfen soyadinizi yaziniz ..");
                    /////////////////////////////////////////////////////////////////////////////////////////
                    else if (text_numara.Text.Length == 0)
                        MessageBox.Show("numaranizi girin lutfen..");
                    else 
                    MessageBox.Show("butun bilgilar yazin lutfen,ve renk secin");
                }
                finally
                {
                    text_isim.Clear();
                    text_soyad.Clear();
                    text_numara.Clear();
                }
                
            }
        }
        private void kr2_CheckedChanged(object sender, EventArgs e)
        {
            text_soyad.ForeColor = Color.Red;
        }

        private void kr3_CheckedChanged(object sender, EventArgs e)
        {
            text_numara.ForeColor = Color.Red;
        }

        private void ma2_CheckedChanged(object sender, EventArgs e)
        {
            text_soyad.ForeColor = Color.Blue;
        }

        private void ma3_CheckedChanged(object sender, EventArgs e)
        {
            text_numara.ForeColor = Color.Blue;
        }

        private void ye1_CheckedChanged(object sender, EventArgs e)
        {
            text_isim.ForeColor = Color.Green;
        }

        private void ye2_CheckedChanged(object sender, EventArgs e)
        {
            text_soyad.ForeColor = Color.Green;
        }

        private void ye3_CheckedChanged(object sender, EventArgs e)
        {
            text_numara.ForeColor = Color.Green;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            Hide();
            f.ShowDialog();
        }
    }
}