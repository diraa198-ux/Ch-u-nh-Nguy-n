using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace SaiLam
{
    public partial class BaiTap : Form
    {
        // Current file path (null = new, unsaved)
        private string currentFilePath = null;

        public BaiTap()
        {
            InitializeComponent();
        }

        private void BaiTap_Load(object sender, EventArgs e)
        {
            // Load installed fonts
            foreach (FontFamily ff in new InstalledFontCollection().Families)
            {
                cmbFonts.Items.Add(ff.Name);
            }

            // Common sizes
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int s in sizes)
                cmbSize.Items.Add(s.ToString());

            // Defaults
            cmbFonts.Text = "Tahoma";
            cmbSize.Text = "14";
            richText.Font = new Font("Tahoma", 14);

            UpdateWordCount();
        }

        // New document
        private void CreateNewDocument()
        {
            richText.Clear();
            currentFilePath = null;
            cmbFonts.Text = "Tahoma";
            cmbSize.Text = "14";
            richText.Font = new Font("Tahoma", 14);
            richText.ForeColor = Color.Black;
            btnBold.Checked = false;
            btnItalic.Checked = false;
            btnUnderline.Checked = false;
            UpdateWordCount();
            this.Text = "Soạn thảo văn bản - Untitled";
        }

        private void mnuNew_Click(object sender, EventArgs e) => CreateNewDocument();
        private void btnNew_Click(object sender, EventArgs e) => CreateNewDocument();

        // Open file .rtf or .txt
        private void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Rich Text Format|*.rtf|Text Files|*.txt|All Files|*.*";
            ofd.Title = "Mở tập tin";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (Path.GetExtension(ofd.FileName).ToLower() == ".rtf")
                        richText.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                    else
                        richText.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);

                    currentFilePath = ofd.FileName;
                    this.Text = "Soạn thảo văn bản - " + Path.GetFileName(currentFilePath);
                    UpdateWordCount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở file: " + ex.Message);
                }
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e) => OpenFile();
        private void btnOpen_Click(object sender, EventArgs e) => OpenFile();

        // Save
        private void SaveFile()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Rich Text Format|*.rtf";
                sfd.DefaultExt = "rtf";
                sfd.Title = "Lưu nội dung văn bản";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    richText.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                    currentFilePath = sfd.FileName;
                    this.Text = "Soạn thảo văn bản - " + Path.GetFileName(currentFilePath);
                    MessageBox.Show("Lưu văn bản thành công!", "Thông báo");
                }
            }
            else
            {
                try
                {
                    richText.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Lưu văn bản thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
                }
            }
        }

        private void mnuSave_Click(object sender, EventArgs e) => SaveFile();
        private void btnSave_Click(object sender, EventArgs e) => SaveFile();

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Font dialog via menu Định dạng
        private void mnuFormat_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDlg = new FontDialog())
            {
                fontDlg.ShowColor = true;
                fontDlg.Font = richText.SelectionFont ?? richText.Font;
                fontDlg.Color = richText.SelectionColor;

                if (fontDlg.ShowDialog() != DialogResult.Cancel)
                {
                    richText.SelectionFont = fontDlg.Font;
                    richText.SelectionColor = fontDlg.Color;
                }
            }
        }

        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFonts.SelectedItem == null) return;
            float size = richText.SelectionFont?.Size ?? 14f;
            richText.SelectionFont = new Font(cmbFonts.SelectedItem.ToString(), size);
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSize.SelectedItem == null) return;
            string fontName = richText.SelectionFont?.Name ?? "Tahoma";
            float size = float.Parse(cmbSize.SelectedItem.ToString());
            richText.SelectionFont = new Font(fontName, size);
        }

        private void btnBold_Click(object sender, EventArgs e) => ToggleFontStyle(FontStyle.Bold);
        private void btnItalic_Click(object sender, EventArgs e) => ToggleFontStyle(FontStyle.Italic);
        private void btnUnderline_Click(object sender, EventArgs e) => ToggleFontStyle(FontStyle.Underline);

        private void ToggleFontStyle(FontStyle style)
        {
            if (richText.SelectionFont == null) return;

            FontStyle current = richText.SelectionFont.Style;
            if (richText.SelectionFont.Style.HasFlag(style))
                current &= ~style;
            else
                current |= style;

            richText.SelectionFont = new Font(richText.SelectionFont, current);
        }

        private void UpdateWordCount()
        {
            string text = richText.Text.Trim();
            int count = 0;
            if (!string.IsNullOrEmpty(text))
            {
                string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                count = words.Length;
            }
            lblWordCount.Text = $"Tổng số từ: {count}";
        }

        private void richText_TextChanged(object sender, EventArgs e)
        {
            UpdateWordCount();
        }
    }
}
