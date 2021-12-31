
namespace Assignment2
{
    partial class Task1
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lowercaseLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(299, 203);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(436, 30);
            this.inputBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input some text into the textbox and press count";
            // 
            // lowercaseLabel
            // 
            this.lowercaseLabel.AutoSize = true;
            this.lowercaseLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowercaseLabel.Location = new System.Drawing.Point(60, 637);
            this.lowercaseLabel.Name = "lowercaseLabel";
            this.lowercaseLabel.Size = new System.Drawing.Size(0, 22);
            this.lowercaseLabel.TabIndex = 2;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(599, 637);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(0, 22);
            this.numberLabel.TabIndex = 3;
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count.Location = new System.Drawing.Point(299, 318);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(436, 165);
            this.Count.TabIndex = 4;
            this.Count.Text = "Count";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 748);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.lowercaseLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox);
            this.Name = "Task1";
            this.Text = "Counter - Part 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lowercaseLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button Count;
    }
}

