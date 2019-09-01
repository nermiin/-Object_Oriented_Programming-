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
    public partial class liste : Form
    {
       
        public liste()
        {
            InitializeComponent();
        }
        private void liste_Load(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "veriler.txt";
            using (StreamReader dosyaOku = new StreamReader(path))
            {
                try
                {
                    string text = File.ReadAllText(path);
                    string[] satirlar = text.Split('\n');
                    string[] kelimeler = text.Split(' ');
                    richTextBox1.AppendText(text);
                    var lineCount = richTextBox1.Lines.Count();
                    richTextBox1.Clear();
                    bool A= true;
                    for (int i = 0; i < lineCount - 1; i++)
                    {
                        if ((i+1)%2==0)
                        { A = false; }
                        else
                        { A = true; }
                    if (satirlar[i].Substring(0, 1) == "k")
                            richTextBox1.AppendText(kelimeler[1 + 4 * i] + " ", Color.Red, A);
                        else if (satirlar[i].Substring(0, 1) == "m")
                            richTextBox1.AppendText(kelimeler[1 + 4 * i] + " ", Color.Blue, A);
                        else if (satirlar[i].Substring(0, 1) == "y")
                            richTextBox1.AppendText(kelimeler[1 + 4 * i] + " ", Color.Green, A);
                        if (satirlar[i].Substring(1, 1) == "k")
                            richTextBox1.AppendText(kelimeler[2 + 4 * i] + " ", Color.Red,A);
                        else if (satirlar[i].Substring(1, 1) == "m")
                            richTextBox1.AppendText(kelimeler[2 + 4 * i] + " ", Color.Blue,A);
                        else if (satirlar[i].Substring(1, 1) == "y")
                            richTextBox1.AppendText(kelimeler[2 + 4 * i] + " ", Color.Green,A);
                        if (satirlar[i].Substring(2, 1) == "k")
                            richTextBox1.AppendText(kelimeler[3 + 4 * i] + " ", Color.Red,A);
                        else if (satirlar[i].Substring(2, 1) == "m")
                            richTextBox1.AppendText(kelimeler[3 + 4 * i] + " ", Color.Blue,A);
                        else if (satirlar[i].Substring(2, 1) == "y")
                            richTextBox1.AppendText(kelimeler[3 + 4 * i] + " ", Color.Green,A);
                        richTextBox1.AppendText("\n");
                    }
                }catch
                { MessageBox.Show("kayitta bir sorun var!"); }
            }
        }

        private void liste_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
        public static class RichTextBoxExtensions
        {
            public static void AppendText(this RichTextBox box, string text, Color color,bool B)
            {
            if (B == true)
            {
                box.SelectionFont = new Font(box.Font, FontStyle.Bold);
            }
            else
            {
                box.SelectionFont = new Font(box.Font, FontStyle.Regular);

            }
            box.SelectionStart = box.TextLength;
                box.SelectionLength = 0;

                box.SelectionColor = color;
                box.AppendText(text);
                box.SelectionColor = box.ForeColor;
            }
        }
}