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
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;
using System.Drawing;
using System.Drawing.Imaging;


namespace PrzetwarznieObrazow
{
    public partial class L2Form : Form
    {
        public static void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }
        public L2Form()
        {
            InitializeComponent();
            pictureBox0.Image = null;
            pictureBox0.SendToBack();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            
            Bitmap yuv = new Bitmap(Form1.imageOrginal0, new Size(pictureBox1.Width, pictureBox1.Height));
            Bitmap hsv = new Bitmap(Form1.imageOrginal0, new Size(pictureBox2.Width, pictureBox2.Height));
          
            Color pxl;
            Color pxlMod;
            for (int i = 0; i < yuv.Width; i++)
            {
                for (int j = 0; j < yuv.Height; j++)
                {
                    pxl = yuv.GetPixel(i, j);
                    int rgb = (int)Math.Round((pxl.R * 0.299) + (pxl.G * 0.587) + (pxl.B * 0.114));
                    //pxlMod = Color.FromArgb(.299 * pxl.R + .587 * pxl.G + .114 * pxl.B);
                    yuv.SetPixel(i, j, Color.FromArgb(rgb, rgb, rgb));
                }
            }
            pictureBox1.Image = yuv;

            for (int i = 0; i < hsv.Width; i++)
            {
                for (int j = 0; j < hsv.Height; j++)
                {
                    pxl = hsv.GetPixel(i, j);
                    /*
                    double hue; 
                    double saturation;
                    double lightness;
                    ColorToHSV(pxl, out hue, out saturation, out lightness);
                    */

                    float hue = pxl.GetHue();
                    float saturation = pxl.GetSaturation();
                    float lightness = pxl.GetBrightness();


                    int rgb = (int)Math.Round((hue) + (saturation) + (lightness));
                    
                    if (rgb > 255)
                    {
                        rgb = 255;
                    }

                    hsv.SetPixel(i, j, Color.FromArgb(rgb, rgb, rgb));
                }
            }
            pictureBox2.Image = hsv;
            

            Rectangle rectangle = new Rectangle(0, 0, yuv.Width, yuv.Height);
            BitmapData bmpData = yuv.LockBits(rectangle, ImageLockMode.ReadWrite, yuv.PixelFormat);

            Image<Bgr, byte> outputImage = new Image<Bgr, byte>(yuv.Width, yuv.Height, bmpData.Stride, bmpData.Scan0);
            Image<Gray, byte> grayImage = outputImage[0]; 
            
            

            histogramBox1.ClearHistogram();
            histogramBox1.GenerateHistograms(grayImage, 50);
            

            yuv.UnlockBits(bmpData);




            Rectangle rectangle2 = new Rectangle(0, 0, hsv.Width, hsv.Height);
            BitmapData bmpData2 = hsv.LockBits(rectangle2, ImageLockMode.ReadWrite, hsv.PixelFormat);
            Image<Bgr, byte> outputImage2 = new Image<Bgr, byte>(hsv.Width, hsv.Height, bmpData2.Stride, bmpData2.Scan0);
            Image<Gray, byte> grayImage2 = outputImage2[0];
            histogramBox2.ClearHistogram();
            histogramBox2.GenerateHistograms(grayImage2, 50);
            hsv.UnlockBits(bmpData2);


        }

        private void DisplayOriginalPicture_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
