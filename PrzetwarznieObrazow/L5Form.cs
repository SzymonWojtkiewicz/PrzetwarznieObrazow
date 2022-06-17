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
using System.Drawing.Imaging;



namespace PrzetwarznieObrazow
{
    public partial class L5Form : Form
    {
        public static List<List<int>> mask;
        Bitmap preProcIm;
        Bitmap postProcIm;
        Bitmap edgeIm;
        Bitmap postProcImEdge;


      
        public L5Form()
        {
            InitializeComponent();
            preProcIm = new Bitmap(Form1.imageOrginal0, new Size(pictureBox1.Width, pictureBox1.Height));
            postProcIm = new Bitmap(Form1.imageOrginal0, new Size(pictureBox1.Width, pictureBox1.Height));
            edgeIm = new Bitmap(Form1.imageOrginal0, new Size(pictureBox1.Width, pictureBox1.Height));
            postProcImEdge = new Bitmap(Form1.imageOrginal0, new Size(pictureBox1.Width, pictureBox1.Height));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomMaskDesigner cd = new CustomMaskDesigner();
            cd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mask = CustomMaskDesigner.mask;
            int offset = (mask.Count / 2);

            //filtr
            for (int i = offset; i < preProcIm.Width - offset; i++)
            {
                for (int j = offset; j < preProcIm.Height - offset; j++)
                {
                    Color midPxl = preProcIm.GetPixel(i, j);
                    int oR = 0;
                    int oG = 0;
                    int oB = 0;
                    int K = 0;

                    for (int a = 0; a < mask.Count; a++)
                    {
                        for (int b = 0; b < mask.Count; b++)
                        {
                            int x = i - offset + a;
                            int y = j - offset + b;
                            if (x >= 0 && x < preProcIm.Width && y >= 0 && y < preProcIm.Height)
                            {
                                Color pxl = preProcIm.GetPixel(x, y);
                                oR += pxl.R * mask[a][b];
                                oG += pxl.G * mask[a][b];
                                oB += pxl.B * mask[a][b];
                                K += mask[a][b];
                            }
                        }
                    }
                    if (K == 0)
                        K = 1;
                    oR = oR / K;
                    oG = oG / K;
                    oB = oB / K;
                    if (oR > 255)
                    {
                        oR = 255;
                    }
                    if (oG > 255)
                    {
                        oG = 255;
                    }
                    if (oB > 255)
                    {
                        oB = 255;
                    }
                    postProcIm.SetPixel(i, j, Color.FromArgb(oR, oG, oB));
                }
            }
            pictureBox0.Image = null;
            pictureBox0.SendToBack();
            pictureBox1.Image = preProcIm;
            pictureBox2.Image = postProcIm;

            
            
            edgeIm = new Bitmap(Form1.imageOrginal0, new Size(Form1.imageOrginal0.Width, Form1.imageOrginal0.Height));
            /* 
            //edge
            {
                
               Color pxl;
                Color pxlMod;
                for (int i = 0; i < edgeIm.Width; i++)
                {
                    for (int j = 0; j < edgeIm.Height; j++)
                    {
                        pxl = edgeIm.GetPixel(i, j);
                        int rgb = (int)Math.Round((pxl.R * 0.299) + (pxl.G * 0.587) + (pxl.B * 0.114));
                        //pxlMod = Color.FromArgb(.299 * pxl.R + .587 * pxl.G + .114 * pxl.B);
                        edgeIm.SetPixel(i, j, Color.FromArgb(rgb, rgb, rgb));
                    }
                }
            }
               */
            //.Extensions.BitmapConverter.ToMat(edgeIm);
            
            Rectangle rectangle = new Rectangle(0, 0, edgeIm.Width, edgeIm.Height);
            BitmapData bmpData = edgeIm.LockBits(rectangle, ImageLockMode.ReadWrite, edgeIm.PixelFormat);

            Image<Bgra, byte> outputImage = new Image<Bgra, byte>(edgeIm.Width, edgeIm.Height, bmpData.Stride, bmpData.Scan0);
            Image<Gray, byte> edgeImage = outputImage[0];
            
            //bmpData.Stride
            //2904
            //Image<Gray, byte> edgeImage = new Image<Gray, byte>(edgeIm.Width, edgeIm.Height, bmpData.Stride, bmpData.Scan0);

            edgeIm.UnlockBits(bmpData);

            edgeImage = edgeImage.Canny(100, 100);
            //edgeIm = outputImage.ToBitmap();
            edgeIm = edgeImage.ToBitmap();
            edgeIm = new Bitmap(edgeIm, new Size(pictureBox3.Width, pictureBox3.Height));
            pictureBox3.Image = edgeIm;
            //imageBox1.Image = outputImage;

            //wpisalem Bgr zamiast Bgra

            //edge + filtr
            postProcImEdge = new Bitmap(postProcIm, new Size(pictureBox4.Width, pictureBox4.Height));
            edgeIm = new Bitmap(edgeIm, new Size(pictureBox4.Width, pictureBox4.Height));
            preProcIm = new Bitmap(preProcIm, new Size(pictureBox4.Width, pictureBox4.Height));
            for (int i = 0; i < pictureBox4.Width; i++)
            {
                for (int j = 0; j < pictureBox4.Height; j++)
                {
                    Color pxl = edgeIm.GetPixel(i, j);
                    if (pxl.R != 0 || pxl.G != 0 || pxl.B != 0)
                    {
                        Color pxl2 = preProcIm.GetPixel(i, j);
                        postProcImEdge.SetPixel(i, j, pxl2);
                    }
                }
            }
            pictureBox4.Image = postProcImEdge;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void L5Form_Load(object sender, EventArgs e)
        {

        }
    }
}
