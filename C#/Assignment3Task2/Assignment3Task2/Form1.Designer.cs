
namespace Assignment3Task2
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a word: ";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(172, 68);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(264, 27);
            this.inputBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(443, 67);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(157, 28);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            this.submitButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.submitButton_KeyDown);
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.Menu;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.outputBox.Location = new System.Drawing.Point(172, 168);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(264, 308);
            this.outputBox.TabIndex = 3;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(172, 520);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(264, 69);
            this.restartButton.TabIndex = 4;
            this.restartButton.Text = "Restart?";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 667);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Reverse Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button restartButton;
    }
}

