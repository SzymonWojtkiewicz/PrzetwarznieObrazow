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
    public partial class L3Form : Form
    {
        static Bitmap Orginal;
        static int singleThreshold, doubleThresholdBottom, doubleThresholdTop, autoThreshold;
        public L3Form()
        {
            InitializeComponent();
            pictureBox0.SendToBack();
            Orginal = new Bitmap(Form1.imageOrginal0, new Size(pictureBox1.Width, pictureBox1.Height));
            pictureBox1.Image = Orginal;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void L3Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            singleThreshold = Convert.ToInt32(textBox1.Text);
            doubleThresholdBottom = Convert.ToInt32(textBox2.Text);
            doubleThresholdTop = Convert.ToInt32(textBox3.Text);

            if (!Enumerable.Range(0, 256).Contains(singleThreshold))
                singleThreshold = 100;
            if (!Enumerable.Range(0, 256).Contains(doubleThresholdBottom))
                doubleThresholdBottom = 50;
            if (!Enumerable.Range(0, 256).Contains(doubleThresholdTop))
                doubleThresholdTop = 150;

            if (doubleThresholdBottom > doubleThresholdTop)
            {
                int temp = doubleThresholdBottom;
                doubleThresholdBottom = doubleThresholdTop;
                doubleThresholdTop = temp;
            }

            Bitmap gray = new Bitmap(Form1.imageOrginal0, new Size(pictureBox1.Width, pictureBox1.Height));
            Color pxl;
            Color pxlMod;
            for (int i = 0; i < gray.Width; i++)
            {
                for (int j = 0; j < gray.Height; j++)
                {
                    pxl = gray.GetPixel(i, j);
                    int rgb = (int)Math.Round((pxl.R * 0.3) + (pxl.G * 0.59) + (pxl.B * 0.11));
                    //pxlMod = Color.FromArgb(.299 * pxl.R + .587 * pxl.G + .114 * pxl.B);
                    gray.SetPixel(i, j, Color.FromArgb(rgb, rgb, rgb));
                }
            }

            //user defined threshold
            Bitmap userTsBitmap = gray.Clone() as Bitmap;
            Bitmap autoTsBitmap = gray.Clone() as Bitmap;
            Bitmap doubleTsBitmap = gray.Clone() as Bitmap;
            

            for (int i = 0; i < userTsBitmap.Width; i++)
            {
                for (int j = 0; j < userTsBitmap.Height; j++)
                {
                    pxl = userTsBitmap.GetPixel(i, j);
                    if (pxl.R < singleThreshold)
                        userTsBitmap.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    else
                        userTsBitmap.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                }
            }

            pictureBox2.Image = userTsBitmap;

            //auto threshold

            Rectangle rectangle = new Rectangle(0, 0, autoTsBitmap.Width, autoTsBitmap.Height);
            BitmapData bmpData = autoTsBitmap.LockBits(rectangle, ImageLockMode.ReadWrite, autoTsBitmap.PixelFormat);

            Image<Bgra, byte> outputImage = new Image<Bgra, byte>(autoTsBitmap.Width, autoTsBitmap.Height, bmpData.Stride, bmpData.Scan0);
            Image<Gray, byte> grayImage = outputImage[0];

            var histogram = new DenseHistogram(256, new RangeF(0.0f, 255.0f));
            histogram.Calculate(new[] {grayImage}, true, null);
            var values = new float[256];
            histogram.CopyTo(values);

            int threshold = 0;
            for (int i = 30; i < values.Length; i++)
            {
                if (values[i] > values[threshold])
                {
                    threshold = i;
                    
                }
            }
            autoTsBitmap.UnlockBits(bmpData);

            autoThreshold = threshold;

            for (int i = 0; i < autoTsBitmap.Width; i++)
            {
                for (int j = 0; j < autoTsBitmap.Height; j++)
                {
                    pxl = autoTsBitmap.GetPixel(i, j);
                    if (pxl.R < autoThreshold)
                        autoTsBitmap.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    else
                        autoTsBitmap.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                }
            }

            pictureBox3.Image = autoTsBitmap;
            label10.Text = "Threshold: " + autoThreshold;

            //double threshold


            for (int i = 0; i < doubleTsBitmap.Width; i++)
            {
                for (int j = 0; j < doubleTsBitmap.Height; j++)
                {
                    pxl = doubleTsBitmap.GetPixel(i, j);
                    if (pxl.R < doubleThresholdBottom || pxl.R > doubleThresholdTop)
                        doubleTsBitmap.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    else
                        doubleTsBitmap.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                }
            }

            pictureBox4.Image = doubleTsBitmap;
        }
    }
}
