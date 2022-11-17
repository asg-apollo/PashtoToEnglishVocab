// Developed by Ethan McKinnon (2022-11-17)

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace PashtoVocabProgram
{
    public partial class Game : Form
    {
        public string[] lines;
        public Dictionary<string, bool> answerDict = new Dictionary<string, bool>();
        public Dictionary<string, string> pashtoWords = new Dictionary<string, string>();
        public Dictionary<string, string> imagePaths = new Dictionary<string, string>();

        private int correctAnswers = 0;
        private int incorrectAnswers = 0;

        Random rnd = new Random();
        public int randomElement;

        Point panelPosition = new Point(12, 12);

        public Game(string categoryName)
        {
            InitializeComponent();
            lines = File.ReadAllLines("Categories\\" + categoryName);
            // Add english word to dictionary and mark it false
            if (lines == null || lines.Length == 0)
            {
                MessageBox.Show("This category is empty. Please add words to the category.");
                Application.Exit();
            }
            foreach (string line in lines)
            {
                
                
                string[] splitWords = line.Split(',');
                string englishWord = splitWords[1];
                string pashtoWord = splitWords[2];
                string imagePath = splitWords[0];
                answerDict.Add(englishWord, false);
                pashtoWords.Add(englishWord, pashtoWord);
                imagePaths.Add(englishWord, imagePath);
                
            }
            ResetVocab();
            pnlGame.Location = panelPosition;
            pnlGame.Show();
            pnlWinScreen.Location = new Point(panelPosition.X - 1, panelPosition.Y);
            pnlWinScreen.Hide();
        }

        private void ResetVocab()
        {
            if (!answerDict.ContainsValue(false))
            {
                ShowEndScreen();
                return;
            }
            randomElement = rnd.Next(answerDict.Count);
            KeyValuePair<string, bool> pair = answerDict.ElementAt(randomElement);
            if (pair.Value == true)
            {
                ResetVocab();
                return;
            }
            string englishWord = pair.Key;
            string pashtoWord = pashtoWords[englishWord];
            string imagePath = imagePaths[englishWord];
            imagePath = "Images\\" + imagePath;
            Debug.WriteLine(englishWord);


            if (imagePath.Contains(".png") || imagePath.Contains(".jpg"))
            {
                if (File.Exists(imagePath) == false)
                {
                    picItem.Image = null;
                }
                else
                {
                    Image img = Image.FromFile(imagePath);
                    picItem.Image = img;
                }
            }
            else
            {
                picItem.Image = null;
            }

            lblPashtuWord.Text = pashtoWord;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, bool> pair = answerDict.ElementAt(randomElement);
            string englishWord = pair.Key;
            if (userInput.Text == englishWord)
            {
                answerDict[englishWord] = true;
                btnSubmit.Enabled = false;
                btnSubmit.Text = "Correct!";
                correctAnswers += 1;
                lblCorrect.Text = "Correct: " + correctAnswers;
                Wait(3000);
                btnSubmit.Text = "Submit";
                btnSubmit.Enabled = true;
                userInput.Text = "";
                ResetVocab();
            }
            else
            {
                btnSubmit.Text = "Incorrect";
                incorrectAnswers += 1;
                lbl_Incorrect.Text = "Incorrect: " + incorrectAnswers;
                btnSubmit.Enabled = false;
                Wait(1000);
                btnSubmit.Enabled = true;
                userInput.Text = "";
                btnSubmit.Text = "Submit";
                ResetVocab();
            }

        }

        public void Wait(int milliseconds)
        {
            var timer1 = new Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }

        }

        public void ShowEndScreen()
        {
            pnlGame.Hide();
            pnlWinScreen.Show();
            lblAmountCorrect.Text = "You got " + correctAnswers + " correct!";
            lblAmountIncorrect.Text = "You got " + incorrectAnswers + " incorrect.";
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ResetVocab();
        }

        private void gameClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}