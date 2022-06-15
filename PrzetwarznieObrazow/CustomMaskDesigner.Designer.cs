namespace PrzetwarznieObrazow
{
    partial class CustomMaskDesigner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ApplyValues = new System.Windows.Forms.Button();
            this.ApplySizeButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ApplyValues
            // 
            this.ApplyValues.Location = new System.Drawing.Point(4, 657);
            this.ApplyValues.Name = "ApplyValues";
            this.ApplyValues.Size = new System.Drawing.Size(75, 23);
            this.ApplyValues.TabIndex = 1;
            this.ApplyValues.Text = "Apply Mask";
            this.ApplyValues.UseVisualStyleBackColor = true;
            this.ApplyValues.Click += new System.EventHandler(this.ApplyValues_Click);
            // 
            // ApplySizeButton
            // 
            this.ApplySizeButton.Location = new System.Drawing.Point(139, 23);
            this.ApplySizeButton.Name = "ApplySizeButton";
            this.ApplySizeButton.Size = new System.Drawing.Size(75, 23);
            this.ApplySizeButton.TabIndex = 2;
            this.ApplySizeButton.Text = "Apply Size";
            this.ApplySizeButton.UseVisualStyleBackColor = true;
            this.ApplySizeButton.Click += new System.EventHandler(this.ApplySizeButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9",
            "11",
            "13",
            "15",
            "17",
            "19",
            "21"});
            this.comboBox1.Location = new System.Drawing.Point(12, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size of mask";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(12, 52);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(1264, 599);
            this.flowLayoutPanelMain.TabIndex = 5;
            this.flowLayoutPanelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // CustomMaskDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 692);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ApplySizeButton);
            this.Controls.Add(this.ApplyValues);
            this.Name = "CustomMaskDesigner";
            this.Text = "CustomMaskDesigner";
            this.Load += new System.EventHandler(this.CustomMaskDesigner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ApplyValues;
        private System.Windows.Forms.Button ApplySizeButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
    }
}