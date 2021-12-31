using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            ratioLabel.Visible = false;
            hiddenWord.Visible = false;
            feedbackTextBox.Visible = false;
            inputTextBox.Visible = false;
            guessedLetters.Visible = false;
            guessButton.Visible = false;
        }

        String[] wordList = {"promotion", "grandfather", "revolution", "innovation", "conglomerate", "violation", "confrontation", "transaction", "satisfied",
                                "manufacturer", "instrument", "illustrate", "hypnothize"};
        String selectedWord;
        List<char> guessedLetterTracker = new List<char>();
        int correctGuess;
        int incorrectGuess;
        Random random = new Random();
        char[] wordCharArray;
        char[] guessCharArray;

        private void newGameButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            String input = inputTextBox.Text.Trim().ToLower();
            char letter = validInput(input);

            if (!Char.IsWhiteSpace(letter)) {
                if (selectedWord.Contains(letter))
                {
                    letterInWord(letter);
                }
                else
                {
                    feedbackTextBox.Text = "Yikes! '" + letter + "' was not in the word!";
                    incorrectGuess++;
                }
                guessedLetterTracker.Add(letter);
               
            }
            updateRatio();
            updateLetterTracker();
            checkPassFail();
            inputTextBox.Text = "";
            inputTextBox.Focus();
        }


        private char validInput(String input)
        {
            if (input.Length != 1)
            {
                feedbackTextBox.Text = "You entered more than one letter, or have entered nothing. Please try again";
                return ' ';
            }

            char letter = input.ToCharArray()[0];
            if (!Char.IsLetter(letter))
            {
                feedbackTextBox.Text = "This is not a letter. Since I'm being nice, there are no non-letters in these words.";
                return ' ';
            }

            if (guessedLetterTracker.Contains(letter)) {
                feedbackTextBox.Text = "Yikes! You've already guessed this letter!";
                incorrectGuess++;
                return ' ';
            }
            return letter;
        }



        private void letterInWord(char letter) {
            int count = 0;
            int at = 0;
            int end = selectedWord.Length;
            int start = 0;
            while (start < end && at > -1)
            {
                count = end - start;
                at = selectedWord.IndexOf(letter, start, count);
                if (at == -1) break;
                guessCharArray[at] = letter;
                start = at + 1;
            }
            hiddenWord.Text = "";
            foreach (char c in guessCharArray)
            {
                hiddenWord.Text += c;
            }
            feedbackTextBox.Text = "Good Job! '" + letter + "' was in the word!";
            correctGuess++;

        }

        private void updateRatio() {
            ratioLabel.Text = correctGuess + " : " + incorrectGuess;
        }

        private void reset() {
            if (!label1.Visible) {
                makeUIVisible();
            }
            inputTextBox.ReadOnly = false;
            guessButton.Enabled = true;

            inputTextBox.Text = "";
            hiddenWord.Text = "";
            feedbackTextBox.Text = "";
            guessedLetters.Text = "";
            selectedWord = wordList[random.Next(13)];
            correctGuess = 0;
            incorrectGuess = 0;
            ratioLabel.Text = correctGuess + " : " + incorrectGuess;
            guessedLetterTracker.Clear();
            for (int i = 0; i < selectedWord.Length; i++)
            {
                hiddenWord.Text += "*";
            }
            wordCharArray = selectedWord.ToCharArray();
            guessCharArray = hiddenWord.Text.ToCharArray();
        }

        private void makeUIVisible() {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            ratioLabel.Visible = true;
            hiddenWord.Visible = true;
            feedbackTextBox.Visible = true;
            inputTextBox.Visible = true;
            guessedLetters.Visible = true;
            guessButton.Visible = true;
        }

        private void updateLetterTracker() {
            guessedLetterTracker.Sort();
            guessedLetters.Text = "";
            foreach (char c in guessedLetterTracker) {
                guessedLetters.Text += c + ", ";
            }
        }

        private void checkPassFail() {

            if (selectedWord == hiddenWord.Text) {
                guessButton.Enabled = false;
                inputTextBox.ReadOnly = true;
                feedbackTextBox.Text = "Congratulations! You've guessed the word! Press the new game button to play again.";
            }

            else if (incorrectGuess >= selectedWord.Length * 2)
            {
                inputTextBox.ReadOnly = true;
                guessButton.Enabled = false;
                feedbackTextBox.Text = "You've done too many gusses. Game Over! Press the New Game button to play again.";
            }
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                guessButton_Click(sender, e);
            }
        }
    }
}
