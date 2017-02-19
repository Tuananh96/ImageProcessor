using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmMain : Form
    {
        Bitmap anh;
        bool flag;

        public frmMain()
        {
            InitializeComponent();
            flag = false;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            fdAnh.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            if (fdAnh.ShowDialog() == DialogResult.OK)
            {
                anh = new Bitmap(fdAnh.FileName);
                picAnh.Image = anh;
                flag = true;
            }
        }
        unsafe
        private void btnXuLyCongThucTichChap_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                BitmapData anh_Data = anh.LockBits(new Rectangle(0, 0, anh.Width, anh.Height), ImageLockMode.ReadWrite, anh.PixelFormat);
                int offset = anh_Data.Stride - anh.Width * 3;
                byte* p = (byte*)anh_Data.Scan0;

                for (int i = 0; i < anh.Width; i++)
                {
                    for (int j = 0; j < anh.Height; j++)
                    {
                        int t = (p[0] + p[1] + p[2]) / 3;
                        //BGR p0,p1,p2;
                        p[0] = (byte)t;
                        p[1] = (byte)t;
                        p[2] = (byte)t;

                        p += 3;
                    }
                    p += offset;
                }

                anh.UnlockBits(anh_Data);
                picAnh.Image = anh;
            }
            else MessageBox.Show("Chưa chọn ảnh.");
        }
    }
}
