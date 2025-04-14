namespace RegexLab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtRegex = new TextBox();
            txtInputText = new TextBox();
            btnTest = new Button();
            txtOutputText = new TextBox();
            btnClear = new Button();
            lblMatchCount = new Label();
            btnSavePattern = new Button();
            rbtnDefault = new RadioButton();
            rbtnCustom = new RadioButton();
            cmbPatterns = new ComboBox();
            mainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            menuOpenFile = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ediToolStripMenuItem = new ToolStripMenuItem();
            menuUndo = new ToolStripMenuItem();
            menuCut = new ToolStripMenuItem();
            menuCopy = new ToolStripMenuItem();
            menuPaste = new ToolStripMenuItem();
            menuSelectAll = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            menuDarkTheme = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuDuplicateFilter = new ToolStripMenuItem();
            menuSortAlphabetically = new ToolStripMenuItem();
            menuTrimSpaces = new ToolStripMenuItem();
            menuIgnoreCase = new ToolStripMenuItem();
            libraryToolStripMenuItem = new ToolStripMenuItem();
            customPatternsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            howToUseToolStripMenuItem = new ToolStripMenuItem();
            regexReferenceToolStripMenuItem = new ToolStripMenuItem();
            aboutRegexLabToolStripMenuItem = new ToolStripMenuItem();
            checkForUpdatesToolStripMenuItem = new ToolStripMenuItem();
            contactFeedbackToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            lblPatternInfo = new Label();
            splitContainer1 = new SplitContainer();
            menuExportOptions = new ContextMenuStrip(components);
            menuExportSave = new ToolStripMenuItem();
            menuExportCopy = new ToolStripMenuItem();
            btnExport = new Button();
            versionInfo = new Label();
            mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuExportOptions.SuspendLayout();
            SuspendLayout();
            // 
            // txtRegex
            // 
            txtRegex.Location = new Point(12, 39);
            txtRegex.Name = "txtRegex";
            txtRegex.Size = new Size(465, 27);
            txtRegex.TabIndex = 0;
            // 
            // txtInputText
            // 
            txtInputText.Dock = DockStyle.Fill;
            txtInputText.Location = new Point(0, 0);
            txtInputText.Multiline = true;
            txtInputText.Name = "txtInputText";
            txtInputText.ScrollBars = ScrollBars.Vertical;
            txtInputText.Size = new Size(564, 627);
            txtInputText.TabIndex = 50;
            txtInputText.WordWrap = false;
            // 
            // btnTest
            // 
            btnTest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTest.Font = new Font("Arial", 15F);
            btnTest.Location = new Point(449, 707);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(270, 46);
            btnTest.TabIndex = 2;
            btnTest.Text = "RUN";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // txtOutputText
            // 
            txtOutputText.Dock = DockStyle.Fill;
            txtOutputText.Location = new Point(0, 0);
            txtOutputText.Multiline = true;
            txtOutputText.Name = "txtOutputText";
            txtOutputText.ReadOnly = true;
            txtOutputText.ScrollBars = ScrollBars.Vertical;
            txtOutputText.Size = new Size(554, 627);
            txtOutputText.TabIndex = 51;
            txtOutputText.WordWrap = false;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.Location = new Point(948, 707);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 35);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblMatchCount
            // 
            lblMatchCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMatchCount.AutoSize = true;
            lblMatchCount.Location = new Point(12, 705);
            lblMatchCount.Name = "lblMatchCount";
            lblMatchCount.Size = new Size(71, 20);
            lblMatchCount.TabIndex = 8;
            lblMatchCount.Text = "Matches: ";
            // 
            // btnSavePattern
            // 
            btnSavePattern.Location = new Point(479, 39);
            btnSavePattern.Name = "btnSavePattern";
            btnSavePattern.Size = new Size(97, 28);
            btnSavePattern.TabIndex = 9;
            btnSavePattern.Text = "Save Pattern";
            btnSavePattern.UseVisualStyleBackColor = true;
            btnSavePattern.Click += btnSavePattern_Click;
            // 
            // rbtnDefault
            // 
            rbtnDefault.AutoSize = true;
            rbtnDefault.Checked = true;
            rbtnDefault.Location = new Point(974, 42);
            rbtnDefault.Name = "rbtnDefault";
            rbtnDefault.Size = new Size(79, 24);
            rbtnDefault.TabIndex = 10;
            rbtnDefault.TabStop = true;
            rbtnDefault.Text = "Default";
            rbtnDefault.UseVisualStyleBackColor = true;
            rbtnDefault.CheckedChanged += rbtnDefault_CheckedChanged;
            // 
            // rbtnCustom
            // 
            rbtnCustom.AutoSize = true;
            rbtnCustom.Location = new Point(1059, 42);
            rbtnCustom.Name = "rbtnCustom";
            rbtnCustom.Size = new Size(80, 24);
            rbtnCustom.TabIndex = 11;
            rbtnCustom.Text = "Custom";
            rbtnCustom.UseVisualStyleBackColor = true;
            rbtnCustom.CheckedChanged += rbtnCustom_CheckedChanged;
            // 
            // cmbPatterns
            // 
            cmbPatterns.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatterns.FormattingEnabled = true;
            cmbPatterns.ImeMode = ImeMode.NoControl;
            cmbPatterns.Location = new Point(584, 39);
            cmbPatterns.MaxDropDownItems = 10;
            cmbPatterns.Name = "cmbPatterns";
            cmbPatterns.Size = new Size(352, 28);
            cmbPatterns.TabIndex = 12;
            cmbPatterns.SelectedIndexChanged += cmbPatterns_SelectedIndexChanged;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(20, 20);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, ediToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem, libraryToolStripMenuItem, helpToolStripMenuItem1 });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(1152, 28);
            mainMenuStrip.TabIndex = 14;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuOpenFile, saveAsToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // menuOpenFile
            // 
            menuOpenFile.Name = "menuOpenFile";
            menuOpenFile.Size = new Size(143, 26);
            menuOpenFile.Text = "Open";
            menuOpenFile.Click += menuOpenFile_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(143, 26);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(140, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(143, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // ediToolStripMenuItem
            // 
            ediToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuUndo, menuCut, menuCopy, menuPaste, menuSelectAll });
            ediToolStripMenuItem.Name = "ediToolStripMenuItem";
            ediToolStripMenuItem.Size = new Size(49, 24);
            ediToolStripMenuItem.Text = "Edit";
            // 
            // menuUndo
            // 
            menuUndo.Name = "menuUndo";
            menuUndo.Size = new Size(154, 26);
            menuUndo.Text = "Undo";
            menuUndo.Click += menuUndo_Click;
            // 
            // menuCut
            // 
            menuCut.Name = "menuCut";
            menuCut.Size = new Size(154, 26);
            menuCut.Text = "Cut";
            menuCut.Click += menuCut_Click;
            // 
            // menuCopy
            // 
            menuCopy.Name = "menuCopy";
            menuCopy.Size = new Size(154, 26);
            menuCopy.Text = "Copy";
            menuCopy.Click += menuCopy_Click;
            // 
            // menuPaste
            // 
            menuPaste.Name = "menuPaste";
            menuPaste.Size = new Size(154, 26);
            menuPaste.Text = "Paste";
            menuPaste.Click += menuPaste_Click;
            // 
            // menuSelectAll
            // 
            menuSelectAll.Name = "menuSelectAll";
            menuSelectAll.Size = new Size(154, 26);
            menuSelectAll.Text = "Select All";
            menuSelectAll.Click += menuSelectAll_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuDarkTheme });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // menuDarkTheme
            // 
            menuDarkTheme.CheckOnClick = true;
            menuDarkTheme.Name = "menuDarkTheme";
            menuDarkTheme.Size = new Size(172, 26);
            menuDarkTheme.Text = "Dark Theme";
            menuDarkTheme.CheckedChanged += menuDarkTheme_CheckedChanged;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuDuplicateFilter, menuSortAlphabetically, menuTrimSpaces, menuIgnoreCase });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(58, 24);
            helpToolStripMenuItem.Text = "Tools";
            // 
            // menuDuplicateFilter
            // 
            menuDuplicateFilter.CheckOnClick = true;
            menuDuplicateFilter.Name = "menuDuplicateFilter";
            menuDuplicateFilter.Size = new Size(193, 26);
            menuDuplicateFilter.Text = "Dublicate Filter";
            // 
            // menuSortAlphabetically
            // 
            menuSortAlphabetically.CheckOnClick = true;
            menuSortAlphabetically.Name = "menuSortAlphabetically";
            menuSortAlphabetically.Size = new Size(193, 26);
            menuSortAlphabetically.Text = "Sort A-Z";
            // 
            // menuTrimSpaces
            // 
            menuTrimSpaces.CheckOnClick = true;
            menuTrimSpaces.Name = "menuTrimSpaces";
            menuTrimSpaces.Size = new Size(193, 26);
            menuTrimSpaces.Text = "Trim Spaces";
            // 
            // menuIgnoreCase
            // 
            menuIgnoreCase.CheckOnClick = true;
            menuIgnoreCase.Name = "menuIgnoreCase";
            menuIgnoreCase.Size = new Size(193, 26);
            menuIgnoreCase.Text = "Ignore Case";
            // 
            // libraryToolStripMenuItem
            // 
            libraryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customPatternsToolStripMenuItem });
            libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            libraryToolStripMenuItem.Size = new Size(68, 24);
            libraryToolStripMenuItem.Text = "Library";
            // 
            // customPatternsToolStripMenuItem
            // 
            customPatternsToolStripMenuItem.Name = "customPatternsToolStripMenuItem";
            customPatternsToolStripMenuItem.Size = new Size(198, 26);
            customPatternsToolStripMenuItem.Text = "Custom Patterns";
            customPatternsToolStripMenuItem.Click += customPatternsToolStripMenuItem_Click_1;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { howToUseToolStripMenuItem, regexReferenceToolStripMenuItem, aboutRegexLabToolStripMenuItem, checkForUpdatesToolStripMenuItem, contactFeedbackToolStripMenuItem });
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(55, 24);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            howToUseToolStripMenuItem.Size = new Size(213, 26);
            howToUseToolStripMenuItem.Text = "How to Use";
            howToUseToolStripMenuItem.Click += menuHowToUse_Click;
            // 
            // regexReferenceToolStripMenuItem
            // 
            regexReferenceToolStripMenuItem.Name = "regexReferenceToolStripMenuItem";
            regexReferenceToolStripMenuItem.Size = new Size(213, 26);
            regexReferenceToolStripMenuItem.Text = "Regex Reference";
            regexReferenceToolStripMenuItem.Click += menuRegexReference_Click;
            // 
            // aboutRegexLabToolStripMenuItem
            // 
            aboutRegexLabToolStripMenuItem.Name = "aboutRegexLabToolStripMenuItem";
            aboutRegexLabToolStripMenuItem.Size = new Size(213, 26);
            aboutRegexLabToolStripMenuItem.Text = "Github";
            aboutRegexLabToolStripMenuItem.Click += menuGitHub_Click;
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            checkForUpdatesToolStripMenuItem.Size = new Size(213, 26);
            checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            checkForUpdatesToolStripMenuItem.Click += menuCheckForUpdates_Click;
            // 
            // contactFeedbackToolStripMenuItem
            // 
            contactFeedbackToolStripMenuItem.Name = "contactFeedbackToolStripMenuItem";
            contactFeedbackToolStripMenuItem.Size = new Size(213, 26);
            contactFeedbackToolStripMenuItem.Text = "About RegexLab";
            contactFeedbackToolStripMenuItem.Click += menuAbout_Click;
            // 
            // lblPatternInfo
            // 
            lblPatternInfo.AutoSize = true;
            lblPatternInfo.BorderStyle = BorderStyle.Fixed3D;
            lblPatternInfo.Cursor = Cursors.Help;
            lblPatternInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPatternInfo.Location = new Point(939, 40);
            lblPatternInfo.Margin = new Padding(0);
            lblPatternInfo.Name = "lblPatternInfo";
            lblPatternInfo.Padding = new Padding(2, 0, 0, 0);
            lblPatternInfo.Size = new Size(24, 27);
            lblPatternInfo.TabIndex = 15;
            lblPatternInfo.Text = "?";
            lblPatternInfo.MouseHover += lblPatternInfo_MouseHover;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Location = new Point(12, 73);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtInputText);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtOutputText);
            splitContainer1.Size = new Size(1127, 629);
            splitContainer1.SplitterDistance = 566;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 1;
            // 
            // menuExportOptions
            // 
            menuExportOptions.ImageScalingSize = new Size(20, 20);
            menuExportOptions.Items.AddRange(new ToolStripItem[] { menuExportSave, menuExportCopy });
            menuExportOptions.Name = "menuExportOptions";
            menuExportOptions.Size = new Size(201, 52);
            // 
            // menuExportSave
            // 
            menuExportSave.Name = "menuExportSave";
            menuExportSave.Size = new Size(200, 24);
            menuExportSave.Text = "Save As";
            menuExportSave.Click += menuExportSave_Click;
            // 
            // menuExportCopy
            // 
            menuExportCopy.Name = "menuExportCopy";
            menuExportCopy.Size = new Size(200, 24);
            menuExportCopy.Text = "Copy to Clipboard";
            menuExportCopy.Click += menuExportCopy_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(1044, 707);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(96, 35);
            btnExport.TabIndex = 18;
            btnExport.Text = "Export ▼";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // versionInfo
            // 
            versionInfo.AutoSize = true;
            versionInfo.Font = new Font("Segoe UI", 7F);
            versionInfo.ForeColor = SystemColors.GrayText;
            versionInfo.Location = new Point(3, 745);
            versionInfo.Name = "versionInfo";
            versionInfo.Size = new Size(37, 15);
            versionInfo.TabIndex = 19;
            versionInfo.Text = "v1.1.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 763);
            Controls.Add(versionInfo);
            Controls.Add(btnExport);
            Controls.Add(splitContainer1);
            Controls.Add(lblPatternInfo);
            Controls.Add(cmbPatterns);
            Controls.Add(rbtnCustom);
            Controls.Add(rbtnDefault);
            Controls.Add(btnSavePattern);
            Controls.Add(lblMatchCount);
            Controls.Add(btnClear);
            Controls.Add(btnTest);
            Controls.Add(txtRegex);
            Controls.Add(mainMenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenuStrip;
            MaximizeBox = false;
            Name = "Form1";
            Text = "RegexLab -  Regex Test and Pattern Library Tool";
            Load += Form1_Load;
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuExportOptions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRegex;
        private TextBox txtInputText;
        private Button btnTest;
        private TextBox txtOutputText;
        private Button btnClear;
        private Label lblMatchCount;
        private Button btnSavePattern;
        private RadioButton rbtnDefault;
        private RadioButton rbtnCustom;
        private ComboBox cmbPatterns;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuOpenFile;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem ediToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolTip toolTip1;
        private Label lblPatternInfo;
        private ToolStripMenuItem menuDuplicateFilter;
        private ToolStripMenuItem menuSortAlphabetically;
        private ToolStripMenuItem menuTrimSpaces;
        private ToolStripMenuItem menuIgnoreCase;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem menuDarkTheme;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem menuUndo;
        private ToolStripMenuItem menuCut;
        private ToolStripMenuItem menuCopy;
        private ToolStripMenuItem menuPaste;
        private ToolStripMenuItem menuSelectAll;
        private ToolStripMenuItem howToUseToolStripMenuItem;
        private ToolStripMenuItem regexReferenceToolStripMenuItem;
        private ToolStripMenuItem aboutRegexLabToolStripMenuItem;
        private ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private ToolStripMenuItem contactFeedbackToolStripMenuItem;
        private SplitContainer splitContainer1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem libraryToolStripMenuItem;
        private ToolStripMenuItem customPatternsToolStripMenuItem;
        private ContextMenuStrip menuExportOptions;
        private ToolStripMenuItem menuExportSave;
        private ToolStripMenuItem menuExportCopy;
        private Button btnExport;
        private Label versionInfo;
    }
}
