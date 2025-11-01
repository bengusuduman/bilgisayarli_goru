using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Dosya işlemleri için
using OfficeOpenXml; // Excel işlemleri için (EPPlus)

namespace WindowsFormsApp2 
{
    public partial class Form1 : Form
    {
        // Griye çevrilmiş resmi saklamak için değişken
        private Bitmap grayImage = null;

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        // "Resim Yükle" butonu
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.png;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Resmi yükle
                Bitmap originalImage = new Bitmap(openFile.FileName);

                // Resmi 200x200 boyutuna getir
                Bitmap resizedImage = new Bitmap(originalImage, 200, 200);
                pictureBox1.Image = resizedImage; // Orijinal resmi 1. PictureBox'a koy

                // Resmi griye çevir
                grayImage = ConvertToGrayScale(resizedImage);
                pictureBox2.Image = grayImage; // Gri resmi 2. PictureBox'a koy
            }
        }

        // "Excel'e Aktar" butonu 
        private void button2_Click(object sender, EventArgs e)
        {
            if (grayImage == null)
            {
                MessageBox.Show("Lütfen önce bir resim yükleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel Files|*.xlsx";
            saveFile.FileName = "GriPikselDegerleri.xlsx";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Pikseller");

                        // 200x200 matris için döngü
                        for (int y = 0; y < grayImage.Height; y++) // Satırlar
                        {
                            for (int x = 0; x < grayImage.Width; x++) // Sütunlar
                            {
                                Color pixelColor = grayImage.GetPixel(x, y);
                                int grayValue = pixelColor.R; // Gri tonda R=G=B'dir
                                worksheet.Cells[y + 1, x + 1].Value = grayValue;
                            }
                        }

                        package.SaveAs(new FileInfo(saveFile.FileName));
                    }

                    MessageBox.Show("Excel dosyası başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excel dosyası kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Resmi Griye Çevirme Fonksiyonu
        private Bitmap ConvertToGrayScale(Bitmap original)
        {
            Bitmap newGrayImage = new Bitmap(original.Width, original.Height);

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color oldPixel = original.GetPixel(x, y);
                    // Ortalama algoritması: (R + G + B) / 3
                    int grayValue = (oldPixel.R + oldPixel.G + oldPixel.B) / 3;
                    Color newPixel = Color.FromArgb(grayValue, grayValue, grayValue);
                    newGrayImage.SetPixel(x, y, newPixel);
                }
            }
            return newGrayImage;
        }
    }
}