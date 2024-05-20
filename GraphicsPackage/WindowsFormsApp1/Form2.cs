using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Circle : Form
    {
        List<Tuple<int, int>> points = new List<Tuple<int, int>>();
        public Circle()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        void circlePoints(int xCenter, int yCenter, int x, int y)
        {
            points.Add(new Tuple<int, int>(xCenter + x, yCenter + y));
            points.Add(new Tuple<int, int>(xCenter - x, yCenter + y));
            points.Add(new Tuple<int, int>(xCenter + x, yCenter - y));
            points.Add(new Tuple<int, int>(xCenter - x, yCenter - y));
            points.Add(new Tuple<int, int>(xCenter + y, yCenter + x));
            points.Add(new Tuple<int, int>(xCenter - y, yCenter + x));
            points.Add(new Tuple<int, int>(xCenter + y, yCenter - x));
            points.Add(new Tuple<int, int>(xCenter - y, yCenter - x));
        }
        void circleMidpoint(int xCenter, int yCenter, int radius)
        {
            int x = 0;
            int y = radius;
            int p = 1 - radius;
            circlePoints(xCenter, yCenter, x, y);
            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                circlePoints(xCenter, yCenter, x, y);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DDA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(X1.Text) ||
                string.IsNullOrWhiteSpace(Y1.Text) ||
                string.IsNullOrWhiteSpace(X3.Text))
            {
                MessageBox.Show("Please enter text in the text box.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                X1.Focus();
            }
            else
            {
                int x = int.Parse(X1.Text);
                int y = int.Parse(Y1.Text);
                int Radius = int.Parse(X3.Text);
                var aBrush = Brushes.Black;
                var draw = panel4.CreateGraphics();
                circleMidpoint(x, y, Radius);
                foreach (var pair in points)
                {
                    draw.FillRectangle(aBrush, pair.Item1 + (panel4.Width / 2), (panel4.Height) / 2 - pair.Item2, 2, 2);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            foreach (var pair in points)
            {
                message.AppendLine($"({pair.Item1}, {pair.Item2})");
            }
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Text = message.ToString();
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.ReadOnly = true;
            richTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            Form form = new Form();
            form.Text = "Circle Points";
            form.Controls.Add(richTextBox);
            form.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
