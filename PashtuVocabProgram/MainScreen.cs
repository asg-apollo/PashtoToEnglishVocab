// Developed by Ethan McKinnon (2022-11-17)

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PashtoVocabProgram
{
    public partial class MainScreen : Form
    {
        public string selectedCategory;
        Random rnd = new Random();
        string[] lines;
        Point panelPosition = new Point(12, 12);
        List<string> finalizedWordList = new List<string>();

        public MainScreen()
        {
            InitializeComponent();
            GetCategories();
            btnPlay.Enabled = false;
            btnHints.Enabled = false;
            btnHints.BackColor = Color.Gray;
            btnPlay.BackColor = Color.Gray;
            pnlMainTitle.Location = panelPosition;
            pnlHints.Location = new Point(panelPosition.X - 1, panelPosition.Y);
            pnlHints.Hide();

        }

        private void GetCategories()
        {
            foreach(string category in Directory.GetFiles("Categories"))
            {
                if (category.Contains(".txt"))
                {
                    string wordCategory = category.Replace("Categories\\", "");
                    wordCategory = wordCategory.Replace(".txt", "");
                    cmbCategory.Items.Add(wordCategory);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHints_Click(object sender, EventArgs e)
        {
            int amountOfWords = 6;
            selectedCategory = cmbCategory.SelectedItem.ToString();
            selectedCategory = selectedCategory + ".txt";
            lblWordExamples.Text = "Word Examples for the category: " + selectedCategory;
            lines = File.ReadAllLines("Categories\\" + selectedCategory);
            if (lines == null || lines.Length == 0)
            {
                MessageBox.Show("This category is empty. Please add words to the category.");
                return;
            }
            pnlMainTitle.Hide();
            pnlHints.Show();
            lblWords.Text = "";
            if (lines.Length < 6)
            {
                amountOfWords = lines.Length;
            }
            else
            {
                amountOfWords = 6;
            }
            for (int i = 0; i < amountOfWords; i++)
            {
                
                int randomArray = rnd.Next(0, lines.Length);
                string singleLine = lines[randomArray];
                string[] splitWords;
                splitWords = singleLine.Split(',');
                if (finalizedWordList != null)
                {
                    if (finalizedWordList.Contains(splitWords[1]))
                    {
                        i -= 1;
                        continue;
                    }
                }
                
                finalizedWordList.Add(splitWords[1]);
                
            }
            foreach(string word in finalizedWordList)
            {
                lblWords.Text = lblWords.Text + "\n" + word;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            selectedCategory = cmbCategory.SelectedItem.ToString();
            selectedCategory = selectedCategory + ".txt";

            lines = File.ReadAllLines("Categories\\" + selectedCategory);
            if (lines == null || lines.Length == 0)
            {
                MessageBox.Show("This category is empty. Please add words to the category.");
                return;
            }

            this.Hide();
            Game game = new Game(selectedCategory);
            game.Show();
            
        }

        private void checkCmbValue(object sender, EventArgs e)
        {
            if (cmbCategory.Text == "Select Category")
            {
                btnPlay.Enabled = false;
            }
            else
            {
                btnPlay.Enabled = true;
                btnHints.Enabled = true;
                btnPlay.BackColor = Color.SteelBlue;
                btnHints.BackColor = Color.SteelBlue;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlHints.Hide();
            pnlMainTitle.Show();
        }
    }
}
