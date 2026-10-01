using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SaiLam
{
    public partial class FrmCon1 : Form
    {
        // Constructor mặc định (giữ nguyên)
        public FrmCon1()
        {
            InitializeComponent();
        }

        // === THÊM CONSTRUCTOR NÀY VÀO ===
        public FrmCon1(string imageFile)
        {
            InitializeComponent();

            // Cho PictureBox hiển thị file ảnh
            pictureBox1.Image = Image.FromFile(imageFile);

            // Hiển thị tên file ảnh lên title bar
            Text = imageFile.Substring(imageFile.LastIndexOf('\\') + 1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}