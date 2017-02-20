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
            Bitmap GrayIMG = ToGray(img);
            float[,] boloc = BoLoc3x3();
            //float thisDoXam;

            for (int x = 2; x < GrayIMG.Width; x++)
            {
                for (int y = 2; y < GrayIMG.Height; y++)
                {
                    float gray = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            gray += boloc[k, l] * GrayIMG.GetPixel(x - k, y - l).R;
                        }
                    }

                    Byte newG = Convert.ToByte(gray/9);
                    Color newC = Color.FromArgb(newG,newG,newG);
                    GrayIMG.SetPixel(x, y, newC);
                }
            }

            return GrayIMG;
        }

        public static Bitmap TichChap(Bitmap img, System.Windows.Forms.ProgressBar progressBar)
        {
            Bitmap GrayIMG = img;
            float[,] boloc = BoLoc3x3();
            progressBar.Maximum = GrayIMG.Width;

            for (int x = 2; x < GrayIMG.Width; x++)
            {
                for (int y = 2; y < GrayIMG.Height; y++)
                {
                    float gray = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            gray += boloc[k, l] * GrayIMG.GetPixel(x - k, y - l).R;
                        }
                    }

                    Byte newG = Convert.ToByte(gray / 9);
                    Color newC = Color.FromArgb(newG, newG, newG);
                    GrayIMG.SetPixel(x, y, newC);
                }
                try { progressBar.Increment(1); } catch { }
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
                    boloc[i, j] = 1;
                }
            }

            return boloc;
        }
    }
}
