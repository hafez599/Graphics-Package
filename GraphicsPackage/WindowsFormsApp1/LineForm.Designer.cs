namespace WindowsFormsApp1
{
    partial class LineForm
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
            this.X1 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.DDA = new System.Windows.Forms.Button();
            this.Bresenham = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(38, 69);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(100, 22);
            this.X1.TabIndex = 0;
            this.X1.TextChanged += new System.EventHandler(this.X1_TextChanged);
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(173, 69);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(100, 22);
            this.Y1.TabIndex = 1;
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(173, 132);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(100, 22);
            this.Y2.TabIndex = 2;
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(38, 132);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(100, 22);
            this.X2.TabIndex = 3;
            // 
            // DDA
            // 
            this.DDA.Location = new System.Drawing.Point(13, 271);
            this.DDA.Name = "DDA";
            this.DDA.Size = new System.Drawing.Size(75, 23);
            this.DDA.TabIndex = 4;
            this.DDA.Text = "DDA";
            this.DDA.UseVisualStyleBackColor = true;
            this.DDA.Click += new System.EventHandler(this.DDA_Click);
            // 
            // Bresenham
            // 
            this.Bresenham.Location = new System.Drawing.Point(125, 271);
            this.Bresenham.Name = "Bresenham";
            this.Bresenham.Size = new System.Drawing.Size(85, 23);
            this.Bresenham.TabIndex = 5;
            this.Bresenham.Text = "Bresenham";
            this.Bresenham.UseVisualStyleBackColor = true;
            this.Bresenham.Click += new System.EventHandler(this.button2_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(81, 387);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "please enter the coordinates";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Y2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Draw Line Using";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "X1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(299, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 426);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(0, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 2);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(241, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 420);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Show Points";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Bresenham);
            this.Controls.Add(this.DDA);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X1);
            this.Name = "LineForm";
            this.Text = "LineForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.Button DDA;
        private System.Windows.Forms.Button Bresenham;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}