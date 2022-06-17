namespace PrzetwarznieObrazow
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chooseFile1 = new System.Windows.Forms.Button();
            this.loadButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chooseFile2 = new System.Windows.Forms.Button();
            this.loadButton2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.chooseFile3 = new System.Windows.Forms.Button();
            this.loadButton3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lab1Button = new System.Windows.Forms.Button();
            this.lab2Button = new System.Windows.Forms.Button();
            this.lab3Button = new System.Windows.Forms.Button();
            this.lab4Button = new System.Windows.Forms.Button();
            this.lab5Button = new System.Windows.Forms.Button();
            this.lab6Button = new System.Windows.Forms.Button();
            this.labFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labDisplayPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.labDisplayPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1676, 876);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Controls.Add(this.labFlowLayoutPanel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 873);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.textBox1);
            this.flowLayoutPanel3.Controls.Add(this.chooseFile1);
            this.flowLayoutPanel3.Controls.Add(this.loadButton1);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.textBox2);
            this.flowLayoutPanel3.Controls.Add(this.chooseFile2);
            this.flowLayoutPanel3.Controls.Add(this.loadButton2);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.textBox3);
            this.flowLayoutPanel3.Controls.Add(this.chooseFile3);
            this.flowLayoutPanel3.Controls.Add(this.loadButton3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(197, 229);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Load picture to modify";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chooseFile1
            // 
            this.chooseFile1.Location = new System.Drawing.Point(3, 42);
            this.chooseFile1.Name = "chooseFile1";
            this.chooseFile1.Size = new System.Drawing.Size(75, 23);
            this.chooseFile1.TabIndex = 1;
            this.chooseFile1.Text = "Choose File";
            this.chooseFile1.UseVisualStyleBackColor = true;
            this.chooseFile1.Click += new System.EventHandler(this.chooseFile1_Click);
            // 
            // loadButton1
            // 
            this.loadButton1.Location = new System.Drawing.Point(84, 42);
            this.loadButton1.Name = "loadButton1";
            this.loadButton1.Size = new System.Drawing.Size(75, 23);
            this.loadButton1.TabIndex = 2;
            this.loadButton1.Text = "Load";
            this.loadButton1.UseVisualStyleBackColor = true;
            this.loadButton1.Click += new System.EventHandler(this.loadButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Load second picture to modify(optional)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 20);
            this.textBox2.TabIndex = 3;
            // 
            // chooseFile2
            // 
            this.chooseFile2.Location = new System.Drawing.Point(3, 123);
            this.chooseFile2.Name = "chooseFile2";
            this.chooseFile2.Size = new System.Drawing.Size(75, 23);
            this.chooseFile2.TabIndex = 4;
            this.chooseFile2.Text = "Choose File";
            this.chooseFile2.UseVisualStyleBackColor = true;
            this.chooseFile2.Click += new System.EventHandler(this.chooseFile2_Click);
            // 
            // loadButton2
            // 
            this.loadButton2.Location = new System.Drawing.Point(84, 123);
            this.loadButton2.Name = "loadButton2";
            this.loadButton2.Size = new System.Drawing.Size(75, 23);
            this.loadButton2.TabIndex = 5;
            this.loadButton2.Text = "Load";
            this.loadButton2.UseVisualStyleBackColor = true;
            this.loadButton2.Click += new System.EventHandler(this.loadButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Location of new picture";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 20);
            this.textBox3.TabIndex = 6;
            // 
            // chooseFile3
            // 
            this.chooseFile3.Location = new System.Drawing.Point(3, 191);
            this.chooseFile3.Name = "chooseFile3";
            this.chooseFile3.Size = new System.Drawing.Size(94, 23);
            this.chooseFile3.TabIndex = 7;
            this.chooseFile3.Text = "Choose file path";
            this.chooseFile3.UseVisualStyleBackColor = true;
            this.chooseFile3.Click += new System.EventHandler(this.chooseFile3_Click);
            // 
            // loadButton3
            // 
            this.loadButton3.Location = new System.Drawing.Point(103, 191);
            this.loadButton3.Name = "loadButton3";
            this.loadButton3.Size = new System.Drawing.Size(75, 23);
            this.loadButton3.TabIndex = 8;
            this.loadButton3.Text = "Save";
            this.loadButton3.UseVisualStyleBackColor = true;
            this.loadButton3.Click += new System.EventHandler(this.loadButton3_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.lab1Button);
            this.flowLayoutPanel4.Controls.Add(this.lab2Button);
            this.flowLayoutPanel4.Controls.Add(this.lab3Button);
            this.flowLayoutPanel4.Controls.Add(this.lab4Button);
            this.flowLayoutPanel4.Controls.Add(this.lab5Button);
            this.flowLayoutPanel4.Controls.Add(this.lab6Button);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 238);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(197, 100);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // lab1Button
            // 
            this.lab1Button.Location = new System.Drawing.Point(3, 3);
            this.lab1Button.Name = "lab1Button";
            this.lab1Button.Size = new System.Drawing.Size(75, 23);
            this.lab1Button.TabIndex = 0;
            this.lab1Button.Text = "Lab1";
            this.lab1Button.UseVisualStyleBackColor = true;
            this.lab1Button.Click += new System.EventHandler(this.lab1Button_Click);
            // 
            // lab2Button
            // 
            this.lab2Button.Location = new System.Drawing.Point(84, 3);
            this.lab2Button.Name = "lab2Button";
            this.lab2Button.Size = new System.Drawing.Size(75, 23);
            this.lab2Button.TabIndex = 1;
            this.lab2Button.Text = "Lab2";
            this.lab2Button.UseVisualStyleBackColor = true;
            this.lab2Button.Click += new System.EventHandler(this.lab2Button_Click);
            // 
            // lab3Button
            // 
            this.lab3Button.Location = new System.Drawing.Point(3, 32);
            this.lab3Button.Name = "lab3Button";
            this.lab3Button.Size = new System.Drawing.Size(75, 23);
            this.lab3Button.TabIndex = 2;
            this.lab3Button.Text = "Lab3";
            this.lab3Button.UseVisualStyleBackColor = true;
            this.lab3Button.Click += new System.EventHandler(this.lab3Button_Click);
            // 
            // lab4Button
            // 
            this.lab4Button.Location = new System.Drawing.Point(84, 32);
            this.lab4Button.Name = "lab4Button";
            this.lab4Button.Size = new System.Drawing.Size(75, 23);
            this.lab4Button.TabIndex = 3;
            this.lab4Button.Text = "Lab4";
            this.lab4Button.UseVisualStyleBackColor = true;
            this.lab4Button.Click += new System.EventHandler(this.lab4Button_Click);
            // 
            // lab5Button
            // 
            this.lab5Button.Location = new System.Drawing.Point(3, 61);
            this.lab5Button.Name = "lab5Button";
            this.lab5Button.Size = new System.Drawing.Size(75, 23);
            this.lab5Button.TabIndex = 4;
            this.lab5Button.Text = "Lab5";
            this.lab5Button.UseVisualStyleBackColor = true;
            this.lab5Button.Click += new System.EventHandler(this.lab5Button_Click);
            // 
            // lab6Button
            // 
            this.lab6Button.Location = new System.Drawing.Point(84, 61);
            this.lab6Button.Name = "lab6Button";
            this.lab6Button.Size = new System.Drawing.Size(75, 23);
            this.lab6Button.TabIndex = 5;
            this.lab6Button.Text = "Lab6";
            this.lab6Button.UseVisualStyleBackColor = true;
            this.lab6Button.Click += new System.EventHandler(this.lab6Button_Click);
            // 
            // labFlowLayoutPanel
            // 
            this.labFlowLayoutPanel.Location = new System.Drawing.Point(3, 344);
            this.labFlowLayoutPanel.Name = "labFlowLayoutPanel";
            this.labFlowLayoutPanel.Size = new System.Drawing.Size(197, 492);
            this.labFlowLayoutPanel.TabIndex = 2;
            this.labFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.labFlowLayoutPanel_Paint);
            // 
            // labDisplayPanel
            // 
            this.labDisplayPanel.Location = new System.Drawing.Point(209, 3);
            this.labDisplayPanel.Name = "labDisplayPanel";
            this.labDisplayPanel.Size = new System.Drawing.Size(1452, 864);
            this.labDisplayPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 900);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel labDisplayPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button chooseFile1;
        private System.Windows.Forms.Button loadButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button chooseFile2;
        private System.Windows.Forms.Button loadButton2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button chooseFile3;
        private System.Windows.Forms.Button loadButton3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button lab1Button;
        private System.Windows.Forms.Button lab2Button;
        private System.Windows.Forms.Button lab3Button;
        private System.Windows.Forms.Button lab4Button;
        private System.Windows.Forms.Button lab5Button;
        private System.Windows.Forms.Button lab6Button;
        private System.Windows.Forms.FlowLayoutPanel labFlowLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

