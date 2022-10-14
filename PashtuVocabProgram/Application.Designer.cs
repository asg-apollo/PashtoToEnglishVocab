namespace PashtoVocabProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPashtuWord = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.userInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pashtu to English Vocab";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPashtuWord
            // 
            this.lblPashtuWord.AutoSize = true;
            this.lblPashtuWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPashtuWord.Location = new System.Drawing.Point(12, 158);
            this.lblPashtuWord.Name = "lblPashtuWord";
            this.lblPashtuWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPashtuWord.Size = new System.Drawing.Size(101, 20);
            this.lblPashtuWord.TabIndex = 1;
            this.lblPashtuWord.Text = "Pashtu Word";
            // 
            // picItem
            // 
            this.picItem.Location = new System.Drawing.Point(119, 158);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(135, 130);
            this.picItem.TabIndex = 2;
            this.picItem.TabStop = false;
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(272, 158);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(100, 20);
            this.userInput.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(272, 198);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 31);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 350);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.picItem);
            this.Controls.Add(this.lblPashtuWord);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pashto to English Vocab";
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPashtuWord;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button btnSubmit;
    }
}

