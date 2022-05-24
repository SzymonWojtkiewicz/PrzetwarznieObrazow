using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzetwarznieObrazow
{
    public partial class L4Form : Form
    {
        public L4Form()
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void L4Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            Bitmap Loaded = new Bitmap(Form1.imageOrginal1, new Size(pictureBox1.Width, pictureBox1.Height));


            Bitmap OrgMinLoad = new Bitmap(gray, new Size(pictureBox1.Width, pictureBox1.Height));
            Bitmap OrgMinY = new Bitmap(gray, new Size(pictureBox2.Width, pictureBox2.Height));
            Bitmap OrgMinX = new Bitmap(gray, new Size(pictureBox3.Width, pictureBox3.Height));
            Bitmap OrgMinXY = new Bitmap(gray, new Size(pictureBox4.Width, pictureBox4.Height));

            Bitmap substracted = new Bitmap(gray, new Size(pictureBox1.Width, pictureBox1.Height));

            int minDst = int.Parse(textBox1.Text);

            // original minus loaded

            for (int i = 0; i < OrgMinLoad.Width; i++)
            {
                for (int j = 0; j < OrgMinLoad.Height; j++)
                {
                    pxl = OrgMinLoad.GetPixel(i, j);
                    pxlMod = Loaded.GetPixel(i, j);
                    int result = pxl.R - pxlMod.R;
                    if (result < 0)
                    {
                        result = 0;
                    }
                    Color resultPxi = Color.FromArgb(result, result, result);
                    OrgMinLoad.SetPixel(i, j, resultPxi);
                }
            }
            pictureBox1.Image = OrgMinLoad;

            // original minus Y

            for (int i = 0; i < OrgMinY.Width; i++)
            {
                for (int j = 0; j < OrgMinY.Height; j++)
                {
                    Color resultPxi;
                    pxl = OrgMinY.GetPixel(i, j);
                    if(!Enumerable.Range(0, OrgMinY.Height).Contains(j + minDst))
                    {
                        resultPxi = Color.FromArgb(0, 0, 0);
                        OrgMinY.SetPixel(i, j, resultPxi);
                        continue;
                    }
                    pxlMod = substracted.GetPixel(i, j + minDst);
                    int result = pxl.R - pxlMod.R;
                    if (result < 0)
                    {
                        result = 0;
                    }
                    resultPxi = Color.FromArgb(result, result, result);
                    OrgMinY.SetPixel(i, j, resultPxi);
                }
            }

            pictureBox2.Image = OrgMinY;

            // original minus X

            for (int i = 0; i < OrgMinX.Width; i++)
            {
                for (int j = 0; j < OrgMinX.Height; j++)
                {
                    Color resultPxi;
                    pxl = OrgMinX.GetPixel(i, j);
                    if (!Enumerable.Range(0, OrgMinX.Width).Contains(i + minDst))
                    {
                        resultPxi = Color.FromArgb(0, 0, 0);
                        OrgMinY.SetPixel(i, j, resultPxi);
                        continue;
                    }
                    pxlMod = substracted.GetPixel(i + minDst, j );
                    int result = pxl.R - pxlMod.R;
                    if (result < 0)
                    {
                        result = 0;
                    }
                    resultPxi = Color.FromArgb(result, result, result);
                    OrgMinX.SetPixel(i, j, resultPxi);
                }
            }
            pictureBox3.Image = OrgMinX;
            // original minus XY

            for (int i = 0; i < OrgMinXY.Width; i++)
            {
                for (int j = 0; j < OrgMinXY.Height; j++)
                {
                    Color resultPxi;
                    pxl = OrgMinXY.GetPixel(i, j);
                    if (!Enumerable.Range(0, OrgMinXY.Width).Contains(i + minDst) || !Enumerable.Range(0, OrgMinXY.Height).Contains(j + minDst))
                    {
                        resultPxi = Color.FromArgb(0, 0, 0);
                        OrgMinY.SetPixel(i, j, resultPxi);
                        continue;
                    }
                    pxlMod = substracted.GetPixel(i + minDst, j + minDst);
                    int result = pxl.R - pxlMod.R;
                    if (result < 0)
                    {
                        result = 0;
                    }
                    resultPxi = Color.FromArgb(result, result, result);
                    OrgMinXY.SetPixel(i, j, resultPxi);
                }
            }

            pictureBox4.Image = OrgMinXY;
        }
    }
}
