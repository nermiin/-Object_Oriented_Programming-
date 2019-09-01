using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proje
{
    public partial class Form1 : Form
    {
        Renkler GetRenkler = new Renkler();
        Shape GetShape = new Shape();
        /*Variables*/
        #region variables
        private int mouseStartX = 0;
        private int mouseStartY = 0;
        private int mouseCurrentX = 0;
        private int mouseCurrentY = 0;
        private int recSartPointX = 0;
        private int recSartPointY = 0;
        private int recSizeY = 0;
        private int recSizeX = 0;
        private bool mouseDown = false;
        private bool sec = false;
        private int shapeSelected = 0;
        int[] type = new int[100];
        Color[] Col = new Color[100];
        Rectangle[] rectangles = new Rectangle[100];
        Rectangle rectangle = new Rectangle(50,50,50,50);
        Point position = new Point();
        Point[] Pucgen = new Point[3];
        int i = 0;
        int j = 0;
        #endregion
        #region color
        
        #endregion
        public enum ShapeSelected { Square, Traingle,Circle, hexagon}
        public enum ColorSelected { Siyah,Beyaz,Yesil,Mor,Mavi,Kirmizi,Kahverengi,turuncu,Sari }
      

        public Form1()
        {
            InitializeComponent();
        }
        Pen SiyahKalem = new Pen(Color.Black);
        public Pen kalem = new Pen(Color.Blue);
        Pen GriKalem = new Pen(Color.LightGray);

        public void Rectangel()
        {
            rectangles[i].Height = recSizeY;
            rectangles[i].Width = recSizeX;
            rectangles[i].X = recSartPointX;
            rectangles[i].Y = recSartPointY;
            Col[i] = kalem.Color;
        }
        //public void Sec(bool sec)
        //{
        //    if(sec=true)
        //    {
        //        ControlPaint.DrawFocusRectangle(Graphics.FromHwnd(panel_Draw.Handle),R_black.ClientRectangle);
        //    }
        //}
        private void panel_Draw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel_Draw.CreateGraphics();
            int HucreSayisi = 200;
            int HucreBoyutu = 5;

            for (int y = 0; y < HucreSayisi; ++y)
            {
                g.DrawLine(GriKalem, 0, y * HucreBoyutu, HucreSayisi * HucreBoyutu, y * HucreBoyutu);
            }

            for (int x = 0; x < HucreSayisi; ++x)
            {
                g.DrawLine(GriKalem, x * HucreBoyutu, 0, x * HucreBoyutu, HucreSayisi * HucreBoyutu);
            }
            //switch(shapeSelected)
            //{
            //    case 1: Dortgen.BackColor = Color.DarkRed;break;
            //    case 2: Daire.BackColor = Color.DarkRed;break;
            //    case 3: Ucgen.BackColor = Color.DarkRed;break;
            //    case 4: Altigen.BackColor = Color.DarkRed;break;
            //}
        }
        private void panel_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                mouseStartX = e.X;
                mouseStartY = e.Y;
            }
          
        }
        private void panel_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = panel_Draw.CreateGraphics();
                Rectangel();
                switch(GetShape.Selected.GetHashCode())
                {
                    case 0:
                        type[i] = 1;
                        g.FillRectangle(new SolidBrush(kalem.Color), rectangles[i]);
                        i++;
                        break;
                    case 1:
                        type[i] = 2;
                        g.FillEllipse(new SolidBrush(kalem.Color), rectangles[i]);
                        i++;
                        break;
                    case 2:
                        Pucgen[0].X = recSartPointX;
                        Pucgen[0].Y = recSartPointY - recSizeX;
                        Pucgen[1].X = recSartPointX + 866 * (recSizeX) / 1000;
                        Pucgen[1].Y = recSartPointY + recSizeX;
                        Pucgen[2].X = recSartPointX - 866 * (recSizeX) / 1000;
                        Pucgen[2].Y = recSartPointY + recSizeX;
                        g.FillPolygon(new SolidBrush(kalem.Color), Pucgen);
                        break;
                }
            }
        }
        private void panel_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            //Displays the mouse position.
            textBox1.Text = Convert.ToString(mouseCurrentX);
            textBox2.Text = Convert.ToString(mouseCurrentY);
            if (mouseDown == true)
            {
                mouseCurrentX = e.X - mouseStartX;
                mouseCurrentY = e.Y - mouseStartY;

            }

            //Calculate and determine where the rectangle should be drawn.
            //The x-value of our rectangle should be the minimum between the start x-value and the current x-position
            recSartPointX = Math.Min(mouseStartX, e.X);
            //The y-value of our rectangle should also be the minimum between the start y-value and current y-value
            recSartPointY = Math.Min(mouseStartY, e.Y);
            //The width (recSizeX) of our rectangle should be the maximum between the start x-position and current x-position minus
            //the minimum of start x-position and current x-position
            recSizeX = Math.Max(mouseStartX, e.X) - Math.Min(mouseStartX, e.X);
            //For the hight(recSizeY) value, it's basically the same thing as above, but now with the y-values:
            recSizeY = Math.Max(mouseStartY, e.Y) - Math.Min(mouseStartY, e.Y);
        }
       
        private void Daire_MouseClick(object sender, MouseEventArgs e)
        {
        //    Daire.BackColor = Color.MediumPurple;
        }
        private void Daire_MouseLeave(object sender, EventArgs e)
        {
     //       Daire.BackColor = cizimSekil.BackColor;
        }
        private void Dortgen_MouseClick(object sender, MouseEventArgs e)
        {
       
        }
        private void DrawFromText(String X1, String Y1, String width1, String height1, String type1, String backColor)
        {
            Graphics drawing = panel_Draw.CreateGraphics();
            SolidBrush sb = new SolidBrush( Color.FromName(backColor));
            switch(int.Parse(type1))
            {
                case 1:
                    drawing.FillRectangle(sb, int.Parse(X1), int.Parse(Y1), int.Parse(width1), int.Parse(height1));
                    break;
                case 2:
                    drawing.FillEllipse(sb, int.Parse(X1), int.Parse(Y1), int.Parse(width1), int.Parse(height1));
                    break;
            }
        }
        private void secme_Click(object sender, EventArgs e)
        {
            sec = true;
            
        }
        private void panel_Draw_Click(object sender, EventArgs e)
        {
            if (sec == true)
            {
                Graphics g = panel_Draw.CreateGraphics();
                position.X = 350;
                position.Y = 350;
                
                Region fillrec = new Region(rectangle);
                //if (MousePosition == )
                //{
                g.FillRegion(new SolidBrush(Color.Purple), fillrec);
                //}
                i++;
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File (*.txt) |*.txt";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    StreamWriter Kayit = new StreamWriter(save.FileName);
                    Kayit.WriteLine(i);
                    for (j = 0; j < i; j++)
                    {
                        Kayit.WriteLine("X" + rectangles[j].X + "Y" + rectangles[j].Y + "W" + rectangles[j].Width + "H" + rectangles[j].Height + "T" + type[j] + Col[j]);
                    }
                    Kayit.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File save error : " + ex.Message);
                }
            }
        }
        private void open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text File (*.txt) |*.txt";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                StreamReader oku = new StreamReader(fileName);
                string text = File.ReadAllText(fileName);
                string[] lines = text.Split('\n');
                for (j = 1; j <= int.Parse(lines[0]); j++)
                {
                    string[] X0 = lines[j].Split('X', 'Y');
                    string[] Y0 = lines[j].Split('Y', 'W');
                    string[] width0 = lines[j].Split('W', 'H');
                    string[] height0 = lines[j].Split('H', 'T');
                    string[] type0 = lines[j].Split('T', 'C');
                    string[] color0 = lines[j].Split('[', ']');
                    DrawFromText(X0[1], Y0[1], width0[1], height0[1], type0[1], color0[1]);
                }
                kaydet.Invalidate();
            }
        }
        private void Dortgen_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void Dortgen_MouseUp(object sender, MouseEventArgs e)
        {

        }
        private void cizimSekil_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public class Renkler: Form1
    {
        public ColorSelected Selected { get; set; }
        private void R_red_Click(object sender, EventArgs e)
        {
            Selected = ColorSelected.Kirmizi;
            kalem.Color = Color.Red;
        }

        private void R_mavi_Click(object sender, EventArgs e)
        {
            Selected = ColorSelected.Mavi;
            kalem.Color = Color.Blue;
        }

        private void R_green_Click(object sender, EventArgs e)
        {
            Selected = ColorSelected.Yesil;
            kalem.Color = Color.Green;
        }

        private void R_orange_Click(object sender, EventArgs e)
        {
            Selected = ColorSelected.turuncu;
            kalem.Color = Color.Orange;
        }

        private void R_black_Click(object sender, EventArgs e)
        {
            Selected = ColorSelected.Siyah;
            kalem.Color = Color.Black;
        }

        private void R_yello_Click(object sender, EventArgs e)
        {
            Selected = ColorSelected.Sari;
            kalem.Color = Color.Yellow;
        }

        private void R_mor_Click(object sender, EventArgs e)
        {
            Selected = ColorSelected.Mor;
            kalem.Color = Color.Purple;
        }

        private void R_brown_Click(object sender, EventArgs e)
        {
            Selected = ColorSelected.Kahverengi;
            kalem.Color = Color.Brown;
        }

        private void R_white_Click(object sender, EventArgs e)
        {
            Selected = ColorSelected.Beyaz;
            kalem.Color = Color.White;
        }
    }
    public class Shape :Form1
    {
        public ShapeSelected Selected { get; set; }
        private void Dortgen_Click(object sender, EventArgs e)
        {
            Selected = ShapeSelected.Square;
        }
        private void Daire_Click(object sender, EventArgs e)
        {
            Selected = ShapeSelected.Circle;
        }
        private void Ucgen_Click(object sender, EventArgs e)
        {
            Selected = ShapeSelected.Traingle;
        }
        private void Altigen_Click(object sender, EventArgs e)
        {
            Selected = ShapeSelected.hexagon;
        }
    }
}