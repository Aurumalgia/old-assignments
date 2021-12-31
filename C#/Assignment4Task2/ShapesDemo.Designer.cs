
namespace Assignment4Task2
{
    partial class ShapesDemo
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
            this.label2 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.rectangleRadio = new System.Windows.Forms.RadioButton();
            this.squareRadio = new System.Windows.Forms.RadioButton();
            this.triangleRadio = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(53, 105);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(65, 22);
            this.heightBox.TabIndex = 2;
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(178, 105);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(65, 22);
            this.widthBox.TabIndex = 3;
            // 
            // rectangleRadio
            // 
            this.rectangleRadio.AutoSize = true;
            this.rectangleRadio.Checked = true;
            this.rectangleRadio.Location = new System.Drawing.Point(53, 152);
            this.rectangleRadio.Name = "rectangleRadio";
            this.rectangleRadio.Size = new System.Drawing.Size(93, 21);
            this.rectangleRadio.TabIndex = 4;
            this.rectangleRadio.TabStop = true;
            this.rectangleRadio.Text = "Rectangle";
            this.rectangleRadio.UseVisualStyleBackColor = true;
            // 
            // squareRadio
            // 
            this.squareRadio.AutoSize = true;
            this.squareRadio.Location = new System.Drawing.Point(53, 179);
            this.squareRadio.Name = "squareRadio";
            this.squareRadio.Size = new System.Drawing.Size(75, 21);
            this.squareRadio.TabIndex = 5;
            this.squareRadio.Text = "Square";
            this.squareRadio.UseVisualStyleBackColor = true;
            // 
            // triangleRadio
            // 
            this.triangleRadio.AutoSize = true;
            this.triangleRadio.Location = new System.Drawing.Point(53, 206);
            this.triangleRadio.Name = "triangleRadio";
            this.triangleRadio.Size = new System.Drawing.Size(81, 21);
            this.triangleRadio.TabIndex = 6;
            this.triangleRadio.Text = "Triangle";
            this.triangleRadio.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(178, 150);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(118, 77);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Calculate Area";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(50, 32);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(39, 17);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "error";
            this.errorLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Area: ";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(111, 243);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(16, 17);
            this.areaLabel.TabIndex = 10;
            this.areaLabel.Text = "0";
            // 
            // ShapesDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 281);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.triangleRadio);
            this.Controls.Add(this.squareRadio);
            this.Controls.Add(this.rectangleRadio);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShapesDemo";
            this.Text = "ShapesDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.RadioButton rectangleRadio;
        private System.Windows.Forms.RadioButton squareRadio;
        private System.Windows.Forms.RadioButton triangleRadio;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label areaLabel;
    }
}

