using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;
using System.Resources;

namespace PashtoVocabProgram
{
    public partial class Form1 : Form
    {
        public string[] lines = File.ReadAllLines("words.txt");
        public string[] wordList;
        string englishWord;
        string pashtoWord;

        int arrayNumber;

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            for (int i = lines.Length; i <= lines.Length && i > 0; i--) 
            {
            }
        }

        private void ResetVocab()
        {
            arrayNumber = rnd.Next(0, lines.Length);
            string words = lines[arrayNumber];
            string[] splitWords = words.Split(',');
            string picName = "Images\\" + splitWords[0];


            if (splitWords[0].Contains(".png") || splitWords[0].Contains(".jpg"))
            {
                if (File.Exists(picName) == false)
                {
                    picItem.Image = null;
                }
                else
                {
                    Image img = Image.FromFile(picName);
                    picItem.Image = img;
                }
                pashtoWord = splitWords[2];
                englishWord = splitWords[1];
            }
            else
            {
                picItem.Image = null;
                pashtoWord = splitWords[1];
                englishWord = splitWords[0];
            }
            

            lblPashtuWord.Text = pashtoWord;
            Debug.WriteLine(englishWord);



        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (userInput.Text == englishWord)
            {
                btnSubmit.Enabled = false;
                btnSubmit.Text = "Correct!";
                Wait(3000);
                btnSubmit.Text = "Submit";
                btnSubmit.Enabled = true;
                userInput.Text = "";
                ResetVocab();
            }
            else
            {
                btnSubmit.Text = "Incorrect";
                Wait(1000);
                btnSubmit.Text = "Submit";
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

    }
}
