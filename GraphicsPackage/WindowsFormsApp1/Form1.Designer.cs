namespace WindowsFormsApp1
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
            this.Eclipse = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TranslateScene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Eclipse
            // 
            this.Eclipse.Location = new System.Drawing.Point(329, 264);
            this.Eclipse.Name = "Eclipse";
            this.Eclipse.Size = new System.Drawing.Size(162, 37);
            this.Eclipse.TabIndex = 0;
            this.Eclipse.Text = "Eclipse";
            this.Eclipse.UseVisualStyleBackColor = true;
            this.Eclipse.Click += new System.EventHandler(this.Eclipse_Click);
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(329, 93);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(162, 37);
            this.Line.TabIndex = 1;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.button2_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(329, 181);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(162, 37);
            this.Circle.TabIndex = 3;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // TranslateScene
            // 
            this.TranslateScene.Location = new System.Drawing.Point(329, 335);
            this.TranslateScene.Name = "TranslateScene";
            this.TranslateScene.Size = new System.Drawing.Size(162, 37);
            this.TranslateScene.TabIndex = 4;
            this.TranslateScene.Text = "2D Transformations";
            this.TranslateScene.UseVisualStyleBackColor = true;
            this.TranslateScene.Click += new System.EventHandler(this.TranslateScene_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TranslateScene);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Eclipse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Eclipse;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Circle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button TranslateScene;
    }
}

