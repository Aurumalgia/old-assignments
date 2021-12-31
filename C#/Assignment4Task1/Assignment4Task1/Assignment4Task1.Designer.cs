
namespace Assignment4Task1
{
    partial class Assignment4Task1
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
            this.modelBox = new System.Windows.Forms.TextBox();
            this.mpgBox = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.car1Model = new System.Windows.Forms.Label();
            this.car1MPGlabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.car2MPGLabel = new System.Windows.Forms.Label();
            this.car2Model = new System.Windows.Forms.Label();
            this.car3MPGLabel = new System.Windows.Forms.Label();
            this.car3Model = new System.Windows.Forms.Label();
            this.car4MPGLabel = new System.Windows.Forms.Label();
            this.car4Model = new System.Windows.Forms.Label();
            this.positionBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.position1Label = new System.Windows.Forms.Label();
            this.position2Label = new System.Windows.Forms.Label();
            this.position3Label = new System.Windows.Forms.Label();
            this.position4Label = new System.Windows.Forms.Label();
            this.removeCarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(83, 76);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(345, 22);
            this.modelBox.TabIndex = 0;
            // 
            // mpgBox
            // 
            this.mpgBox.Location = new System.Drawing.Point(438, 76);
            this.mpgBox.Name = "mpgBox";
            this.mpgBox.Size = new System.Drawing.Size(43, 22);
            this.mpgBox.TabIndex = 1;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(207, 118);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(114, 23);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Add/Edit Car";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // car1Model
            // 
            this.car1Model.AutoSize = true;
            this.car1Model.Location = new System.Drawing.Point(100, 227);
            this.car1Model.Name = "car1Model";
            this.car1Model.Size = new System.Drawing.Size(46, 17);
            this.car1Model.TabIndex = 4;
            this.car1Model.Text = "label1";
            this.car1Model.Visible = false;
            // 
            // car1MPGlabel
            // 
            this.car1MPGlabel.AutoSize = true;
            this.car1MPGlabel.Location = new System.Drawing.Point(455, 226);
            this.car1MPGlabel.Name = "car1MPGlabel";
            this.car1MPGlabel.Size = new System.Drawing.Size(46, 17);
            this.car1MPGlabel.TabIndex = 5;
            this.car1MPGlabel.Text = "label2";
            this.car1MPGlabel.Visible = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(207, 147);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add 1 to MPG";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(336, 147);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(145, 23);
            this.subtractButton.TabIndex = 10;
            this.subtractButton.Text = "Subtract 1 to MPG";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // car2MPGLabel
            // 
            this.car2MPGLabel.AutoSize = true;
            this.car2MPGLabel.Location = new System.Drawing.Point(455, 283);
            this.car2MPGLabel.Name = "car2MPGLabel";
            this.car2MPGLabel.Size = new System.Drawing.Size(46, 17);
            this.car2MPGLabel.TabIndex = 9;
            this.car2MPGLabel.Text = "label3";
            this.car2MPGLabel.Visible = false;
            // 
            // car2Model
            // 
            this.car2Model.AutoSize = true;
            this.car2Model.Location = new System.Drawing.Point(100, 284);
            this.car2Model.Name = "car2Model";
            this.car2Model.Size = new System.Drawing.Size(46, 17);
            this.car2Model.TabIndex = 8;
            this.car2Model.Text = "label4";
            this.car2Model.Visible = false;
            // 
            // car3MPGLabel
            // 
            this.car3MPGLabel.AutoSize = true;
            this.car3MPGLabel.Location = new System.Drawing.Point(455, 343);
            this.car3MPGLabel.Name = "car3MPGLabel";
            this.car3MPGLabel.Size = new System.Drawing.Size(46, 17);
            this.car3MPGLabel.TabIndex = 13;
            this.car3MPGLabel.Text = "label5";
            this.car3MPGLabel.Visible = false;
            // 
            // car3Model
            // 
            this.car3Model.AutoSize = true;
            this.car3Model.Location = new System.Drawing.Point(100, 344);
            this.car3Model.Name = "car3Model";
            this.car3Model.Size = new System.Drawing.Size(46, 17);
            this.car3Model.TabIndex = 12;
            this.car3Model.Text = "label6";
            this.car3Model.Visible = false;
            // 
            // car4MPGLabel
            // 
            this.car4MPGLabel.AutoSize = true;
            this.car4MPGLabel.Location = new System.Drawing.Point(455, 402);
            this.car4MPGLabel.Name = "car4MPGLabel";
            this.car4MPGLabel.Size = new System.Drawing.Size(46, 17);
            this.car4MPGLabel.TabIndex = 17;
            this.car4MPGLabel.Text = "label7";
            this.car4MPGLabel.Visible = false;
            // 
            // car4Model
            // 
            this.car4Model.AutoSize = true;
            this.car4Model.Location = new System.Drawing.Point(100, 403);
            this.car4Model.Name = "car4Model";
            this.car4Model.Size = new System.Drawing.Size(46, 17);
            this.car4Model.TabIndex = 16;
            this.car4Model.Text = "label8";
            this.car4Model.Visible = false;
            // 
            // positionBox
            // 
            this.positionBox.Location = new System.Drawing.Point(117, 147);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(39, 22);
            this.positionBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Car Model";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "MPG";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Position (#1-4)";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(83, 24);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(74, 17);
            this.errorLabel.TabIndex = 24;
            this.errorLabel.Text = "errorLabel";
            this.errorLabel.Visible = false;
            // 
            // position1Label
            // 
            this.position1Label.AutoSize = true;
            this.position1Label.Location = new System.Drawing.Point(29, 226);
            this.position1Label.Name = "position1Label";
            this.position1Label.Size = new System.Drawing.Size(16, 17);
            this.position1Label.TabIndex = 25;
            this.position1Label.Text = "1";
            this.position1Label.Visible = false;
            // 
            // position2Label
            // 
            this.position2Label.AutoSize = true;
            this.position2Label.Location = new System.Drawing.Point(29, 284);
            this.position2Label.Name = "position2Label";
            this.position2Label.Size = new System.Drawing.Size(16, 17);
            this.position2Label.TabIndex = 26;
            this.position2Label.Text = "2";
            this.position2Label.Visible = false;
            // 
            // position3Label
            // 
            this.position3Label.AutoSize = true;
            this.position3Label.Location = new System.Drawing.Point(29, 344);
            this.position3Label.Name = "position3Label";
            this.position3Label.Size = new System.Drawing.Size(16, 17);
            this.position3Label.TabIndex = 27;
            this.position3Label.Text = "3";
            this.position3Label.Visible = false;
            // 
            // position4Label
            // 
            this.position4Label.AutoSize = true;
            this.position4Label.Location = new System.Drawing.Point(29, 403);
            this.position4Label.Name = "position4Label";
            this.position4Label.Size = new System.Drawing.Size(16, 17);
            this.position4Label.TabIndex = 29;
            this.position4Label.Text = "4";
            this.position4Label.Visible = false;
            // 
            // removeCarButton
            // 
            this.removeCarButton.Location = new System.Drawing.Point(336, 118);
            this.removeCarButton.Name = "removeCarButton";
            this.removeCarButton.Size = new System.Drawing.Size(145, 23);
            this.removeCarButton.TabIndex = 30;
            this.removeCarButton.Text = "Remove Car";
            this.removeCarButton.UseVisualStyleBackColor = true;
            this.removeCarButton.Click += new System.EventHandler(this.removeCarButton_Click);
            // 
            // Assignment4Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 497);
            this.Controls.Add(this.removeCarButton);
            this.Controls.Add(this.position4Label);
            this.Controls.Add(this.position3Label);
            this.Controls.Add(this.position2Label);
            this.Controls.Add(this.position1Label);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.positionBox);
            this.Controls.Add(this.car4MPGLabel);
            this.Controls.Add(this.car4Model);
            this.Controls.Add(this.car3MPGLabel);
            this.Controls.Add(this.car3Model);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.car2MPGLabel);
            this.Controls.Add(this.car2Model);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.car1MPGlabel);
            this.Controls.Add(this.car1Model);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.mpgBox);
            this.Controls.Add(this.modelBox);
            this.Name = "Assignment4Task1";
            this.Text = "MPG Comparison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox mpgBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label car1Model;
        private System.Windows.Forms.Label car1MPGlabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Label car2MPGLabel;
        private System.Windows.Forms.Label car2Model;
        private System.Windows.Forms.Label car3MPGLabel;
        private System.Windows.Forms.Label car3Model;
        private System.Windows.Forms.Label car4MPGLabel;
        private System.Windows.Forms.Label car4Model;
        private System.Windows.Forms.TextBox positionBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label position1Label;
        private System.Windows.Forms.Label position2Label;
        private System.Windows.Forms.Label position3Label;
        private System.Windows.Forms.Label position4Label;
        private System.Windows.Forms.Button removeCarButton;
    }
}

