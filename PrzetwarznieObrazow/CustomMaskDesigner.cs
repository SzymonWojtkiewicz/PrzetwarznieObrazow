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
    public partial class CustomMaskDesigner : Form
    {
        private List<FlowLayoutPanel> listFLPanels = new List<FlowLayoutPanel>();
        private List<List<NumericUpDown>> listNumericUpDowns = new List<List<NumericUpDown>>();
        public static List<List<int>> mask = new List<List<int>>() { new List<int> { 1, 1, 1 }, new List<int> { 1, -1, 1 }, new List<int> { 1, 1, 1 } };
        private int fLPanelNames = 0;
        private int numericUpDownsNames = 0;

        private int maskSize { get; set; }

        private void buildGrid(int size)
        {
            flowLayoutPanelMain.Controls.Clear();
            /*foreach (List<NumericUpDown> ListNumUpDown in listNumericUpDowns)
            {
                foreach (NumericUpDown numUpDown in ListNumUpDown)
                {
                    numUpDown.;
                }
            }*/
            listFLPanels.Clear();
            listNumericUpDowns.Clear();
            for (int i = 0; i < size; i++)
            {
                FlowLayoutPanel nFLPanel = new FlowLayoutPanel();
                nFLPanel.Name = "FLPanel" + fLPanelNames.ToString();
                nFLPanel.Size = new Size(1260, 30);
                
                listFLPanels.Add(nFLPanel);
                flowLayoutPanelMain.Controls.Add(nFLPanel);
                listNumericUpDowns.Add(new List<NumericUpDown>());



                for (int j = 0; j < size; j++)
                {
                    NumericUpDown nNumericUpDown = new NumericUpDown();
                    nNumericUpDown.Name = "NumericUpDown" + numericUpDownsNames.ToString();
                    nNumericUpDown.Size = new Size(48, 20);
                    nNumericUpDown.Minimum = -10000;
                    listNumericUpDowns[i].Add(nNumericUpDown);
                    listFLPanels[i].Controls.Add(listNumericUpDowns[i].Last());
                }
                fLPanelNames++;
                numericUpDownsNames++;
            }
        }
        public CustomMaskDesigner()
        {
            InitializeComponent();
            maskSize = Int32.Parse(comboBox1.SelectedItem.ToString());
            buildGrid(maskSize);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomMaskDesigner_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApplySizeButton_Click(object sender, EventArgs e)
        {
            buildGrid(Int32.Parse(comboBox1.SelectedItem.ToString()));
        }

        private void ApplyValues_Click(object sender, EventArgs e)
        {
            mask.Clear();
            foreach (List<NumericUpDown> ListNumUpDown in listNumericUpDowns)
            {
                mask.Add(new List<int>());
                foreach (NumericUpDown numUpDown in ListNumUpDown)
                {
                   mask.Last().Add(Convert.ToInt32(Math.Round(numUpDown.Value, 0)));
                }
            }
            
        }
    }
}
