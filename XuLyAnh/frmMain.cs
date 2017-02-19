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
        bool flag;
        public frmMain()
        {
            InitializeComponent();
            flag = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All File (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                flag = true;
            }
        }

        private void buttonToGray_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                Bitmap bm = new Bitmap(pictureBox1.Image);
                pictureBox2.Image = ImageProcessor.ToGray(bm,progressBar1);
                progressBar1.Value = 0;
            }
        }

        private void buttonLuuAnh_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Bmp Files|*.bmp";
            if (save.ShowDialog() == DialogResult.OK)
                pictureBox2.Image.Save(save.FileName);
        }
    }
}
