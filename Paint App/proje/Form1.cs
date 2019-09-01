using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace proje
{
    public partial class Form1 : Form
    {
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
        int[] type = new int[100];
        Color[] Col = new Color[100];
        Rectangle[] rectangles = new Rectangle[100];
        Rectangle rectangle = new Rectangle(50, 50, 50, 50);
        Point position = new Point();
        Point[] Pucgen = new Point[3];
        Point[] Paltigen = new Point[6];
        private int i = 0;
        private int j = 0;
        #endregion
        public enum ShapeSelected { Square, Traingle, Circle, hexagon }
        public enum ColorSelected { Siyah, Beyaz, Yesil, Mor, Mavi, Kirmizi, Kahverengi, turuncu, Sari }
        public ShapeSelected GetShapeSelected { get; set; }
        public ColorSelected GetColorSelected { get; set; }
        Pen SiyahKalem = new Pen(Color.Black);
        public Pen kalem = new Pen(Color.Blue);
        Pen GriKalem = new Pen(Color.LightGray);

        public Form1()
        {
            InitializeComponent();
        }

        private void ucgen_olustur(int XX, int YY, int WW, int HH)
        {
            Pucgen[0].X = XX;
            Pucgen[0].Y = YY - WW;
            Pucgen[1].X = XX + 866 * (WW) / 1000;
            Pucgen[1].Y = YY + WW;
            Pucgen[2].X = XX - 866 * (WW) / 1000;
            Pucgen[2].Y = YY + WW;
        }
        private void altigen_olustur(int XX, int YY, int WW, int HH)
        {
            Paltigen[0].X = XX - WW / 2;
            Paltigen[0].Y = YY - (866 * WW) / 1000;
            Paltigen[1].X = XX + WW / 2;
            Paltigen[1].Y = YY - (866 * WW) / 1000;
            Paltigen[2].X = XX + WW;
            Paltigen[2].Y = YY;
            Paltigen[3].X = XX + WW / 2;
            Paltigen[3].Y = YY + (866 * WW) / 1000;
            Paltigen[4].X = XX - WW / 2;
            Paltigen[4].Y = YY + (866 * WW) / 1000;
            Paltigen[5].X = XX - WW;
            Paltigen[5].Y = YY;

        }
        // ---------- Şekiller Çizmek için --------------------------------
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
               
                switch (GetShapeSelected)
                {
                    case ShapeSelected.Square :

                        rectangles[i].Height = recSizeY;
                        rectangles[i].Width = recSizeX;
                        rectangles[i].X = recSartPointX;
                        rectangles[i].Y = recSartPointY;
                        type[i] = 1;
                        g.FillRectangle(new SolidBrush(kalem.Color), rectangles[i]);
                        Col[i] = kalem.Color;

                        i++;
                        break;
                    case ShapeSelected.Circle:
                        rectangles[i].Height = mouseCurrentY;
                        rectangles[i].Width = mouseCurrentX;
                        rectangles[i].X = mouseStartX;
                        rectangles[i].Y = mouseStartY;
                        type[i] = 2;
                        g.FillEllipse(new SolidBrush(kalem.Color), rectangles[i]);
                        Col[i] = kalem.Color;

                        i++;
                        break;
                    case ShapeSelected.Traingle:
                        rectangles[i].Height = 2*recSizeY/3;
                        rectangles[i].Width = 2*recSizeX/3;
                        rectangles[i].X = recSartPointX;
                        rectangles[i].Y = recSartPointY;
                        ucgen_olustur(rectangles[i].X,rectangles[i].Y,rectangles[i].Width, rectangles[i].Height);
                        g.FillPolygon(new SolidBrush(kalem.Color), Pucgen);
                        Col[i] = kalem.Color;
                        type[i] = 3;

                        i++;
                        break;
                    case ShapeSelected.hexagon:

                        rectangles[i].Height = recSizeY;
                        rectangles[i].Width = recSizeX;
                        rectangles[i].X = mouseStartX;
                        rectangles[i].Y = mouseStartY;
                        type[i] = 4;
                        altigen_olustur(rectangles[i].X, rectangles[i].Y, rectangles[i].Width, rectangles[i].Height);

                        g.FillPolygon(new SolidBrush(kalem.Color), Paltigen);
                        Col[i] = kalem.Color;
                        i++;
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
        //------------- Save and Open  -------------------------------------
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
        // -----------------------------------------------------------------
        private void DrawFromText(String X1, String Y1, String width1, String height1, String type1, String backColor)
        {
            Graphics drawing = panel_Draw.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.FromName(backColor));
            Graphics g = panel_Draw.CreateGraphics();

            switch (int.Parse(type1))
            {
                case 1:
                    drawing.FillRectangle(sb, int.Parse(X1), int.Parse(Y1), int.Parse(width1), int.Parse(height1));
                    break;
                case 2:
                    drawing.FillEllipse(sb, int.Parse(X1), int.Parse(Y1), int.Parse(width1), int.Parse(height1));
                    break;
                case 3:
                    ucgen_olustur(int.Parse(X1), int.Parse(Y1), int.Parse(width1), int.Parse(height1));

                    g.FillPolygon(sb, Pucgen);
                
                    break;
                case 4:
                    altigen_olustur(int.Parse(X1), int.Parse(Y1), int.Parse(width1), int.Parse(height1));

                    g.FillPolygon(sb, Paltigen);

                    break;
            }
        }
        private void secme_Click(object sender, EventArgs e)
        {
            //sec = true;

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
        #region ColorSelected
        private void R_red_Click(object sender, EventArgs e)
        {
            GetColorSelected = ColorSelected.Kirmizi;
            kalem.Color = Color.Red;
        }

        private void R_mavi_Click(object sender, EventArgs e)
        {
            GetColorSelected = ColorSelected.Mavi;
            kalem.Color = Color.Blue;
        }

        private void R_green_Click(object sender, EventArgs e)
        {
            GetColorSelected = ColorSelected.Yesil;
            kalem.Color = Color.Green;
        }

        private void R_orange_Click(object sender, EventArgs e)
        {
            GetColorSelected = ColorSelected.turuncu;
            kalem.Color = Color.Orange;
        }

        private void R_black_Click(object sender, EventArgs e)
        {
            GetColorSelected = ColorSelected.Siyah;
            kalem.Color = Color.Black;
        }

        private void R_yello_Click(object sender, EventArgs e)
        {
            GetColorSelected = ColorSelected.Sari;
            kalem.Color = Color.Yellow;
        }

        private void R_mor_Click(object sender, EventArgs e)
        {
            GetColorSelected = ColorSelected.Mor;
            kalem.Color = Color.Purple;
        }

        private void R_brown_Click(object sender, EventArgs e)
        {
            GetColorSelected = ColorSelected.Kahverengi;
            kalem.Color = Color.Brown;
        }

        private void R_white_Click(object sender, EventArgs e)
        {
            GetColorSelected = ColorSelected.Beyaz;
            kalem.Color = Color.White;
        }
        #endregion
        #region ShapeSelected
        private void Dortgen_Click_1(object sender, EventArgs e)
        {
            GetShapeSelected = ShapeSelected.Square;
        }

        private void Daire_Click_1(object sender, EventArgs e)
        {
            GetShapeSelected = ShapeSelected.Circle;
        }

        private void Ucgen_Click_1(object sender, EventArgs e)
        {
            GetShapeSelected = ShapeSelected.Traingle;
        }

        private void Altigen_Click_1(object sender, EventArgs e)
        {
            GetShapeSelected = ShapeSelected.hexagon;
        }
        #endregion

        // ---------- Mouse Click and Leave ---------------------------------
        #region Purple
        private void Dortgen_MouseClick(object sender, MouseEventArgs e)
        {
            Dortgen.BackColor = Color.MediumPurple;
        }
        private void Daire_MouseClick(object sender, MouseEventArgs e)
        {
            Daire.BackColor = Color.MediumPurple;
        }
        private void Ucgen_MouseClick(object sender, MouseEventArgs e)
        {
            Ucgen.BackColor = Color.MediumPurple;
        }
        private void Altigen_MouseClick(object sender, MouseEventArgs e)
        {
            Altigen.BackColor = Color.MediumPurple;
        }
        private void Dortgen_MouseLeave(object sender, EventArgs e)
        {
            Dortgen.BackColor = cizimSekil.BackColor;
        }
        private void Daire_MouseLeave(object sender, EventArgs e)
        {
            Daire.BackColor = cizimSekil.BackColor;
        }
        private void Ucgen_MouseLeave(object sender, EventArgs e)
        {
            Ucgen.BackColor = cizimSekil.BackColor;
        }
        private void Altigen_MouseLeave(object sender, EventArgs e)
        {
            Altigen.BackColor = cizimSekil.BackColor;
        }
        private void secme_MouseClick(object sender, MouseEventArgs e)
        {
            secme.BackColor = Color.MediumPurple;
        }
        private void silme_MouseClick(object sender, MouseEventArgs e)
        {
            silme.BackColor = Color.MediumPurple;
        }
        private void open_MouseClick(object sender, MouseEventArgs e)
         {
            open.BackColor = Color.MediumPurple;
         }
        private void kaydet_MouseClick(object sender, MouseEventArgs e)
        {
            kaydet.BackColor = Color.MediumPurple;
        }
        private void secme_MouseLeave(object sender, EventArgs e)
        {
            secme.BackColor = sekil_islemleri.BackColor;
        }
        private void silme_MouseLeave(object sender, EventArgs e)
        {
            silme.BackColor = sekil_islemleri.BackColor;
        }
        private void open_MouseLeave(object sender, EventArgs e)
        {
            open.BackColor = Dosya_islemleri.BackColor;
        }
        private void kaydet_MouseLeave(object sender, EventArgs e)
        {
            kaydet.BackColor = Dosya_islemleri.BackColor;
        }
        #endregion
    }
}