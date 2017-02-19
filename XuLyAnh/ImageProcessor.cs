using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyAnh
{
    class ImageProcessor
    {
        public static Bitmap ToGray(Bitmap img)
        {
            Bitmap newImg = new Bitmap(img);
            int i, j;
            Color color;
            Byte gray;

            for (i = 0; i < newImg.Width; i++)
            {
                for (j = 0; j < newImg.Height; j++)
                {
                    color = newImg.GetPixel(i, j);
                    gray = Convert.ToByte(color.R * 0.287 + color.G * 0.599 + color.B * 0.114);
                    newImg.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            return newImg;
        }

        public static Bitmap ToGray(Bitmap img, System.Windows.Forms.ProgressBar progressBar)
        {
            Bitmap newImg = new Bitmap(img);
            Color color;
            Byte gray;
            progressBar.Maximum = img.Width;

            for (int i = 0; i < newImg.Width; i++)
            {
                for (int j = 0; j < newImg.Height; j++)
                {
                    color = newImg.GetPixel(i, j);
                    gray = Convert.ToByte(color.R * 0.287 + color.G * 0.599 + color.B * 0.114);
                    newImg.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
                progressBar.Increment(1);
            }

            return newImg;
        }

        public static Bitmap TichChap(Bitmap img, int [,] boLoc, int m, int n)
        {
            Bitmap newImg = new Bitmap(img);
            //int x, y;
            Color color;
            Byte value;
            for (int x = 0; x < newImg.Width; x++)
            {
                for (int y = 0; y < newImg.Height; y++)
                {
                    
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            int pix1 = x - i;
                            int pix2 = y - j;
                            if (pix1 < 0) pix1 = 0;
                            if (pix2 < 0) pix2 = 0;
                            if (pix1 > newImg.Width) pix1 = newImg.Width;
                            if (pix2 > newImg.Height) pix2 = newImg.Height;
                            color = newImg.GetPixel(pix1, pix2);
                            value = Convert.ToByte(boLoc[i, j] * (color.R + color.G + color.B));
                        }
                    }
                }
            }

            return newImg;
        }
    }
}
