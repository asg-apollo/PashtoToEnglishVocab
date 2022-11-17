namespace PashtoVocabProgram
{
    partial class Game
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
            this.pnlGame = new System.Windows.Forms.Panel();
            this.btnSkip = new System.Windows.Forms.Button();
            this.lbl_Incorrect = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.userInput = new System.Windows.Forms.TextBox();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.lblPashtuWord = new System.Windows.Forms.Label();
            this.pnlWinScreen = new System.Windows.Forms.Panel();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblAmountCorrect = new System.Windows.Forms.Label();
            this.lblAmountIncorrect = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.pnlWinScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.btnSkip);
            this.pnlGame.Controls.Add(this.lbl_Incorrect);
            this.pnlGame.Controls.Add(this.lblCorrect);
            this.pnlGame.Controls.Add(this.btnSubmit);
            this.pnlGame.Controls.Add(this.userInput);
            this.pnlGame.Controls.Add(this.picItem);
            this.pnlGame.Controls.Add(this.lblPashtuWord);
            this.pnlGame.Location = new System.Drawing.Point(371, 12);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(360, 327);
            this.pnlGame.TabIndex = 8;
            // 
            // btnSkip
            // 
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(276, 285);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 29);
            this.btnSkip.TabIndex = 14;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // lbl_Incorrect
            // 
            this.lbl_Incorrect.AutoSize = true;
            this.lbl_Incorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Incorrect.Location = new System.Drawing.Point(4, 61);
            this.lbl_Incorrect.Name = "lbl_Incorrect";
            this.lbl_Incorrect.Size = new System.Drawing.Size(67, 17);
            this.lbl_Incorrect.TabIndex = 13;
            this.lbl_Incorrect.Text = "Incorrect:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(4, 39);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(58, 17);
            this.lblCorrect.TabIndex = 12;
            this.lblCorrect.Text = "Correct:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(251, 173);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 31);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(251, 133);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(100, 20);
            this.userInput.TabIndex = 10;
            // 
            // picItem
            // 
            this.picItem.Location = new System.Drawing.Point(99, 108);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(135, 130);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picItem.TabIndex = 9;
            this.picItem.TabStop = false;
            // 
            // lblPashtuWord
            // 
            this.lblPashtuWord.AutoSize = true;
            this.lblPashtuWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPashtuWord.Location = new System.Drawing.Point(5, 133);
            this.lblPashtuWord.Name = "lblPashtuWord";
            this.lblPashtuWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPashtuWord.Size = new System.Drawing.Size(138, 26);
            this.lblPashtuWord.TabIndex = 8;
            this.lblPashtuWord.Text = "Pashtu Word";
            // 
            // pnlWinScreen
            // 
            this.pnlWinScreen.Controls.Add(this.btnQuit);
            this.pnlWinScreen.Controls.Add(this.btnPlayAgain);
            this.pnlWinScreen.Controls.Add(this.lblAmountIncorrect);
            this.pnlWinScreen.Controls.Add(this.lblAmountCorrect);
            this.pnlWinScreen.Controls.Add(this.lblWin);
            this.pnlWinScreen.Location = new System.Drawing.Point(12, 12);
            this.pnlWinScreen.Name = "pnlWinScreen";
            this.pnlWinScreen.Size = new System.Drawing.Size(360, 327);
            this.pnlWinScreen.TabIndex = 9;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Gill Sans MT Condensed", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(100, 17);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(158, 54);
            this.lblWin.TabIndex = 0;
            this.lblWin.Text = "You did it!";
            // 
            // lblAmountCorrect
            // 
            this.lblAmountCorrect.AutoSize = true;
            this.lblAmountCorrect.Font = new System.Drawing.Font("Gill Sans MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountCorrect.Location = new System.Drawing.Point(82, 87);
            this.lblAmountCorrect.Name = "lblAmountCorrect";
            this.lblAmountCorrect.Size = new System.Drawing.Size(194, 29);
            this.lblAmountCorrect.TabIndex = 1;
            this.lblAmountCorrect.Text = "You got AMOUNT correct!";
            // 
            // lblAmountIncorrect
            // 
            this.lblAmountIncorrect.AutoSize = true;
            this.lblAmountIncorrect.Font = new System.Drawing.Font("Gill Sans MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountIncorrect.Location = new System.Drawing.Point(82, 136);
            this.lblAmountIncorrect.Name = "lblAmountIncorrect";
            this.lblAmountIncorrect.Size = new System.Drawing.Size(207, 29);
            this.lblAmountIncorrect.TabIndex = 2;
            this.lblAmountIncorrect.Text = "You got AMOUNT incorrect!";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPlayAgain.Font = new System.Drawing.Font("Gill Sans MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(124, 221);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(107, 36);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQuit.Font = new System.Drawing.Font("Gill Sans MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(124, 263);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(107, 36);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Game
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 351);
            this.Controls.Add(this.pnlWinScreen);
            this.Controls.Add(this.pnlGame);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 390);
            this.MinimumSize = new System.Drawing.Size(400, 390);
            this.Name = "Game";
            this.Text = "Pashto to English Vocab";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gameClosed);
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.pnlWinScreen.ResumeLayout(false);
            this.pnlWinScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Label lbl_Incorrect;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.Label lblPashtuWord;
        private System.Windows.Forms.Panel pnlWinScreen;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblAmountCorrect;
        private System.Windows.Forms.Label lblAmountIncorrect;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}

