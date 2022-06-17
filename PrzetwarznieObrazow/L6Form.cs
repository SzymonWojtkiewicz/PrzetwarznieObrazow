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
    public partial class L6Form : Form
    {
        Bitmap preProcIm;
        Bitmap postProcIm;
        private int[] matrixMultiply(int x, int y, double[,] M)
        {
            int[] result = new int[3];
            result[0] = (int)(M[0, 0] * x + M[0, 1] * y + M[0, 2] * 1);
            result[1] = (int)(M[1, 0] * x + M[1, 1] * y + M[1, 2] * 1);
            result[2] = (int)(M[2, 0] * x + M[2, 1] * y + M[2, 2] * 1);
            return result;
        }
        
        public L6Form()
        {
            
            InitializeComponent();
            preProcIm = new Bitmap(Form1.imageOrginal0, new Size(pictureBox0.Width, pictureBox0.Height));
            postProcIm = new Bitmap( pictureBox0.Width, pictureBox0.Height);
            pictureBox0.BringToFront();
            pictureBox0.Image = postProcIm;
            numericUpDown1.Maximum = 1000;
            numericUpDown1.Minimum = -1000;
            numericUpDown2.Maximum = 1000;
            numericUpDown2.Minimum = -1000;
            
            
        }

        private void labFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xS = ((int)numericUpDown1.Value);
            int yS = ((int)numericUpDown2.Value);
            double[,] M = new double[3,3] { { 1, 0, xS }, { 0, 1, yS }, { 0, 0, 1 } };
            
            for (int i = 0; i < pictureBox0.Width; i++)
            {
                for (int j = 0; j < pictureBox0.Height; j++)
                {
                    Color c = preProcIm.GetPixel(i, j);
                    int[] result = matrixMultiply(i, j, M);
                    if (result[0] < 0 || result[0] > pictureBox0.Width - 1 || result[1] < 0 || result[1] > pictureBox0.Height - 1)
                        continue;
                    postProcIm.SetPixel(result[0], result[1], c);
                   
                }
            }
            pictureBox0.Image = postProcIm;
            preProcIm = postProcIm;
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fi = Convert.ToDouble(textBox1.Text.ToString());
            double[,] M = new double[3, 3] { { Math.Cos(fi), (-1 * Math.Sin(fi)), 0 }, { Math.Sin(fi), Math.Cos(fi), 0 }, { 0, 0, 1 } };
            
            postProcIm = new Bitmap(pictureBox0.Width * 4, pictureBox0.Height * 4);
            int newMinX = pictureBox0.Width * 4;
            int newMinY = pictureBox0.Height * 4;
            int newMaxX = 0;
            int newMaxY = 0;
            for (int i = 0; i < pictureBox0.Width; i++)
            {
                for (int j = 0; j < pictureBox0.Height; j++)
                {
                    Color c = preProcIm.GetPixel(i, j);
                    int[] result = matrixMultiply(i, j, M);
                    if (result[0] + (pictureBox0.Width * 2) < 0 || result[0] + (pictureBox0.Width * 2) > pictureBox0.Width * 4 - 1 || result[1] + (pictureBox0.Height * 2) < 0 || result[1] + (pictureBox0.Height * 2) > pictureBox0.Height * 4 - 1)
                        continue;
                    postProcIm.SetPixel(result[0] + (pictureBox0.Width * 2), result[1] + (pictureBox0.Height * 2), c);
                    if (!(c.R < 5 && c.G < 5 && c.B < 5))
                    {
                        if (result[0] + (pictureBox0.Width * 2) < newMinX)
                        {
                            newMinX = result[0] + (pictureBox0.Width * 2);
                        }
                        if (result[1] + (pictureBox0.Height * 2) < newMinY)
                        {
                            newMinY = result[1] + (pictureBox0.Height * 2);
                        }
                        if (result[0] + (pictureBox0.Width * 2) > newMaxX)
                        {
                            newMaxX = result[0] + (pictureBox0.Width * 2);
                        }
                        if (result[1] + (pictureBox0.Height * 2) > newMaxY)
                        {
                            newMaxY = result[1] + (pictureBox0.Height * 2);
                        }

                    }


                }
            }
            Rectangle cropRect = new Rectangle(newMinX, newMinY, newMaxX - newMinX, newMaxY - newMinY);
            postProcIm = postProcIm.Clone(cropRect, postProcIm.PixelFormat);
            postProcIm = new Bitmap(postProcIm, new Size(pictureBox0.Width, pictureBox0.Height));
            pictureBox0.Image = null;
            pictureBox0.Image = postProcIm;
            preProcIm = postProcIm;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double hX = Convert.ToDouble(textBox2.Text.ToString());
            double hY = Convert.ToDouble(textBox3.Text.ToString());
            double[,] M1 = new double[3, 3] { { 1, hX, 0 }, {0, 1, 0 }, { 0, 0, 1 } };
            double[,] M2 = new double[3, 3] { { 1, 0, 0 }, { hY, 1, 0 }, { 0, 0, 1 } };

            postProcIm = new Bitmap(pictureBox0.Width * 4, pictureBox0.Height * 4);
            int newMinX = pictureBox0.Width * 4;
            int newMinY = pictureBox0.Height * 4;
            int newMaxX = 0;
            int newMaxY = 0;
            for (int i = 0; i < pictureBox0.Width; i++)
            {
                for (int j = 0; j < pictureBox0.Height; j++)
                {
                    Color c = preProcIm.GetPixel(i, j);
                    int[] result = matrixMultiply(i, j, M1);
                    if (result[0] + (pictureBox0.Width * 2) < 0 || result[0] + (pictureBox0.Width * 2) > pictureBox0.Width * 4 - 1 || result[1] + (pictureBox0.Height * 2) < 0 || result[1] + (pictureBox0.Height * 2) > pictureBox0.Height * 4 - 1)
                        continue;
                    postProcIm.SetPixel(result[0] + (pictureBox0.Width * 2), result[1] + (pictureBox0.Height * 2), c);
                    if (!(c.R < 5 && c.G < 5 && c.B < 5))
                    {
                        if (result[0] + (pictureBox0.Width * 2) < newMinX)
                        {
                            newMinX = result[0] + (pictureBox0.Width * 2);
                        }
                        if (result[1] + (pictureBox0.Height * 2) < newMinY)
                        {
                            newMinY = result[1] + (pictureBox0.Height * 2);
                        }
                        if (result[0] + (pictureBox0.Width * 2) > newMaxX)
                        {
                            newMaxX = result[0] + (pictureBox0.Width * 2);
                        }
                        if (result[1] + (pictureBox0.Height * 2) > newMaxY)
                        {
                            newMaxY = result[1] + (pictureBox0.Height * 2);
                        }

                    }


                }
            }
            Rectangle cropRect = new Rectangle(newMinX, newMinY, newMaxX - newMinX, newMaxY - newMinY);
            postProcIm = postProcIm.Clone(cropRect, postProcIm.PixelFormat);
            postProcIm = new Bitmap(postProcIm, new Size(pictureBox0.Width, pictureBox0.Height));
            preProcIm = postProcIm;

            postProcIm = new Bitmap(pictureBox0.Width * 4, pictureBox0.Height * 4);
             newMinX = pictureBox0.Width * 4;
             newMinY = pictureBox0.Height * 4;
             newMaxX = 0;
             newMaxY = 0;
            for (int i = 0; i < pictureBox0.Width; i++)
            {
                for (int j = 0; j < pictureBox0.Height; j++)
                {
                    Color c = preProcIm.GetPixel(i, j);
                    int[] result = matrixMultiply(i, j, M2);
                    if (result[0] + (pictureBox0.Width * 2) < 0 || result[0] + (pictureBox0.Width * 2) > pictureBox0.Width * 4 - 1 || result[1] + (pictureBox0.Height * 2) < 0 || result[1] + (pictureBox0.Height * 2) > pictureBox0.Height * 4 - 1)
                        continue;
                    postProcIm.SetPixel(result[0] + (pictureBox0.Width * 2), result[1] + (pictureBox0.Height * 2), c);
                    if (!(c.R < 5 && c.G < 5 && c.B < 5))
                    {
                        if (result[0] + (pictureBox0.Width * 2) < newMinX)
                        {
                            newMinX = result[0] + (pictureBox0.Width * 2);
                        }
                        if (result[1] + (pictureBox0.Height * 2) < newMinY)
                        {
                            newMinY = result[1] + (pictureBox0.Height * 2);
                        }
                        if (result[0] + (pictureBox0.Width * 2) > newMaxX)
                        {
                            newMaxX = result[0] + (pictureBox0.Width * 2);
                        }
                        if (result[1] + (pictureBox0.Height * 2) > newMaxY)
                        {
                            newMaxY = result[1] + (pictureBox0.Height * 2);
                        }

                    }


                }
            }
             cropRect = new Rectangle(newMinX, newMinY, newMaxX - newMinX, newMaxY - newMinY);
            postProcIm = postProcIm.Clone(cropRect, postProcIm.PixelFormat);
            postProcIm = new Bitmap(postProcIm, new Size(pictureBox0.Width, pictureBox0.Height));
            pictureBox0.Image = null;
            pictureBox0.Image = postProcIm;
            preProcIm = postProcIm;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a11 = Convert.ToDouble(textBox4.Text.ToString());
            double a12 = Convert.ToDouble(textBox5.Text.ToString());
            double a13 = Convert.ToDouble(textBox6.Text.ToString());
            double a21 = Convert.ToDouble(textBox7.Text.ToString());
            double a22 = Convert.ToDouble(textBox8.Text.ToString());
            double a23 = Convert.ToDouble(textBox9.Text.ToString());

            double[,] M = new double[3, 3] { { a11, a12, a13 }, { a21, a22, a23 }, { 0, 0, 1 } };

            postProcIm = new Bitmap(pictureBox0.Width * 4, pictureBox0.Height * 4);
            int newMinX = pictureBox0.Width * 4;
            int newMinY = pictureBox0.Height * 4;
            int newMaxX = 0;
            int newMaxY = 0;
            for (int i = 0; i < pictureBox0.Width; i++)
            {
                for (int j = 0; j < pictureBox0.Height; j++)
                {
                    Color c = preProcIm.GetPixel(i, j);
                    int[] result = matrixMultiply(i, j, M);
                    if (result[0] + (pictureBox0.Width * 2) < 0 || result[0] + (pictureBox0.Width * 2) > pictureBox0.Width * 4 - 1 || result[1] + (pictureBox0.Height * 2) < 0 || result[1] + (pictureBox0.Height * 2) > pictureBox0.Height * 4 - 1)
                        continue;
                    postProcIm.SetPixel(result[0] + (pictureBox0.Width * 2), result[1] + (pictureBox0.Height * 2), c);
                    if (!(c.R < 5 && c.G < 5 && c.B < 5))
                    {
                        if (result[0] + (pictureBox0.Width * 2) < newMinX)
                        {
                            newMinX = result[0] + (pictureBox0.Width * 2);
                        }
                        if (result[1] + (pictureBox0.Height * 2) < newMinY)
                        {
                            newMinY = result[1] + (pictureBox0.Height * 2);
                        }
                        if (result[0] + (pictureBox0.Width * 2) > newMaxX)
                        {
                            newMaxX = result[0] + (pictureBox0.Width * 2);
                        }
                        if (result[1] + (pictureBox0.Height * 2) > newMaxY)
                        {
                            newMaxY = result[1] + (pictureBox0.Height * 2);
                        }

                    }


                }
            }
            Rectangle cropRect = new Rectangle(newMinX, newMinY, newMaxX - newMinX, newMaxY - newMinY);
            postProcIm = postProcIm.Clone(cropRect, postProcIm.PixelFormat);
            postProcIm = new Bitmap(postProcIm, new Size(pictureBox0.Width, pictureBox0.Height));
            pictureBox0.Image = null;
            pictureBox0.Image = postProcIm;
            preProcIm = postProcIm;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            preProcIm = new Bitmap(Form1.imageOrginal0, new Size(pictureBox0.Width, pictureBox0.Height));
            postProcIm = new Bitmap(pictureBox0.Width, pictureBox0.Height);
            pictureBox0.BringToFront();
            pictureBox0.Image = postProcIm;
        }
    }
}
