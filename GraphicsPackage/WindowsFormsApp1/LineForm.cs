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
    public partial class LineForm : Form
    {
        List<Tuple<int, int>> points = new List<Tuple<int, int>>();
        public LineForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(X1.Text) ||
                string.IsNullOrWhiteSpace(X2.Text) ||
                string.IsNullOrWhiteSpace(Y1.Text) ||
                string.IsNullOrWhiteSpace(Y2.Text))
            {
                MessageBox.Show("Please enter text in the text box.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                int x1 = int.Parse(X1.Text);
                int x2 = int.Parse(X2.Text);
                int y1 = int.Parse(Y1.Text);
                int y2 = int.Parse(Y2.Text);
                Bresenham_Algorithm(x1, y1, x2, y2);
                var aBrush = Brushes.Black;
                var draw = panel1.CreateGraphics();

                foreach (var pair in points)
                {
                    draw.FillRectangle(aBrush, pair.Item1 + (panel1.Width / 2), (panel1.Height) / 2 - pair.Item2, 2, 2);
                }
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void DDA_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(X1.Text) ||
                string.IsNullOrWhiteSpace(X2.Text) ||
                string.IsNullOrWhiteSpace(Y1.Text) ||
                string.IsNullOrWhiteSpace(Y2.Text))
            {
                MessageBox.Show("Please enter text in the text box.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int x1 = int.Parse(X1.Text);
                int x2 = int.Parse(X2.Text);
                int y1 = int.Parse(Y1.Text);
                int y2 = int.Parse(Y2.Text);
                DDA_Algorithm(x1, y1, x2, y2);
                var aBrush = Brushes.Black;
                var draw = panel1.CreateGraphics();

                foreach (var pair in points)
                {
                    draw.FillRectangle(aBrush, pair.Item1 + (panel1.Width / 2), (panel1.Height) / 2 - pair.Item2, 2, 2);
                }

            }
        }

        int round(float a)
        {
            return (int)(a + 0.5);
        }
        private void DDA_Algorithm(int x0, int y0, int x1, int y1)
        {
            points.Clear();
            int dx = x1 - x0, dy = y1 - y0, steps, k;
            float xIncrement, yIncrement, x = x0, y = y0;
            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
               steps = Math.Abs(dy);
            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;
            points.Add(new Tuple<int, int>(round(x), round(y)));
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                points.Add(new Tuple<int, int>(round(x), round(y)));
            }

        }

        private void Bresenham_Algorithm(int x0, int y0, int x1, int y1)
        {
            points.Clear();
            int dx = Math.Abs(x1 - x0), dy = Math.Abs(y1 - y0);
            int x, y, p = 2 * dy - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);
            if (x0 > x1)
            {
                x = x1; y = y1;
                x1 = x0;
            }
            else
            {
                x = x0; y = y0;
            }
            points.Add(new Tuple<int, int>(x,y));
            while (x < x1)
            {
                x++;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y++;
                    p += twoDyMinusDx;
                }
                points.Add(new Tuple<int, int>(x, y));
            }

        }

        private void button1_Click(object sender, EventArgs e)
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
            form.Text = "Line Points";
            form.Controls.Add(richTextBox);
            form.ShowDialog();
            points.Clear();
        }

        private void X1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
