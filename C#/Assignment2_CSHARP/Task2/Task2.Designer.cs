
namespace Task2._1
{
    partial class Task2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 722);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(536, 128);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate all factor trees between min and max";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Min";
            // 
            // outputBox
            // 
            this.outputBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.outputBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.outputBox.Location = new System.Drawing.Point(183, 210);
            this.outputBox.Margin = new System.Windows.Forms.Padding(6);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(534, 444);
            this.outputBox.TabIndex = 7;
            this.outputBox.TabStop = false;
            // 
            // maxBox
            // 
            this.maxBox.AcceptsReturn = true;
            this.maxBox.AcceptsTab = true;
            this.maxBox.Location = new System.Drawing.Point(515, 81);
            this.maxBox.Margin = new System.Windows.Forms.Padding(6);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(202, 30);
            this.maxBox.TabIndex = 6;
            this.maxBox.Text = "10";
            // 
            // minBox
            // 
            this.minBox.AcceptsReturn = true;
            this.minBox.AcceptsTab = true;
            this.minBox.Location = new System.Drawing.Point(184, 81);
            this.minBox.Margin = new System.Windows.Forms.Padding(6);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(202, 30);
            this.minBox.TabIndex = 5;
            this.minBox.Text = "0";
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 913);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.minBox);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Task2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox minBox;
    }
}

