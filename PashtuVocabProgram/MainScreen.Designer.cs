namespace PashtoVocabProgram
{
    partial class MainScreen
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
            this.lblTitleEnglish = new System.Windows.Forms.Label();
            this.lblTitlePashto = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnHints = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlMainTitle = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.pnlHints = new System.Windows.Forms.Panel();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblWordExamples = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlMainTitle.SuspendLayout();
            this.pnlHints.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleEnglish
            // 
            this.lblTitleEnglish.AutoSize = true;
            this.lblTitleEnglish.Font = new System.Drawing.Font("Gill Sans MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEnglish.Location = new System.Drawing.Point(49, 18);
            this.lblTitleEnglish.Name = "lblTitleEnglish";
            this.lblTitleEnglish.Size = new System.Drawing.Size(308, 40);
            this.lblTitleEnglish.TabIndex = 1;
            this.lblTitleEnglish.Text = "Learn English! (Pashto Edition)";
            this.lblTitleEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitlePashto
            // 
            this.lblTitlePashto.AutoSize = true;
            this.lblTitlePashto.Font = new System.Drawing.Font("Gill Sans MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePashto.Location = new System.Drawing.Point(65, 69);
            this.lblTitlePashto.Name = "lblTitlePashto";
            this.lblTitlePashto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitlePashto.Size = new System.Drawing.Size(230, 47);
            this.lblTitlePashto.TabIndex = 2;
            this.lblTitlePashto.Text = "انګریزی زده کړه";
            this.lblTitlePashto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Gray;
            this.btnHelp.Font = new System.Drawing.Font("Gill Sans MT Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(257, 221);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHelp.Size = new System.Drawing.Size(99, 57);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "مرسته";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnHints
            // 
            this.btnHints.BackColor = System.Drawing.Color.Gray;
            this.btnHints.Font = new System.Drawing.Font("Gill Sans MT Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHints.Location = new System.Drawing.Point(257, 158);
            this.btnHints.Name = "btnHints";
            this.btnHints.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHints.Size = new System.Drawing.Size(102, 57);
            this.btnHints.TabIndex = 4;
            this.btnHints.Text = "Hints";
            this.btnHints.UseVisualStyleBackColor = false;
            this.btnHints.Click += new System.EventHandler(this.btnHints_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Gray;
            this.btnPlay.Font = new System.Drawing.Font("Gill Sans MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(101, 176);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(151, 83);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnlMainTitle
            // 
            this.pnlMainTitle.Controls.Add(this.cmbCategory);
            this.pnlMainTitle.Controls.Add(this.btnPlay);
            this.pnlMainTitle.Controls.Add(this.btnHints);
            this.pnlMainTitle.Controls.Add(this.btnHelp);
            this.pnlMainTitle.Controls.Add(this.lblTitleEnglish);
            this.pnlMainTitle.Controls.Add(this.lblTitlePashto);
            this.pnlMainTitle.Location = new System.Drawing.Point(378, 12);
            this.pnlMainTitle.Name = "pnlMainTitle";
            this.pnlMainTitle.Size = new System.Drawing.Size(360, 327);
            this.pnlMainTitle.TabIndex = 6;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(116, 265);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 6;
            this.cmbCategory.Text = "Select Category";
            this.cmbCategory.SelectedValueChanged += new System.EventHandler(this.checkCmbValue);
            // 
            // pnlHints
            // 
            this.pnlHints.Controls.Add(this.btnBack);
            this.pnlHints.Controls.Add(this.lblWords);
            this.pnlHints.Controls.Add(this.lblWordExamples);
            this.pnlHints.Location = new System.Drawing.Point(12, 12);
            this.pnlHints.Name = "pnlHints";
            this.pnlHints.Size = new System.Drawing.Size(360, 327);
            this.pnlHints.TabIndex = 7;
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Font = new System.Drawing.Font("Gill Sans MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWords.Location = new System.Drawing.Point(20, 70);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(51, 25);
            this.lblWords.TabIndex = 2;
            this.lblWords.Text = "WORDS";
            // 
            // lblWordExamples
            // 
            this.lblWordExamples.AutoSize = true;
            this.lblWordExamples.Font = new System.Drawing.Font("Gill Sans MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordExamples.Location = new System.Drawing.Point(20, 18);
            this.lblWordExamples.Name = "lblWordExamples";
            this.lblWordExamples.Size = new System.Drawing.Size(124, 29);
            this.lblWordExamples.TabIndex = 1;
            this.lblWordExamples.Text = "Word Examples";
            this.lblWordExamples.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Gill Sans MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(282, 265);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 59);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 351);
            this.Controls.Add(this.pnlHints);
            this.Controls.Add(this.pnlMainTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 390);
            this.MinimumSize = new System.Drawing.Size(400, 390);
            this.Name = "MainScreen";
            this.Text = "Home";
            this.pnlMainTitle.ResumeLayout(false);
            this.pnlMainTitle.PerformLayout();
            this.pnlHints.ResumeLayout(false);
            this.pnlHints.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleEnglish;
        private System.Windows.Forms.Label lblTitlePashto;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnHints;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel pnlMainTitle;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Panel pnlHints;
        private System.Windows.Forms.Label lblWordExamples;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Button btnBack;
    }
}