namespace PrzetwarznieObrazow
{
    partial class L1From
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
            this.labDisplayPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.labFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DisplayOriginalPicture = new System.Windows.Forms.Button();
            this.DisplayGrayRGB = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.labDisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            this.labFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labDisplayPanel
            // 
            this.labDisplayPanel.Controls.Add(this.pictureBox4);
            this.labDisplayPanel.Controls.Add(this.pictureBox3);
            this.labDisplayPanel.Controls.Add(this.pictureBox2);
            this.labDisplayPanel.Controls.Add(this.pictureBox1);
            this.labDisplayPanel.Controls.Add(this.pictureBox0);
            this.labDisplayPanel.Location = new System.Drawing.Point(215, 12);
            this.labDisplayPanel.Name = "labDisplayPanel";
            this.labDisplayPanel.Size = new System.Drawing.Size(1452, 864);
            this.labDisplayPanel.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(726, 429);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(726, 432);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 432);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(726, 432);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(726, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(726, 432);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 432);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox0
            // 
            this.pictureBox0.Location = new System.Drawing.Point(3, 3);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(1452, 864);
            this.pictureBox0.TabIndex = 0;
            this.pictureBox0.TabStop = false;
            // 
            // labFlowLayoutPanel
            // 
            this.labFlowLayoutPanel.Controls.Add(this.DisplayOriginalPicture);
            this.labFlowLayoutPanel.Controls.Add(this.DisplayGrayRGB);
            this.labFlowLayoutPanel.Location = new System.Drawing.Point(12, 15);
            this.labFlowLayoutPanel.Name = "labFlowLayoutPanel";
            this.labFlowLayoutPanel.Size = new System.Drawing.Size(197, 492);
            this.labFlowLayoutPanel.TabIndex = 3;
            this.labFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.labFlowLayoutPanel_Paint);
            // 
            // DisplayOriginalPicture
            // 
            this.DisplayOriginalPicture.Location = new System.Drawing.Point(3, 3);
            this.DisplayOriginalPicture.Name = "DisplayOriginalPicture";
            this.DisplayOriginalPicture.Size = new System.Drawing.Size(183, 23);
            this.DisplayOriginalPicture.TabIndex = 0;
            this.DisplayOriginalPicture.Text = "Display Original Picture";
            this.DisplayOriginalPicture.UseVisualStyleBackColor = true;
            this.DisplayOriginalPicture.Click += new System.EventHandler(this.DisplayOriginalPicture_Click);
            // 
            // DisplayGrayRGB
            // 
            this.DisplayGrayRGB.Location = new System.Drawing.Point(3, 32);
            this.DisplayGrayRGB.Name = "DisplayGrayRGB";
            this.DisplayGrayRGB.Size = new System.Drawing.Size(183, 23);
            this.DisplayGrayRGB.TabIndex = 1;
            this.DisplayGrayRGB.Text = "Dispaly Gray and RGB";
            this.DisplayGrayRGB.UseVisualStyleBackColor = true;
            this.DisplayGrayRGB.Click += new System.EventHandler(this.DisplayGrayRGB_Click);
            // 
            // L1From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 906);
            this.Controls.Add(this.labFlowLayoutPanel);
            this.Controls.Add(this.labDisplayPanel);
            this.Name = "L1From";
            this.Text = "L1From";
            this.Load += new System.EventHandler(this.L1From_Load);
            this.labDisplayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            this.labFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel labDisplayPanel;
        private System.Windows.Forms.FlowLayoutPanel labFlowLayoutPanel;
        private System.Windows.Forms.Button DisplayOriginalPicture;
        private System.Windows.Forms.Button DisplayGrayRGB;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}