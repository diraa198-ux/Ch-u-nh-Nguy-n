namespace SaiLam
{
    partial class BaiTap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaiTap));
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuNew = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            mnuSave = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuFormat = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            cmbFonts = new ToolStripComboBox();
            cmbSize = new ToolStripComboBox();
            btnBold = new ToolStripButton();
            btnItalic = new ToolStripButton();
            btnUnderline = new ToolStripButton();
            btnNew = new ToolStripButton();
            richText = new RichTextBox();
            statusStrip1 = new StatusStrip();
            lblWordCount = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuFormat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuNew, mnuOpen, mnuSave, mnuExit });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(85, 24);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuNew
            // 
            mnuNew.Name = "mnuNew";
            mnuNew.ShortcutKeys = Keys.Control | Keys.N;
            mnuNew.Size = new Size(285, 26);
            mnuNew.Text = "Tạo văn bản mới";
            mnuNew.Click += mnuNew_Click;
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.Size = new Size(285, 26);
            mnuOpen.Text = "Mở tập tin";
            mnuOpen.Click += mnuOpen_Click;
            // 
            // mnuSave
            // 
            mnuSave.Name = "mnuSave";
            mnuSave.ShortcutKeys = Keys.Control | Keys.S;
            mnuSave.Size = new Size(285, 26);
            mnuSave.Text = "Lưu nội dung văn bản";
            mnuSave.Click += mnuSave_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(285, 26);
            mnuExit.Text = "Thoát";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuFormat
            // 
            mnuFormat.Name = "mnuFormat";
            mnuFormat.Size = new Size(92, 24);
            mnuFormat.Text = "Định dạng";
            mnuFormat.Click += mnuFormat_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, saveToolStripButton, cmbFonts, cmbSize, btnBold, btnItalic, btnUnderline, btnNew });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(29, 25);
            newToolStripButton.Text = "&New";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(29, 25);
            saveToolStripButton.Text = "&Save";
            // 
            // cmbFonts
            // 
            cmbFonts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFonts.Name = "cmbFonts";
            cmbFonts.Size = new Size(200, 28);
            cmbFonts.SelectedIndexChanged += cmbFonts_SelectedIndexChanged;
            // 
            // cmbSize
            // 
            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(75, 28);
            cmbSize.SelectedIndexChanged += cmbSize_SelectedIndexChanged;
            // 
            // btnBold
            // 
            btnBold.CheckOnClick = true;
            btnBold.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(29, 25);
            btnBold.Text = "B";
            btnBold.Click += btnBold_Click;
            // 
            // btnItalic
            // 
            btnItalic.CheckOnClick = true;
            btnItalic.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(29, 25);
            btnItalic.Text = "I";
            btnItalic.Click += btnItalic_Click;
            // 
            // btnUnderline
            // 
            btnUnderline.CheckOnClick = true;
            btnUnderline.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(29, 25);
            btnUnderline.Text = "U";
            btnUnderline.Click += btnUnderline_Click;
            // 
            // btnNew
            // 
            btnNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNew.ImageTransparentColor = Color.Magenta;
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(29, 25);
            btnNew.Text = "New";
            btnNew.Click += btnNew_Click;
            // 
            // richText
            // 
            richText.Dock = DockStyle.Fill;
            richText.Location = new Point(0, 56);
            richText.Name = "richText";
            richText.Size = new Size(800, 391);
            richText.TabIndex = 2;
            richText.Text = "";
            richText.TextChanged += richText_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblWordCount });
            statusStrip1.Location = new Point(0, 447);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblWordCount
            // 
            lblWordCount.Name = "lblWordCount";
            lblWordCount.Size = new Size(95, 20);
            lblWordCount.Text = "Tổng số từ: 0";
            // 
            // BaiTap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(richText);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);
            MainMenuStrip = menuStrip1;
            Name = "BaiTap";
            Text = "Soạn thảo văn bản";
            Load += BaiTap_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuSave;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuFormat;
        private ToolStrip toolStrip1;
        private ToolStripButton btnNew;
        private ToolStripComboBox cmbFonts;
        private ToolStripComboBox cmbSize;
        private ToolStripButton btnBold;
        private ToolStripButton btnItalic;
        private ToolStripButton btnUnderline;
        private RichTextBox richText;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblWordCount;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton newToolStripButton;
    }
}
