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

            for (int i = 0; i < newImg.Width; i+=1)
            {
                for (int j = 0; j < newImg.Height; j+=1)
                {
                    color = newImg.GetPixel(i, j);
                    gray = Convert.ToByte(color.R * 0.333 + color.G * 0.333 + color.B * 0.333);
                    newImg.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
                progressBar.Increment(1);
            }
            
            return newImg;
        }

        public static Bitmap ToBlackWhite(Bitmap img, System.Windows.Forms.ProgressBar progressBar)
        {
            Bitmap newImg = new Bitmap(img);
            Color color;
            Byte gray;
            progressBar.Maximum = img.Width;

            for (int i = 0; i < newImg.Width; i+=1)
            {
                for (int j = 0; j < newImg.Height; j+=1)
                {
                    color = newImg.GetPixel(i, j);
                    gray = Convert.ToByte(color.R * 0.287 + color.G * 0.599 + color.B * 0.114);
                    if (gray >= 128) gray = 255;
                    else gray = 0;
                    newImg.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
                progressBar.Increment(1);
            }

            return newImg;
        }

        public static Bitmap TichChap(Bitmap img)
        {
            Bitmap GrayIMG = ToGray(img);
            float[,] boloc = BoLoc3x3();

            for (int x = 1; x < GrayIMG.Width-1; x++)
            {
                for (int y = 0; y < GrayIMG.Height-1; y++)
                {
                    //Byte doXam = getDoXamPixel(GrayIMG, x, y);
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                           // setDoXamPixel(GrayIMG, x, y, doXam);
                        }
                    }
                }
            }

            return GrayIMG;
        }

        private static float[,] BoLoc3x3()
        {
            float[,] boloc = new float[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boloc[i, j] = 1 / 9;
                }
            }

            return boloc;
        }

        private static byte getDoXamPixel(Bitmap grayIMG, int x, int y)
        {
            throw new NotImplementedException();
        }

    }
}
