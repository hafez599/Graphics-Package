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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LineForm lineform = new LineForm();
            lineform.ShowDialog();
            this.Close();
        }

        private void Eclipse_Click(object sender, EventArgs e)
        {
            this.Hide();
            eclipseForm eclipse = new eclipseForm();
            eclipse.ShowDialog();
            this.Close();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Circle circleform = new Circle();
            circleform.ShowDialog();
            this.Close();
        }

        private void TranslateScene_Click(object sender, EventArgs e)
        {
            this.Hide();
            Translate translateform = new Translate();
            translateform.ShowDialog();
            this.Close();
        }
    }
}
