
namespace Assignment3Task1
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
            this.hiddenWord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guessedLetters = new System.Windows.Forms.TextBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ratioLabel = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.feedbackTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word: ";
            // 
            // hiddenWord
            // 
            this.hiddenWord.AutoSize = true;
            this.hiddenWord.Location = new System.Drawing.Point(344, 108);
            this.hiddenWord.Name = "hiddenWord";
            this.hiddenWord.Size = new System.Drawing.Size(0, 20);
            this.hiddenWord.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Guess a Letter ------>";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(523, 151);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(28, 27);
            this.inputTextBox.TabIndex = 3;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Letters you\'ve already guessed";
            // 
            // guessedLetters
            // 
            this.guessedLetters.Location = new System.Drawing.Point(273, 425);
            this.guessedLetters.Multiline = true;
            this.guessedLetters.Name = "guessedLetters";
            this.guessedLetters.ReadOnly = true;
            this.guessedLetters.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.guessedLetters.Size = new System.Drawing.Size(305, 140);
            this.guessedLetters.TabIndex = 6;
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(273, 13);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(305, 61);
            this.newGameButton.TabIndex = 7;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Corect-Incorrect Ratio";
            // 
            // ratioLabel
            // 
            this.ratioLabel.AutoSize = true;
            this.ratioLabel.ForeColor = System.Drawing.Color.Red;
            this.ratioLabel.Location = new System.Drawing.Point(519, 205);
            this.ratioLabel.Name = "ratioLabel";
            this.ratioLabel.Size = new System.Drawing.Size(59, 20);
            this.ratioLabel.TabIndex = 9;
            this.ratioLabel.Text = "0 : 0";
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(342, 239);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(156, 46);
            this.guessButton.TabIndex = 10;
            this.guessButton.Text = "Submit";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // feedbackTextBox
            // 
            this.feedbackTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedbackTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.feedbackTextBox.Enabled = false;
            this.feedbackTextBox.Location = new System.Drawing.Point(273, 302);
            this.feedbackTextBox.Multiline = true;
            this.feedbackTextBox.Name = "feedbackTextBox";
            this.feedbackTextBox.ReadOnly = true;
            this.feedbackTextBox.Size = new System.Drawing.Size(305, 64);
            this.feedbackTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 577);
            this.Controls.Add(this.feedbackTextBox);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.ratioLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.guessedLetters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hiddenWord);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Guess a Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hiddenWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guessedLetters;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ratioLabel;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.TextBox feedbackTextBox;
    }
}

