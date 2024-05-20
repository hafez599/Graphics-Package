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
    public partial class Translate : Form
    {
        private Color[,] pixelData;
        private Color[,] originallData;
        public Translate()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select an image";
                ofd.Filter = "Image files (*.png;*.jpeg;*.jpg;*.bmp)|*.png;*.jpeg;*.jpg;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    
                    Bitmap image = new Bitmap(ofd.FileName);
                    image.SetResolution(200, 200);
                    pictureBox1.Image = image;
                    pixelData = GetPixelArray(image);
                    originallData = pixelData;
                    //pixelData = RotateMatrix90(pixelData, image.Width, image.Height);
                    //pixelData = ScaleMatrix(pixelData, image.Width, image.Height,4);
                    //pixelData = TranslateImageX(pixelData, 100);
                    //pixelData = RotateImage(pixelData,180);
                    DisplayImage(pixelData);
                }
            }
        }


        public Color[,] GetPixelArray(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;
            Color[,] pixelArray = new Color[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    pixelArray[x, y] = image.GetPixel(x, y);
                }
            }

            return pixelArray;
        }

        private Color[,] TranslateImageXY(int shiftX, int shiftY)
        {
            int width = pixelData.GetLength(0);
            int height = pixelData.GetLength(1);

            Color[,] translatedPixels = new Color[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    translatedPixels[x, y] = Color.Empty; 
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int newX = x + shiftX;
                    int newY = y + shiftY;

                    if (newX >= 0 && newX < width && newY >= 0 && newY < height)
                    {
                        translatedPixels[newX, newY] = pixelData[x, y];
                    }
                }
            }

            return translatedPixels;
        }



        public Color[,] ScaleMatrix(Color[,] matrix, int oldWidth, int oldHeight, double scaleX, double scaleY)
        {
            int newWidth = (int)(oldWidth * scaleX);
            int newHeight = (int)(oldHeight * scaleY);
            Color[,] scaled = new Color[newWidth, newHeight];

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    int oldX = (int)(x / scaleX);
                    int oldY = (int)(y / scaleY);

                    if (oldX >= oldWidth) oldX = oldWidth - 1;
                    if (oldY >= oldHeight) oldY = oldHeight - 1;

                    scaled[x, y] = matrix[oldX, oldY];
                }
            }

            return scaled;
        }




        private void DisplayImage(Color[,] pixelData)
        {
            int width = pixelData.GetLength(0);
            int height = pixelData.GetLength(1);

            Bitmap newImage = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    newImage.SetPixel(x, y, pixelData[x, y]);
                }
            }

            pictureBox1.Image = newImage;
        }


        private Color[,] RotateImage(double angle)
        {
            int width = pixelData.GetLength(0);
            int height = pixelData.GetLength(1);

            double centerX = width / 2.0;
            double centerY = height / 2.0;

            Color[,] rotatedPixels = new Color[width, height];

            double radians = angle * Math.PI / 180.0;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    double newX = (x - centerX) * Math.Cos(radians) - (y - centerY) * Math.Sin(radians) + centerX;
                    double newY = (x - centerX) * Math.Sin(radians) + (y - centerY) * Math.Cos(radians) + centerY;

                    if (newX >= 0 && newX < width && newY >= 0 && newY < height)
                    {
                        int x1 = Math.Max(0, Math.Min(width - 1, (int)Math.Floor(newX)));
                        int x2 = Math.Max(0, Math.Min(width - 1, (int)Math.Ceiling(newX)));
                        int y1 = Math.Max(0, Math.Min(height - 1, (int)Math.Floor(newY)));
                        int y2 = Math.Max(0, Math.Min(height - 1, (int)Math.Ceiling(newY)));

                        Color color11 = pixelData[x1, y1];
                        Color color12 = pixelData[x1, y2];
                        Color color21 = pixelData[x2, y1];
                        Color color22 = pixelData[x2, y2];


                        double weightX2 = newX - x1;
                        double weightX1 = 1 - weightX2;
                        double weightY2 = newY - y1;
                        double weightY1 = 1 - weightY2;

                        int red = (int)(weightX1 * weightY1 * color11.R +
                                        weightX1 * weightY2 * color12.R +
                                        weightX2 * weightY1 * color21.R +
                                        weightX2 * weightY2 * color22.R);

                        int green = (int)(weightX1 * weightY1 * color11.G +
                                          weightX1 * weightY2 * color12.G +
                                          weightX2 * weightY1 * color21.G +
                                          weightX2 * weightY2 * color22.G);

                        int blue = (int)(weightX1 * weightY1 * color11.B +
                                         weightX1 * weightY2 * color12.B +
                                         weightX2 * weightY1 * color21.B +
                                         weightX2 * weightY2 * color22.B);

                        rotatedPixels[x, y] = Color.FromArgb(red, green, blue);
                    }
                }
            }

            return rotatedPixels;
        }

        private Color[,] ReflectHorizontal()
        {
            int width = pixelData.GetLength(0);
            int height = pixelData.GetLength(1);

            Color[,] reflectedPixels = new Color[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    reflectedPixels[width - x - 1, y] = pixelData[x, y];
                }
            }

            return reflectedPixels;
        }

        private Color[,] ReflectVertical()
        {
            int width = pixelData.GetLength(0);
            int height = pixelData.GetLength(1);

            Color[,] reflectedPixels = new Color[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    reflectedPixels[x, height - y - 1] = pixelData[x, y];
                }
            }

            return reflectedPixels;
        }

        private Color[,] ShearX(double kx)
        {
            int width = pixelData.GetLength(0);
            int height = pixelData.GetLength(1);
            int centerY = height / 2;

            int newWidth = (int)(width + Math.Abs(kx) * height);
            Color[,] result = new Color[newWidth, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    result[x, y] = Color.Transparent; 
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int offset = centerY - y;
                    int newX = (int)(x + kx * offset);
                    if (newX >= 0 && newX < newWidth)
                    {
                        result[newX, y] = pixelData[x, y];
                    }
                }
            }

            return result;
        }


        private Color[,] ShearY(double ky)
        {
            int width = pixelData.GetLength(0);
            int height = pixelData.GetLength(1);
            int centerX = width / 2;

            int newHeight = (int)(height + Math.Abs(ky) * width);
            Color[,] result = new Color[width, newHeight];

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    result[x, y] = Color.Transparent; 
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int offset = centerX - x; 
                    int newY = (int)(y + ky * offset);
                    if (newY >= 0 && newY < newHeight)
                    {
                        result[x, newY] = pixelData[x, y];
                    }
                }
            }

            return result;
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(trans.Text))
            {
                MessageBox.Show("Please enter text in the text box.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                trans.Focus();
            }
            else
            {
                if (pixelData != null)
                {
                    int angel = int.Parse(trans.Text);
                    pixelData = RotateImage(angel);
                    DisplayImage(pixelData);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(X.Text) || string.IsNullOrWhiteSpace(Y.Text))
            {
                MessageBox.Show("Please enter text in the text box.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                X.Focus();
            }
            else
            {
                if (pixelData != null)
                {
                    int x = int.Parse(X.Text);
                    int y = int.Parse(Y.Text);
                    pixelData = TranslateImageXY(x, y);
                    DisplayImage(pixelData);
                }
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrWhiteSpace(X1.Text) || string.IsNullOrWhiteSpace(Y1.Text))
            {
                MessageBox.Show("Please enter text in the text box.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                X1.Focus();
            }
            else
            {
                if (pixelData != null)
                {
                    double x = double.Parse(X1.Text);
                    double y = double.Parse(Y1.Text);
                    pixelData = ScaleMatrix(pixelData, pixelData.GetLength(0), pixelData.GetLength(1), x, y);
                    DisplayImage(pixelData);
                }
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pixelData != null)
            {
                pixelData = ReflectHorizontal();
                DisplayImage(pixelData);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(pixelData != null)
            {
                pixelData = ReflectVertical();
                DisplayImage(pixelData);
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(xshaer.Text))
            {
                MessageBox.Show("Please enter text in the text box.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                xshaer.Focus();
            }
            else
            {
                if (pixelData != null)
                {
                    double x = double.Parse(xshaer.Text);
                    pixelData = ShearX(x);
                    DisplayImage(pixelData);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(yshear.Text))
            {
                MessageBox.Show("Please enter text in the text box.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yshear.Focus();
            }
            else
            {
                if (pixelData != null)
                {
                    double y = double.Parse(yshear.Text);
                    pixelData = ShearY(y);
                    DisplayImage(pixelData);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(pixelData != null)
            {
                pixelData = originallData;
                DisplayImage(pixelData);
            }
        }
    }
}
