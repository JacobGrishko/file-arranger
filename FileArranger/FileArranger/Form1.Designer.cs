namespace FileArranger
{
    partial class Form1
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
            this.btnFolder = new System.Windows.Forms.Button();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbSub = new System.Windows.Forms.CheckBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.Label();
            this.cbSortType = new System.Windows.Forms.ComboBox();
            this.lbSortKind = new System.Windows.Forms.Label();
            this.lbVer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(270, 11);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(146, 20);
            this.btnFolder.TabIndex = 0;
            this.btnFolder.Text = "Choose folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(12, 12);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(243, 20);
            this.tbFolder.TabIndex = 1;
            this.tbFolder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(12, 128);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutput.Size = new System.Drawing.Size(404, 227);
            this.tbOutput.TabIndex = 2;
            this.tbOutput.TextChanged += new System.EventHandler(this.txOutput_TextChanged);
            // 
            // btnSort
            // 
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSort.Location = new System.Drawing.Point(270, 41);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(146, 70);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbSub
            // 
            this.cbSub.AutoSize = true;
            this.cbSub.Location = new System.Drawing.Point(15, 94);
            this.cbSub.Name = "cbSub";
            this.cbSub.Size = new System.Drawing.Size(113, 17);
            this.cbSub.TabIndex = 4;
            this.cbSub.Text = "also subdirectories";
            this.cbSub.UseVisualStyleBackColor = true;
            this.cbSub.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "All files",
            ".txt",
            ".pdf",
            ".docx",
            ".jpg",
            ".jpeg",
            ".png",
            ".webp",
            ".tiff",
            ".bmp",
            ".ai",
            ".psd",
            ".bmp",
            ".gif",
            ".mp4",
            ".mov",
            ".wmv",
            ".flv",
            ".avi",
            ".avchd",
            ".webm",
            ".mkv"});
            this.cbType.Location = new System.Drawing.Point(103, 41);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(152, 21);
            this.cbType.TabIndex = 5;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(10, 41);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(34, 13);
            this.lbType.TabIndex = 6;
            this.lbType.Text = "Type:";
            // 
            // cbSortType
            // 
            this.cbSortType.FormattingEnabled = true;
            this.cbSortType.Items.AddRange(new object[] {
            "Date(Year and Month)"});
            this.cbSortType.Location = new System.Drawing.Point(103, 64);
            this.cbSortType.Name = "cbSortType";
            this.cbSortType.Size = new System.Drawing.Size(152, 21);
            this.cbSortType.TabIndex = 7;
            // 
            // lbSortKind
            // 
            this.lbSortKind.AutoSize = true;
            this.lbSortKind.Location = new System.Drawing.Point(12, 64);
            this.lbSortKind.Name = "lbSortKind";
            this.lbSortKind.Size = new System.Drawing.Size(43, 13);
            this.lbSortKind.TabIndex = 8;
            this.lbSortKind.Text = "Sort by:";
            // 
            // lbVer
            // 
            this.lbVer.AutoSize = true;
            this.lbVer.Location = new System.Drawing.Point(380, 362);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(23, 13);
            this.lbVer.TabIndex = 9;
            this.lbVer.Text = "V.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(428, 382);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.lbSortKind);
            this.Controls.Add(this.cbSortType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbSub);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.btnFolder);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "File Arranger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.CheckBox cbSub;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbSortType;
        private System.Windows.Forms.Label lbSortKind;
        private System.Windows.Forms.Label lbVer;
    }
}

