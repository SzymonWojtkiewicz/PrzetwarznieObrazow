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
    public partial class L1From : Form
    {
        public L1From()
        {
            InitializeComponent();
        }

        private void DisplayOriginalPicture_Click(object sender, EventArgs e)
        {
            pictureBox0.Image = Form1.imageOrginal0;
            pictureBox0.BringToFront();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            
        }

        private void labFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void DisplayGrayRGB_Click(object sender, EventArgs e)
        {
            pictureBox0.Image = null;
            pictureBox0.SendToBack();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            Bitmap gray = new Bitmap(Form1.imageOrginal0, new Size(pictureBox1.Width, pictureBox1.Height));
            Bitmap red = new Bitmap(Form1.imageOrginal0, new Size(pictureBox2.Width, pictureBox2.Height));
            Bitmap green = new Bitmap(Form1.imageOrginal0, new Size(pictureBox3.Width, pictureBox3.Height));
            Bitmap blue = new Bitmap(Form1.imageOrginal0, new Size(pictureBox4.Width, pictureBox4.Height));
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
            pictureBox1.Image = gray;
            
            for (int i = 0; i < red.Width; i++)
            {
                for (int j = 0; j < red.Height; j++)
                {
                    pxl = red.GetPixel(i, j);
                    pxlMod = Color.FromArgb(pxl.R, 0, 0);
                    red.SetPixel(i, j, pxlMod);
                }
            }
            pictureBox2.Image = red;

            
            for (int i = 0; i < green.Width; i++)
            {
                for (int j = 0; j < green.Height; j++)
                {
                    pxl = green.GetPixel(i, j);
                    pxlMod = Color.FromArgb(0, pxl.G, 0);
                    green.SetPixel(i, j, pxlMod);
                }
            }
            pictureBox3.Image = green;

            for (int i = 0; i < blue.Width; i++)
            {
                for (int j = 0; j < blue.Height; j++)
                {
                    pxl = blue.GetPixel(i, j);
                    pxlMod = Color.FromArgb(0, 0, pxl.B);
                    blue.SetPixel(i, j, pxlMod);
                }
            }
            pictureBox4.Image = blue;

            


        }

        private void L1From_Load(object sender, EventArgs e)
        {

        }
    }
}
