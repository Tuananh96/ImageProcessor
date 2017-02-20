namespace XuLyAnh
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChonAnh = new System.Windows.Forms.Button();
            this.buttonLuuAnh = new System.Windows.Forms.Button();
            this.buttonToGray = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDenTrang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChonAnh
            // 
            this.buttonChonAnh.Location = new System.Drawing.Point(560, 12);
            this.buttonChonAnh.Name = "buttonChonAnh";
            this.buttonChonAnh.Size = new System.Drawing.Size(94, 23);
            this.buttonChonAnh.TabIndex = 2;
            this.buttonChonAnh.Text = "Chọn ảnh";
            this.buttonChonAnh.UseVisualStyleBackColor = true;
            this.buttonChonAnh.Click += new System.EventHandler(this.buttonChonAnh_Click);
            // 
            // buttonLuuAnh
            // 
            this.buttonLuuAnh.Location = new System.Drawing.Point(660, 12);
            this.buttonLuuAnh.Name = "buttonLuuAnh";
            this.buttonLuuAnh.Size = new System.Drawing.Size(75, 23);
            this.buttonLuuAnh.TabIndex = 3;
            this.buttonLuuAnh.Text = "Lưu ảnh";
            this.buttonLuuAnh.UseVisualStyleBackColor = true;
            this.buttonLuuAnh.Click += new System.EventHandler(this.buttonLuuAnh_Click);
            // 
            // buttonToGray
            // 
            this.buttonToGray.Location = new System.Drawing.Point(22, 33);
            this.buttonToGray.Name = "buttonToGray";
            this.buttonToGray.Size = new System.Drawing.Size(133, 23);
            this.buttonToGray.TabIndex = 4;
            this.buttonToGray.Text = "Chuyển sang ảnh xám";
            this.buttonToGray.UseVisualStyleBackColor = true;
            this.buttonToGray.Click += new System.EventHandler(this.buttonToGray_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(560, 237);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(175, 12);
            this.progressBar1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 237);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(286, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 237);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(24, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDenTrang);
            this.groupBox1.Controls.Add(this.buttonToGray);
            this.groupBox1.Location = new System.Drawing.Point(560, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 190);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công cụ";
            // 
            // buttonDenTrang
            // 
            this.buttonDenTrang.Location = new System.Drawing.Point(22, 62);
            this.buttonDenTrang.Name = "buttonDenTrang";
            this.buttonDenTrang.Size = new System.Drawing.Size(133, 23);
            this.buttonDenTrang.TabIndex = 5;
            this.buttonDenTrang.Text = "Làm mờ ảnh (Tích chập)";
            this.buttonDenTrang.UseVisualStyleBackColor = true;
            this.buttonDenTrang.Click += new System.EventHandler(this.buttonDenTrang_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLuuAnh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonChonAnh);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonChonAnh;
        private System.Windows.Forms.Button buttonLuuAnh;
        private System.Windows.Forms.Button buttonToGray;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDenTrang;
    }
}