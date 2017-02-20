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
                    gray = Convert.ToByte(color.R * 0.333 + color.G * 0.333 + color.B * 0.333);
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

        public static Bitmap TichChap(Bitmap img)
        {
            Bitmap GrayIMG = img;
            float[,] boloc = BoLoc3x3();
            //float thisDoXam;

            for (int x = 2; x < GrayIMG.Width; x++)
            {
                for (int y = 2; y < GrayIMG.Height; y++)
                {
                    float red = 0;
                    float green = 0;
                    float blue = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            red += boloc[k, l] * GrayIMG.GetPixel(x - k, y - l).R;
                            green += boloc[k, l] * GrayIMG.GetPixel(x - k, y - l).G;
                            blue += boloc[k, l] * GrayIMG.GetPixel(x - k, y - l).B;
                        }
                    }

                    Byte newR = Convert.ToByte(red / 9);
                    Byte newB = Convert.ToByte(blue / 9);
                    Byte newG = Convert.ToByte(green / 9);
                    Color newC = Color.FromArgb(newR, newG, newB);
                    GrayIMG.SetPixel(x, y, newC);
                }
            }

            return GrayIMG;
        }

        public static Bitmap TichChap(Bitmap bitmap, System.Windows.Forms.ProgressBar progressBar)
        {
            Bitmap img = new Bitmap(bitmap);
            float[,] boloc = BoLoc3x3();
            progressBar.Maximum = img.Width;

            for (int x = 2; x < img.Width; x++)
            {
                for (int y = 2; y < img.Height; y++)
                {
                    float red = 0;
                    float green = 0;
                    float blue = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            red += boloc[k, l] * float.Parse("" + img.GetPixel(x - k, y - l).R);
                            green += boloc[k, l] * float.Parse("" + img.GetPixel(x - k, y - l).G);
                            blue += boloc[k, l] * float.Parse("" + img.GetPixel(x - k, y - l).B);
                        }
                    }

                    Byte newR = Convert.ToByte(red);
                    Byte newB = Convert.ToByte(blue);
                    Byte newG = Convert.ToByte(green);
                    Color newC = Color.FromArgb(newR, newG, newB);
                    img.SetPixel(x, y, newC);
                }

                try { progressBar.Increment(1); } catch { }
            }

            return img;
        }

        private static float[,] BoLoc3x3()
        {
            float[,] boloc = new float[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boloc[i, j] = (float) 1/9;
                }
            }
            return boloc;
        }
    }
}
