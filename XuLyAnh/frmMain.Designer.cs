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
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.fdAnh = new System.Windows.Forms.OpenFileDialog();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnXuLyCongThucTichChap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(501, 378);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(75, 23);
            this.btnChonAnh.TabIndex = 0;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(12, 12);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(564, 360);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 1;
            this.picAnh.TabStop = false;
            // 
            // btnXuLyCongThucTichChap
            // 
            this.btnXuLyCongThucTichChap.Location = new System.Drawing.Point(12, 378);
            this.btnXuLyCongThucTichChap.Name = "btnXuLyCongThucTichChap";
            this.btnXuLyCongThucTichChap.Size = new System.Drawing.Size(75, 23);
            this.btnXuLyCongThucTichChap.TabIndex = 2;
            this.btnXuLyCongThucTichChap.Text = "Xử lý";
            this.btnXuLyCongThucTichChap.UseVisualStyleBackColor = true;
            this.btnXuLyCongThucTichChap.Click += new System.EventHandler(this.btnXuLyCongThucTichChap_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 413);
            this.Controls.Add(this.btnXuLyCongThucTichChap);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnChonAnh);
            this.Name = "frmMain";
            this.Text = "Xử lý ảnh";
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.OpenFileDialog fdAnh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnXuLyCongThucTichChap;
    }
}

