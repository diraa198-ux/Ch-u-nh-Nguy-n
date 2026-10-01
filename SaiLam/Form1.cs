namespace SaiLam
{
    public partial class frmCha : Form
    {
        public frmCha()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // sử dụng dialog chuẩn để open file
            OpenFileDialog oFile = new OpenFileDialog();

            // chỉ cho phép những file *.bmp, *.jpeg
            oFile.Filter = "Bitmap file|*.bmp|JPEG file|*.jpg";

            if (oFile.ShowDialog() == DialogResult.OK) // hiển thị dialog
            {
                // tạo thể hiện form con và truyền tên file cần mở
                FrmCon1 frm = new FrmCon1(oFile.FileName);
                frm.MdiParent = this;   // khai báo form cha
                frm.Show();             // hiển thị ra màn hình
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Arrange MDI children in cascade
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Arrange MDI children horizontally
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Arrange MDI children vertically
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the main form (exit application)
            Close();
        }
    }
}
