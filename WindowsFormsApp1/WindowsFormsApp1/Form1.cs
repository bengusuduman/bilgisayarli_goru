using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Görüntü Yükleme
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        // Darken (x - 128)
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);
                    int r = Math.Max(0, c.R - 128);
                    int g = Math.Max(0, c.G - 128);
                    int b = Math.Max(0, c.B - 128);
                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Image = bmp;
        }

        //Lighten (x + 128)
        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);
                    int r = Math.Min(255, c.R + 128);
                    int g = Math.Min(255, c.G + 128);
                    int b = Math.Min(255, c.B + 128);
                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Image = bmp;
        }

        //Invert (255 - x)
        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);
                    int r = 255 - c.R;
                    int g = 255 - c.G;
                    int b = 255 - c.B;
                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Image = bmp;
        }

        // Lower Contrast (x / 2)
        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);
                    int r = c.R / 2;
                    int g = c.G / 2;
                    int b = c.B / 2;
                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Image = bmp;
        }

        // Raise Contrast (x * 2)
        private void button6_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);
                    int r = Math.Min(255, c.R * 2);
                    int g = Math.Min(255, c.G * 2);
                    int b = Math.Min(255, c.B * 2);
                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Image = bmp;
        }

        //Nonlinear Raise Contrast ((x / 255.0)^2 * 255)
        private void button7_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);
                    int r = (int)(Math.Pow((c.R / 255.0), 2) * 255);
                    int g = (int)(Math.Pow((c.G / 255.0), 2) * 255);
                    int b = (int)(Math.Pow((c.B / 255.0), 2) * 255);
                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Image = bmp;
        }
    }
}

