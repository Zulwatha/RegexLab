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
            txtPatternDisplay = new TextBox();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtTags = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtPatternDisplay
            // 
            txtPatternDisplay.Location = new Point(42, 49);
            txtPatternDisplay.Name = "txtPatternDisplay";
            txtPatternDisplay.Size = new Size(375, 27);
            txtPatternDisplay.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(42, 122);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(375, 27);
            txtTitle.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(42, 196);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(375, 27);
            txtDescription.TabIndex = 2;
            // 
            // txtTags
            // 
            txtTags.Location = new Point(42, 268);
            txtTags.Name = "txtTags";
            txtTags.Size = new Size(375, 27);
            txtTags.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(119, 326);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(226, 45);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 26);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 5;
            label1.Text = "Regex Pattern";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 89);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 6;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 162);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 245);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 8;
            label4.Text = "Tags";
            // 
            // SavePatternForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 397);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtTags);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(txtPatternDisplay);
            Name = "SavePatternForm";
            Text = "Save Pattern";
            Load += SavePatternForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPatternDisplay;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtTags;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}