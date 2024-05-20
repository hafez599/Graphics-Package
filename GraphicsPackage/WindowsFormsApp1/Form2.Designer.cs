namespace WindowsFormsApp1
{
    partial class Circle
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
            this.label4 = new System.Windows.Forms.Label();
            this.DDA = new System.Windows.Forms.Button();
            this.X3 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.X1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Y1";
            // 
            // DDA
            // 
            this.DDA.Location = new System.Drawing.Point(40, 290);
            this.DDA.Name = "DDA";
            this.DDA.Size = new System.Drawing.Size(75, 23);
            this.DDA.TabIndex = 16;
            this.DDA.Text = "Draw";
            this.DDA.UseVisualStyleBackColor = true;
            this.DDA.Click += new System.EventHandler(this.DDA_Click);
            // 
            // X3
            // 
            this.X3.Location = new System.Drawing.Point(83, 108);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(100, 22);
            this.X3.TabIndex = 15;
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(175, 46);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(100, 22);
            this.Y1.TabIndex = 13;
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(40, 46);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(100, 22);
            this.X1.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(299, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 426);
            this.panel4.TabIndex = 20;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(237, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 425);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(0, 213);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(475, 2);
            this.panel5.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "X1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Radius";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(94, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(160, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Show Points";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "please enter the center";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Circle
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DDA);
            this.Controls.Add(this.X3);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X1);
            this.Name = "Circle";
            this.Text = "z";
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DDA;
        private System.Windows.Forms.TextBox X3;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
    }
}