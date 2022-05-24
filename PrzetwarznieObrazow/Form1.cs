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
    public partial class Form1 : Form
    {
        
        public static Bitmap imageOrginal0 = Properties.Resources.defaultImageSample;
        
        public static Bitmap imageOrginal1 = Properties.Resources.defaultImageSample;
        public Form1()
        {
            InitializeComponent();
            imageOrginal0 = new Bitmap(imageOrginal0, new Size(labDisplayPanel.Width, labDisplayPanel.Height));
            labDisplayPanel.BackgroundImage = imageOrginal0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void loadButton3_Click(object sender, EventArgs e)
        {

        }

        private void lab1Button_Click(object sender, EventArgs e)
        {
            L1From l1 = new L1From();
            l1.Show();
        }

        private void lab2Button_Click(object sender, EventArgs e)
        {
            L2Form l2 = new L2Form();
            l2.Show();
        }

        private void lab3Button_Click(object sender, EventArgs e)
        {
            L3Form l3 = new L3Form();
            l3.Show();
        }
    }
}
