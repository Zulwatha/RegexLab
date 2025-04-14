namespace RegexLab
{
    partial class SavePatternForm
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
            label1 = new Label();
            btnSave = new Button();
            label2 = new Label();
            txtTags = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            txtTitle = new TextBox();
            btnUpdate = new Button();
            txtPatternDisplay = new TextBox();
            btnDelete = new Button();
            splitContainer1 = new SplitContainer();
            lstPatterns = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 5;
            label1.Text = "Regex Pattern";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(54, 307);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 41);
            btnSave.TabIndex = 4;
            btnSave.Text = "New";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 83);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 6;
            label2.Text = "Title";
            // 
            // txtTags
            // 
            txtTags.Location = new Point(28, 262);
            txtTags.Name = "txtTags";
            txtTags.Size = new Size(375, 27);
            txtTags.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 156);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(28, 190);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(375, 27);
            txtDescription.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 239);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 8;
            label4.Text = "Tags";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(28, 116);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(375, 27);
            txtTitle.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(165, 307);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 41);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPatternDisplay
            // 
            txtPatternDisplay.Location = new Point(28, 43);
            txtPatternDisplay.Name = "txtPatternDisplay";
            txtPatternDisplay.Size = new Size(375, 27);
            txtPatternDisplay.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(276, 307);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 41);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnDelete);
            splitContainer1.Panel1.Controls.Add(txtPatternDisplay);
            splitContainer1.Panel1.Controls.Add(btnUpdate);
            splitContainer1.Panel1.Controls.Add(txtTitle);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(txtDescription);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtTags);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(btnSave);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lstPatterns);
            splitContainer1.Size = new Size(944, 378);
            splitContainer1.SplitterDistance = 433;
            splitContainer1.TabIndex = 1;
            // 
            // lstPatterns
            // 
            lstPatterns.FormattingEnabled = true;
            lstPatterns.Location = new Point(12, 11);
            lstPatterns.Name = "lstPatterns";
            lstPatterns.Size = new Size(479, 364);
            lstPatterns.TabIndex = 0;
            lstPatterns.SelectedIndexChanged += lstPatterns_SelectedIndexChanged;
            // 
            // SavePatternForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 402);
            Controls.Add(splitContainer1);
            Name = "SavePatternForm";
            Text = "Pattern Library";
            Load += SavePatternForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private Label label2;
        private TextBox txtTags;
        private Label label3;
        private TextBox txtDescription;
        private Label label4;
        private TextBox txtTitle;
        private Button btnUpdate;
        private TextBox txtPatternDisplay;
        private Button btnDelete;
        private SplitContainer splitContainer1;
        private ListBox lstPatterns;
    }
}