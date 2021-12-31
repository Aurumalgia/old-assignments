using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int maxWords = 7;
        //   List<string> wordList = new List<String>();
        String[] wordList = new String[maxWords];
        int wordCount = 0;

        private void submitButton_Click(object sender, EventArgs e)
        {
            string input = validString(inputBox.Text);

            if (input != "")
            {

                //       wordList.Add(inputBox.Text.ToLowerInvariant());
                wordList[wordCount] = inputBox.Text.ToLowerInvariant();
                // wordList.Sort();
                Array.Sort(wordList);
                //       wordList.Reverse();
                Array.Reverse(wordList);
                outputBox.Text = "";
                foreach (string s in wordList)
                {
                    outputBox.Text += s + Environment.NewLine;
                }
                inputBox.Focus();
                inputBox.Text = "";
                wordCount++;
            }

            if (wordCount >= maxWords)
            {
                submitButton.Enabled = false;
            }

        }
        private void restartButton_Click(object sender, EventArgs e)
        {
            //wordList.Clear();
            Array.Clear(wordList, 0, maxWords);
            wordCount = 0;
            inputBox.Text = "";
            outputBox.Text = "";
            submitButton.Enabled = true;
            inputBox.Focus();
        }


        private string validString(string input) {
            if (String.IsNullOrEmpty(input) && String.IsNullOrWhiteSpace(input) && input.Trim().IndexOf(' ') > 0)
            {
                return "";
            }
            return input.Trim().ToLower();
        
        }

        private void submitButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                submitButton_Click(sender, e);
            }
        }

       
    }
}
