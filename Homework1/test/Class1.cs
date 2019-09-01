using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.UI;
using Emgu.Util;
using Emgu.CV.Structure;

public partial class islem
{
    // ********************* Fotograf yukle *******************************//
    public static string getFileName()
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "All files (*.*)|*.*";
        if (ofd.ShowDialog() == DialogResult.OK)
            return ofd.FileName;
        else return "";
    }
    // ********************* BGR-Gri'e donusturme**************************//
    public static Image<Gray, byte> GriGetir(Image<Bgr, byte> color_img)
    {

        Image<Gray, byte> gri = color_img.Convert<Gray, byte>();
        return gri;
    }
    // ********************* Gri-Histogram'a**************************//
    public static Mat HistogramGetir(Image<Gray, byte> griFoto)
    {
        DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 256));
        hist.Calculate(new Image<Gray, Byte>[] { griFoto }, false, null);
        Mat m = new Mat();
        hist.CopyTo(m);
        return m;
    }
    // ********************* Gri-Binary ****************************//
    public static Image<Gray, byte> BinaryGetir(Image<Gray, byte> gri)
    {
        int threshold = 70;
        Image<Gray, byte> binary = gri.ThresholdBinary(new Gray(threshold), new Gray(255));
        return binary;
    }
    ///////////////////////////////////////////////////////////////////
}