using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public static string filePath1 = "";
        public static string filePath2 = "";
        public static string filePath3 = "";
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

        private void labFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lab4Button_Click(object sender, EventArgs e)
        {
            L4Form l4 = new L4Form();
            l4.Show();
        }

        private void lab5Button_Click(object sender, EventArgs e)
        {
            L5Form l5 = new L5Form();
            l5.Show();
        }

        private void lab6Button_Click(object sender, EventArgs e)
        {
            L6Form l6 = new L6Form();
            l6.Show();
        }

        private void chooseFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            filePath1 = openFileDialog.FileName;
            textBox1.Text = filePath1;
        }

        private void loadButton1_Click(object sender, EventArgs e)
        {
            imageOrginal0 = new Bitmap(Image.FromFile(filePath1), new Size(labDisplayPanel.Width, labDisplayPanel.Height));
            labDisplayPanel.BackgroundImage = imageOrginal0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chooseFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            filePath2 = openFileDialog.FileName;
            textBox2.Text = filePath2;
        }

        private void loadButton2_Click(object sender, EventArgs e)
        {
            imageOrginal1 = new Bitmap(Image.FromFile(filePath2), new Size(labDisplayPanel.Width, labDisplayPanel.Height));
            labDisplayPanel.BackgroundImage = imageOrginal1;
        }

        private void chooseFile3_Click(object sender, EventArgs e)
        {

        }
    }
}
