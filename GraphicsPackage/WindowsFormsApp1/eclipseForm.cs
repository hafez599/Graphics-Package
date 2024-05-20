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
    public partial class eclipseForm : Form
    {
        List<Tuple<int, int>> points = new List<Tuple<int, int>>();
        public eclipseForm()
        {
            InitializeComponent();
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
                string.IsNullOrWhiteSpace(Y1.Text) ||
                string.IsNullOrWhiteSpace(X2.Text) ||
                string.IsNullOrWhiteSpace(Y2.Text))
            {
                MessageBox.Show("Please enter text in the text box.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                X1.Focus();
            }
            else
            {
                int x1 = int.Parse(X1.Text);
                int x2 = int.Parse(X2.Text);
                int y1 = int.Parse(Y1.Text);
                int y2 = int.Parse(Y2.Text);
                midptellipse(x1, y1, x2, y2);
                var aBrush = Brushes.Black;
                var draw = panel1.CreateGraphics();

                foreach (var pair in points)
                {
                    draw.FillRectangle(aBrush, pair.Item1 + (panel1.Width / 2), (panel1.Height) / 2 - pair.Item2, 2, 2);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void X1_TextChanged(object sender, EventArgs e)
        {

        }

        public void midptellipse(double rx, double ry,double xc, double yc)
        {

            double dx, dy, d1, d2, x, y;
            x = 0;
            y = ry;
            d1 = (ry * ry) - (rx * rx * ry) +
                            (0.25f * rx * rx);
            dx = 2 * ry * ry * x;
            dy = 2 * rx * rx * y;
            while (dx < dy)
            {
               
                points.Add(new Tuple<int, int>((int)(x + xc), (int)(y + yc)));

                points.Add(new Tuple<int, int>((int)(-x + xc), (int)(y + yc)));

                points.Add(new Tuple<int, int>((int)(x + xc), (int)(-y + yc)));

                points.Add(new Tuple<int, int>((int)(-x + xc), (int)(-y + yc)));

                if (d1 < 0)
                {
                    x++;
                    dx = dx + (2 * ry * ry);
                    d1 = d1 + dx + (ry * ry);
                }
                else
                {
                    x++;
                    y--;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d1 = d1 + dx - dy + (ry * ry);
                }
            }
            d2 = ((ry * ry) * ((x + 0.5f) * (x + 0.5f)))
                + ((rx * rx) * ((y - 1) * (y - 1)))
                - (rx * rx * ry * ry);
            while (y >= 0)
            {
                points.Add(new Tuple<int, int>((int)(x + xc), (int)(y + yc)));
                points.Add(new Tuple<int, int>((int)(-x + xc), (int)(y + yc)));
                points.Add(new Tuple<int, int>((int)(x + xc), (int)(-y + yc)));
                points.Add(new Tuple<int, int>((int)(-x + xc), (int)(-y + yc)));
                if (d2 > 0)
                {
                    y--;
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + (rx * rx) - dy;
                }
                else
                {
                    y--;
                    x++;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + dx - dy + (rx * rx);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

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
            form.Text = "Eclipse Points";
            form.Controls.Add(richTextBox);
            form.ShowDialog();
            points.Clear();
        }

        private void Y2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
