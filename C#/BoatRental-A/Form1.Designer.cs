
namespace BoatRental
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
            this.DepartComboBox = new System.Windows.Forms.ComboBox();
            this.ArrivalComboBox = new System.Windows.Forms.ComboBox();
            this.PersonComboBox = new System.Windows.Forms.ComboBox();
            this.EngineComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CalButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DepartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ArrivalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.personLabel = new System.Windows.Forms.Label();
            this.EngineCalLabel = new System.Windows.Forms.Label();
            this.DockCalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.HoursCostLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.BasepayLabel = new System.Windows.Forms.Label();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DepartComboBox
            // 
            this.DepartComboBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartComboBox.FormattingEnabled = true;
            this.DepartComboBox.Location = new System.Drawing.Point(159, 314);
            this.DepartComboBox.Name = "DepartComboBox";
            this.DepartComboBox.Size = new System.Drawing.Size(531, 44);
            this.DepartComboBox.TabIndex = 0;
            this.DepartComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartComboBox_SelectedIndexChanged);
            // 
            // ArrivalComboBox
            // 
            this.ArrivalComboBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalComboBox.FormattingEnabled = true;
            this.ArrivalComboBox.Location = new System.Drawing.Point(862, 318);
            this.ArrivalComboBox.Name = "ArrivalComboBox";
            this.ArrivalComboBox.Size = new System.Drawing.Size(524, 44);
            this.ArrivalComboBox.TabIndex = 1;
            this.ArrivalComboBox.SelectedIndexChanged += new System.EventHandler(this.ArrivalComboBox_SelectedIndexChanged);
            // 
            // PersonComboBox
            // 
            this.PersonComboBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonComboBox.FormattingEnabled = true;
            this.PersonComboBox.Location = new System.Drawing.Point(248, 150);
            this.PersonComboBox.Name = "PersonComboBox";
            this.PersonComboBox.Size = new System.Drawing.Size(177, 44);
            this.PersonComboBox.TabIndex = 2;
            this.PersonComboBox.SelectedIndexChanged += new System.EventHandler(this.PersonComboBox_SelectedIndexChanged);
            // 
            // EngineComboBox
            // 
            this.EngineComboBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineComboBox.FormattingEnabled = true;
            this.EngineComboBox.Location = new System.Drawing.Point(979, 162);
            this.EngineComboBox.Name = "EngineComboBox";
            this.EngineComboBox.Size = new System.Drawing.Size(177, 44);
            this.EngineComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of persons aboard:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(945, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Engine Level:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Departure:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(945, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arrival:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Town:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(746, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Town:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalButton
            // 
            this.CalButton.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalButton.Location = new System.Drawing.Point(447, 575);
            this.CalButton.Name = "CalButton";
            this.CalButton.Size = new System.Drawing.Size(450, 83);
            this.CalButton.TabIndex = 15;
            this.CalButton.Text = "Calculate Quote ";
            this.CalButton.UseVisualStyleBackColor = true;
            this.CalButton.Click += new System.EventHandler(this.CalButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 36);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(746, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 36);
            this.label8.TabIndex = 17;
            this.label8.Text = "Date:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(334, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(724, 49);
            this.label11.TabIndex = 20;
            this.label11.Text = "Houseboat Retal Reservation";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepartDatePicker
            // 
            this.DepartDatePicker.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartDatePicker.Location = new System.Drawing.Point(159, 397);
            this.DepartDatePicker.Name = "DepartDatePicker";
            this.DepartDatePicker.Size = new System.Drawing.Size(531, 44);
            this.DepartDatePicker.TabIndex = 26;
            this.DepartDatePicker.ValueChanged += new System.EventHandler(this.DepartDatePicker_ValueChanged);
            // 
            // ArrivalDatePicker
            // 
            this.ArrivalDatePicker.CalendarFont = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalDatePicker.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ArrivalDatePicker.Location = new System.Drawing.Point(862, 397);
            this.ArrivalDatePicker.Name = "ArrivalDatePicker";
            this.ArrivalDatePicker.Size = new System.Drawing.Size(524, 44);
            this.ArrivalDatePicker.TabIndex = 27;
            // 
            // personLabel
            // 
            this.personLabel.AutoSize = true;
            this.personLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personLabel.Location = new System.Drawing.Point(42, 858);
            this.personLabel.Name = "personLabel";
            this.personLabel.Size = new System.Drawing.Size(224, 36);
            this.personLabel.TabIndex = 30;
            this.personLabel.Text = "PersonLabel";
            this.personLabel.Visible = false;
            // 
            // EngineCalLabel
            // 
            this.EngineCalLabel.AutoSize = true;
            this.EngineCalLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineCalLabel.Location = new System.Drawing.Point(745, 770);
            this.EngineCalLabel.Name = "EngineCalLabel";
            this.EngineCalLabel.Size = new System.Drawing.Size(224, 36);
            this.EngineCalLabel.TabIndex = 31;
            this.EngineCalLabel.Text = "EngineLabel";
            this.EngineCalLabel.Visible = false;
            // 
            // DockCalLabel
            // 
            this.DockCalLabel.AutoSize = true;
            this.DockCalLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DockCalLabel.Location = new System.Drawing.Point(42, 950);
            this.DockCalLabel.Name = "DockCalLabel";
            this.DockCalLabel.Size = new System.Drawing.Size(224, 36);
            this.DockCalLabel.TabIndex = 32;
            this.DockCalLabel.Text = "StreamLabel";
            this.DockCalLabel.Visible = false;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.Location = new System.Drawing.Point(463, 1055);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(205, 36);
            this.TaxLabel.TabIndex = 33;
            this.TaxLabel.Text = "TaxesLabel";
            this.TaxLabel.Visible = false;
            // 
            // HoursCostLabel
            // 
            this.HoursCostLabel.AutoSize = true;
            this.HoursCostLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursCostLabel.Location = new System.Drawing.Point(745, 950);
            this.HoursCostLabel.Name = "HoursCostLabel";
            this.HoursCostLabel.Size = new System.Drawing.Size(186, 36);
            this.HoursCostLabel.TabIndex = 37;
            this.HoursCostLabel.Text = "HoursCost";
            this.HoursCostLabel.UseMnemonic = false;
            this.HoursCostLabel.Visible = false;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Courier New", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(389, 710);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(334, 49);
            this.TotalLabel.TabIndex = 38;
            this.TotalLabel.Text = "Grand Total:";
            this.TotalLabel.Visible = false;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Font = new System.Drawing.Font("Courier New", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalLabel.Location = new System.Drawing.Point(730, 710);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(308, 49);
            this.GrandTotalLabel.TabIndex = 39;
            this.GrandTotalLabel.Text = "TotalNumber";
            this.GrandTotalLabel.Visible = false;
            // 
            // BasepayLabel
            // 
            this.BasepayLabel.AutoSize = true;
            this.BasepayLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasepayLabel.Location = new System.Drawing.Point(42, 770);
            this.BasepayLabel.Name = "BasepayLabel";
            this.BasepayLabel.Size = new System.Drawing.Size(148, 36);
            this.BasepayLabel.TabIndex = 40;
            this.BasepayLabel.Text = "Basepay";
            this.BasepayLabel.Visible = false;
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysLabel.Location = new System.Drawing.Point(1020, 858);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(186, 36);
            this.DaysLabel.TabIndex = 36;
            this.DaysLabel.Text = "DaysLabel";
            this.DaysLabel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(745, 858);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 36);
            this.label9.TabIndex = 41;
            this.label9.Text = "Hours Rented:";
            this.label9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 1308);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BasepayLabel);
            this.Controls.Add(this.GrandTotalLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.HoursCostLabel);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.DockCalLabel);
            this.Controls.Add(this.EngineCalLabel);
            this.Controls.Add(this.personLabel);
            this.Controls.Add(this.ArrivalDatePicker);
            this.Controls.Add(this.DepartDatePicker);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CalButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EngineComboBox);
            this.Controls.Add(this.PersonComboBox);
            this.Controls.Add(this.ArrivalComboBox);
            this.Controls.Add(this.DepartComboBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DepartComboBox;
        private System.Windows.Forms.ComboBox ArrivalComboBox;
        private System.Windows.Forms.ComboBox PersonComboBox;
        private System.Windows.Forms.ComboBox EngineComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CalButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DepartDatePicker;
        private System.Windows.Forms.DateTimePicker ArrivalDatePicker;
        private System.Windows.Forms.Label personLabel;
        private System.Windows.Forms.Label EngineCalLabel;
        private System.Windows.Forms.Label DockCalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label HoursCostLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Label BasepayLabel;
        private System.Windows.Forms.Label DaysLabel;
        private System.Windows.Forms.Label label9;
    }
}

