
namespace Assignment5
{
    partial class BoatRental
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
            this.passNumComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enginePowerComboBox = new System.Windows.Forms.ComboBox();
            this.departureDatePicker = new System.Windows.Forms.DateTimePicker();
            this.departureCityComboBox = new System.Windows.Forms.ComboBox();
            this.arrivalCityComboBox = new System.Windows.Forms.ComboBox();
            this.arrivalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.quoteBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.departureTimePicker = new System.Windows.Forms.DateTimePicker();
            this.arrivalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DTWarning1 = new System.Windows.Forms.Label();
            this.DTWarning2 = new System.Windows.Forms.Label();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passNumComboBox
            // 
            this.passNumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.passNumComboBox.FormattingEnabled = true;
            this.passNumComboBox.Location = new System.Drawing.Point(330, 93);
            this.passNumComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.passNumComboBox.Name = "passNumComboBox";
            this.passNumComboBox.Size = new System.Drawing.Size(47, 30);
            this.passNumComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Engine Power Level";
            // 
            // enginePowerComboBox
            // 
            this.enginePowerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.enginePowerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enginePowerComboBox.FormattingEnabled = true;
            this.enginePowerComboBox.Location = new System.Drawing.Point(838, 93);
            this.enginePowerComboBox.Name = "enginePowerComboBox";
            this.enginePowerComboBox.Size = new System.Drawing.Size(47, 30);
            this.enginePowerComboBox.TabIndex = 3;
            this.enginePowerComboBox.SelectedIndexChanged += new System.EventHandler(this.enginePowerComboBox_SelectionChangeCommitted);
            this.enginePowerComboBox.SelectionChangeCommitted += new System.EventHandler(this.enginePowerComboBox_SelectionChangeCommitted);
            // 
            // departureDatePicker
            // 
            this.departureDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.departureDatePicker.Location = new System.Drawing.Point(442, 154);
            this.departureDatePicker.Name = "departureDatePicker";
            this.departureDatePicker.Size = new System.Drawing.Size(175, 30);
            this.departureDatePicker.TabIndex = 4;
            // 
            // departureCityComboBox
            // 
            this.departureCityComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Arco",
            "Buttek",
            "Camdel",
            "Dertoth",
            "Esmoll"});
            this.departureCityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departureCityComboBox.FormattingEnabled = true;
            this.departureCityComboBox.Location = new System.Drawing.Point(259, 154);
            this.departureCityComboBox.Name = "departureCityComboBox";
            this.departureCityComboBox.Size = new System.Drawing.Size(118, 30);
            this.departureCityComboBox.TabIndex = 5;
            // 
            // arrivalCityComboBox
            // 
            this.arrivalCityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrivalCityComboBox.FormattingEnabled = true;
            this.arrivalCityComboBox.Location = new System.Drawing.Point(259, 225);
            this.arrivalCityComboBox.Name = "arrivalCityComboBox";
            this.arrivalCityComboBox.Size = new System.Drawing.Size(121, 30);
            this.arrivalCityComboBox.TabIndex = 7;
            // 
            // arrivalDatePicker
            // 
            this.arrivalDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.arrivalDatePicker.Location = new System.Drawing.Point(442, 225);
            this.arrivalDatePicker.Name = "arrivalDatePicker";
            this.arrivalDatePicker.Size = new System.Drawing.Size(175, 30);
            this.arrivalDatePicker.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Departure Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Arrival Port";
            // 
            // warningLabel
            // 
            this.warningLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(281, 298);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(478, 22);
            this.warningLabel.TabIndex = 12;
            this.warningLabel.Text = "Captain License required at boat pickup";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(797, 154);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(133, 101);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Calculate Quote";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // quoteBox
            // 
            this.quoteBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.quoteBox.Enabled = false;
            this.quoteBox.Location = new System.Drawing.Point(259, 379);
            this.quoteBox.Multiline = true;
            this.quoteBox.Name = "quoteBox";
            this.quoteBox.ReadOnly = true;
            this.quoteBox.Size = new System.Drawing.Size(526, 246);
            this.quoteBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Your Quote";
            // 
            // departureTimePicker
            // 
            this.departureTimePicker.CustomFormat = "h tt";
            this.departureTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.departureTimePicker.Location = new System.Drawing.Point(628, 154);
            this.departureTimePicker.Name = "departureTimePicker";
            this.departureTimePicker.ShowUpDown = true;
            this.departureTimePicker.Size = new System.Drawing.Size(131, 30);
            this.departureTimePicker.TabIndex = 16;
            this.departureTimePicker.ValueChanged += new System.EventHandler(this.departureTimePicker_ValueChanged);
            // 
            // arrivalTimePicker
            // 
            this.arrivalTimePicker.CustomFormat = "h tt";
            this.arrivalTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arrivalTimePicker.Location = new System.Drawing.Point(628, 225);
            this.arrivalTimePicker.Name = "arrivalTimePicker";
            this.arrivalTimePicker.ShowUpDown = true;
            this.arrivalTimePicker.Size = new System.Drawing.Size(131, 30);
            this.arrivalTimePicker.TabIndex = 17;
            this.arrivalTimePicker.Value = new System.DateTime(2021, 4, 27, 16, 38, 52, 0);
            this.arrivalTimePicker.ValueChanged += new System.EventHandler(this.arrivalTimePicker_ValueChanged);
            // 
            // DTWarning1
            // 
            this.DTWarning1.AutoSize = true;
            this.DTWarning1.ForeColor = System.Drawing.Color.Red;
            this.DTWarning1.Location = new System.Drawing.Point(314, 9);
            this.DTWarning1.Name = "DTWarning1";
            this.DTWarning1.Size = new System.Drawing.Size(370, 22);
            this.DTWarning1.TabIndex = 18;
            this.DTWarning1.Text = "Your Date and Time is Invalid ";
            // 
            // DTWarning2
            // 
            this.DTWarning2.AutoSize = true;
            this.DTWarning2.ForeColor = System.Drawing.Color.Red;
            this.DTWarning2.Location = new System.Drawing.Point(163, 48);
            this.DTWarning2.Name = "DTWarning2";
            this.DTWarning2.Size = new System.Drawing.Size(742, 22);
            this.DTWarning2.TabIndex = 19;
            this.DTWarning2.Text = "Please make sure the Arrival Date is after the Departure Date";
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.AutoSize = true;
            this.grandTotalLabel.Font = new System.Drawing.Font("Courier New", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalLabel.Location = new System.Drawing.Point(277, 656);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(332, 46);
            this.grandTotalLabel.TabIndex = 20;
            this.grandTotalLabel.Text = "Grand Total: ";
            // 
            // BoatRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 766);
            this.Controls.Add(this.grandTotalLabel);
            this.Controls.Add(this.DTWarning2);
            this.Controls.Add(this.DTWarning1);
            this.Controls.Add(this.arrivalTimePicker);
            this.Controls.Add(this.departureTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quoteBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrivalDatePicker);
            this.Controls.Add(this.arrivalCityComboBox);
            this.Controls.Add(this.departureCityComboBox);
            this.Controls.Add(this.departureDatePicker);
            this.Controls.Add(this.enginePowerComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passNumComboBox);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BoatRental";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox passNumComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox enginePowerComboBox;
        private System.Windows.Forms.DateTimePicker departureDatePicker;
        private System.Windows.Forms.ComboBox departureCityComboBox;
        private System.Windows.Forms.ComboBox arrivalCityComboBox;
        private System.Windows.Forms.DateTimePicker arrivalDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox quoteBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker departureTimePicker;
        private System.Windows.Forms.DateTimePicker arrivalTimePicker;
        private System.Windows.Forms.Label DTWarning1;
        private System.Windows.Forms.Label DTWarning2;
        private System.Windows.Forms.Label grandTotalLabel;
    }
}

