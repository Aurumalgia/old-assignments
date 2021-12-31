
namespace BoatRentals
{
    partial class boatRentalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLbl = new System.Windows.Forms.Label();
            this.personNumberLbl = new System.Windows.Forms.Label();
            this.peopleCounter = new System.Windows.Forms.DomainUpDown();
            this.enginePowerCounter = new System.Windows.Forms.DomainUpDown();
            this.powerLbl = new System.Windows.Forms.Label();
            this.departureLbl = new System.Windows.Forms.Label();
            this.depTownLbl = new System.Windows.Forms.Label();
            this.depTownCombo = new System.Windows.Forms.ComboBox();
            this.depDatePicker = new System.Windows.Forms.DateTimePicker();
            this.depDateLbl = new System.Windows.Forms.Label();
            this.depTimeCombo = new System.Windows.Forms.ComboBox();
            this.depTimeLbl = new System.Windows.Forms.Label();
            this.arrTimeCombo = new System.Windows.Forms.ComboBox();
            this.arrTimeLbl = new System.Windows.Forms.Label();
            this.arrDateLbl = new System.Windows.Forms.Label();
            this.arrDatePicker = new System.Windows.Forms.DateTimePicker();
            this.arrTownCombo = new System.Windows.Forms.ComboBox();
            this.arrTownLbl = new System.Windows.Forms.Label();
            this.arrivalLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.warningLbl = new System.Windows.Forms.Label();
            this.billListLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(52, 62);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(349, 69);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Boat rentals";
            // 
            // personNumberLbl
            // 
            this.personNumberLbl.AutoSize = true;
            this.personNumberLbl.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.personNumberLbl.Location = new System.Drawing.Point(138, 198);
            this.personNumberLbl.Name = "personNumberLbl";
            this.personNumberLbl.Size = new System.Drawing.Size(162, 32);
            this.personNumberLbl.TabIndex = 1;
            this.personNumberLbl.Text = "Number of people:";
            // 
            // peopleCounter
            // 
            this.peopleCounter.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.peopleCounter.Items.Add("6");
            this.peopleCounter.Items.Add("5");
            this.peopleCounter.Items.Add("4");
            this.peopleCounter.Items.Add("3");
            this.peopleCounter.Items.Add("2");
            this.peopleCounter.Items.Add("1");
            this.peopleCounter.Location = new System.Drawing.Point(336, 198);
            this.peopleCounter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.peopleCounter.Name = "peopleCounter";
            this.peopleCounter.Size = new System.Drawing.Size(59, 39);
            this.peopleCounter.TabIndex = 2;
            this.peopleCounter.Text = "1";
            // 
            // enginePowerCounter
            // 
            this.enginePowerCounter.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enginePowerCounter.Items.Add("Level 4");
            this.enginePowerCounter.Items.Add("Level 3");
            this.enginePowerCounter.Items.Add("Level 2");
            this.enginePowerCounter.Items.Add("Level 1");
            this.enginePowerCounter.Location = new System.Drawing.Point(634, 198);
            this.enginePowerCounter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.enginePowerCounter.Name = "enginePowerCounter";
            this.enginePowerCounter.Size = new System.Drawing.Size(106, 39);
            this.enginePowerCounter.TabIndex = 3;
            this.enginePowerCounter.Text = "Level 1";
            this.enginePowerCounter.SelectedItemChanged += new System.EventHandler(this.enginePowerCounter_SelectedItemChanged);
            // 
            // powerLbl
            // 
            this.powerLbl.AutoSize = true;
            this.powerLbl.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.powerLbl.Location = new System.Drawing.Point(476, 200);
            this.powerLbl.Name = "powerLbl";
            this.powerLbl.Size = new System.Drawing.Size(129, 32);
            this.powerLbl.TabIndex = 3;
            this.powerLbl.Text = "Engine power:";
            // 
            // departureLbl
            // 
            this.departureLbl.AutoSize = true;
            this.departureLbl.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departureLbl.Location = new System.Drawing.Point(327, 286);
            this.departureLbl.Name = "departureLbl";
            this.departureLbl.Size = new System.Drawing.Size(134, 42);
            this.departureLbl.TabIndex = 4;
            this.departureLbl.Text = "DEPARTURE";
            // 
            // depTownLbl
            // 
            this.depTownLbl.AutoSize = true;
            this.depTownLbl.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depTownLbl.Location = new System.Drawing.Point(31, 345);
            this.depTownLbl.Name = "depTownLbl";
            this.depTownLbl.Size = new System.Drawing.Size(65, 32);
            this.depTownLbl.TabIndex = 5;
            this.depTownLbl.Text = "Town: ";
            // 
            // depTownCombo
            // 
            this.depTownCombo.FormattingEnabled = true;
            this.depTownCombo.Items.AddRange(new object[] {
            "Arco",
            "Buttek",
            "Camdel",
            "Dertoth",
            "Esmoll"});
            this.depTownCombo.Location = new System.Drawing.Point(102, 345);
            this.depTownCombo.Name = "depTownCombo";
            this.depTownCombo.Size = new System.Drawing.Size(132, 40);
            this.depTownCombo.TabIndex = 6;
            this.depTownCombo.Text = "Arco";
            // 
            // depDatePicker
            // 
            this.depDatePicker.CalendarFont = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depDatePicker.CustomFormat = "dd/ mm/ yyyy";
            this.depDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.depDatePicker.Location = new System.Drawing.Point(360, 345);
            this.depDatePicker.Name = "depDatePicker";
            this.depDatePicker.Size = new System.Drawing.Size(197, 39);
            this.depDatePicker.TabIndex = 7;
            this.depDatePicker.UseWaitCursor = true;
            this.depDatePicker.Value = new System.DateTime(2021, 4, 20, 0, 0, 0, 0);
            // 
            // depDateLbl
            // 
            this.depDateLbl.AutoSize = true;
            this.depDateLbl.Location = new System.Drawing.Point(288, 345);
            this.depDateLbl.Name = "depDateLbl";
            this.depDateLbl.Size = new System.Drawing.Size(54, 32);
            this.depDateLbl.TabIndex = 8;
            this.depDateLbl.Text = "Date:";
            // 
            // depTimeCombo
            // 
            this.depTimeCombo.FormattingEnabled = true;
            this.depTimeCombo.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.depTimeCombo.Location = new System.Drawing.Point(753, 346);
            this.depTimeCombo.Name = "depTimeCombo";
            this.depTimeCombo.Size = new System.Drawing.Size(104, 40);
            this.depTimeCombo.TabIndex = 10;
            this.depTimeCombo.Text = "00";
            this.depTimeCombo.SelectedIndexChanged += new System.EventHandler(this.depTimeCombo_SelectedIndexChanged);
            // 
            // depTimeLbl
            // 
            this.depTimeLbl.AutoSize = true;
            this.depTimeLbl.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depTimeLbl.Location = new System.Drawing.Point(616, 345);
            this.depTimeLbl.Name = "depTimeLbl";
            this.depTimeLbl.Size = new System.Drawing.Size(114, 32);
            this.depTimeLbl.TabIndex = 9;
            this.depTimeLbl.Text = "Time (hour):";
            // 
            // arrTimeCombo
            // 
            this.arrTimeCombo.FormattingEnabled = true;
            this.arrTimeCombo.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.arrTimeCombo.Location = new System.Drawing.Point(753, 515);
            this.arrTimeCombo.Name = "arrTimeCombo";
            this.arrTimeCombo.Size = new System.Drawing.Size(104, 40);
            this.arrTimeCombo.TabIndex = 17;
            this.arrTimeCombo.Text = "00";
            this.arrTimeCombo.SelectedIndexChanged += new System.EventHandler(this.arrTimeCombo_SelectedIndexChanged);
            // 
            // arrTimeLbl
            // 
            this.arrTimeLbl.AutoSize = true;
            this.arrTimeLbl.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrTimeLbl.Location = new System.Drawing.Point(616, 514);
            this.arrTimeLbl.Name = "arrTimeLbl";
            this.arrTimeLbl.Size = new System.Drawing.Size(114, 32);
            this.arrTimeLbl.TabIndex = 16;
            this.arrTimeLbl.Text = "Time (hour):";
            // 
            // arrDateLbl
            // 
            this.arrDateLbl.AutoSize = true;
            this.arrDateLbl.Location = new System.Drawing.Point(288, 514);
            this.arrDateLbl.Name = "arrDateLbl";
            this.arrDateLbl.Size = new System.Drawing.Size(54, 32);
            this.arrDateLbl.TabIndex = 15;
            this.arrDateLbl.Text = "Date:";
            // 
            // arrDatePicker
            // 
            this.arrDatePicker.CustomFormat = "dd/ mm/ yyyy";
            this.arrDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.arrDatePicker.Location = new System.Drawing.Point(360, 514);
            this.arrDatePicker.Name = "arrDatePicker";
            this.arrDatePicker.Size = new System.Drawing.Size(197, 39);
            this.arrDatePicker.TabIndex = 14;
            this.arrDatePicker.UseWaitCursor = true;
            this.arrDatePicker.Value = new System.DateTime(2021, 4, 20, 0, 0, 0, 0);
            // 
            // arrTownCombo
            // 
            this.arrTownCombo.FormattingEnabled = true;
            this.arrTownCombo.Items.AddRange(new object[] {
            "Arco",
            "Buttek",
            "Camdel",
            "Dertoth",
            "Esmoll"});
            this.arrTownCombo.Location = new System.Drawing.Point(102, 514);
            this.arrTownCombo.Name = "arrTownCombo";
            this.arrTownCombo.Size = new System.Drawing.Size(132, 40);
            this.arrTownCombo.TabIndex = 13;
            this.arrTownCombo.Text = "Arco";
            // 
            // arrTownLbl
            // 
            this.arrTownLbl.AutoSize = true;
            this.arrTownLbl.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrTownLbl.Location = new System.Drawing.Point(31, 514);
            this.arrTownLbl.Name = "arrTownLbl";
            this.arrTownLbl.Size = new System.Drawing.Size(65, 32);
            this.arrTownLbl.TabIndex = 12;
            this.arrTownLbl.Text = "Town: ";
            // 
            // arrivalLbl
            // 
            this.arrivalLbl.AutoSize = true;
            this.arrivalLbl.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrivalLbl.Location = new System.Drawing.Point(347, 452);
            this.arrivalLbl.Name = "arrivalLbl";
            this.arrivalLbl.Size = new System.Drawing.Size(96, 42);
            this.arrivalLbl.TabIndex = 11;
            this.arrivalLbl.Text = "ARRIVAL";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(320, 619);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(223, 93);
            this.calculateBtn.TabIndex = 18;
            this.calculateBtn.Text = "Calculate Quote";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalLbl.Location = new System.Drawing.Point(965, 167);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(333, 390);
            this.totalLbl.TabIndex = 19;
            this.totalLbl.Text = "Base:\r\n\r\nOver 18 hours:\r\n\r\nHigh-powered engine:\r\n\r\nExtra guests:\r\n\r\nUp or downstr" +
    "eam:\r\n\r\nTax:\r\n\r\nGRAND TOTAL:\r\n";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // warningLbl
            // 
            this.warningLbl.AutoSize = true;
            this.warningLbl.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warningLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.warningLbl.Location = new System.Drawing.Point(197, 715);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Size = new System.Drawing.Size(369, 32);
            this.warningLbl.TabIndex = 20;
            this.warningLbl.Text = "Captain License required at the boat pickup.";
            // 
            // billListLbl
            // 
            this.billListLbl.AutoSize = true;
            this.billListLbl.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.billListLbl.Location = new System.Drawing.Point(1360, 167);
            this.billListLbl.Name = "billListLbl";
            this.billListLbl.Size = new System.Drawing.Size(0, 30);
            this.billListLbl.TabIndex = 21;
            // 
            // boatRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 777);
            this.Controls.Add(this.billListLbl);
            this.Controls.Add(this.warningLbl);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.arrTimeCombo);
            this.Controls.Add(this.arrTimeLbl);
            this.Controls.Add(this.arrDateLbl);
            this.Controls.Add(this.arrDatePicker);
            this.Controls.Add(this.arrTownCombo);
            this.Controls.Add(this.arrTownLbl);
            this.Controls.Add(this.arrivalLbl);
            this.Controls.Add(this.depTimeCombo);
            this.Controls.Add(this.depTimeLbl);
            this.Controls.Add(this.depDateLbl);
            this.Controls.Add(this.depDatePicker);
            this.Controls.Add(this.depTownCombo);
            this.Controls.Add(this.depTownLbl);
            this.Controls.Add(this.departureLbl);
            this.Controls.Add(this.enginePowerCounter);
            this.Controls.Add(this.powerLbl);
            this.Controls.Add(this.peopleCounter);
            this.Controls.Add(this.personNumberLbl);
            this.Controls.Add(this.titleLbl);
            this.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "boatRentalForm";
            this.Text = "Boat rental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label personNumberLbl;
        private System.Windows.Forms.DomainUpDown peopleCounter;
        private System.Windows.Forms.DomainUpDown enginePowerCounter;
        private System.Windows.Forms.Label powerLbl;
        private System.Windows.Forms.Label departureLbl;
        private System.Windows.Forms.Label depTownLbl;
        private System.Windows.Forms.ComboBox depTownCombo;
        private System.Windows.Forms.DateTimePicker depDatePicker;
        private System.Windows.Forms.Label depDateLbl;
        private System.Windows.Forms.ComboBox depTimeCombo;
        private System.Windows.Forms.Label depTimeLbl;
        private System.Windows.Forms.ComboBox arrTimeCombo;
        private System.Windows.Forms.Label arrTimeLbl;
        private System.Windows.Forms.Label arrDateLbl;
        private System.Windows.Forms.DateTimePicker arrDatePicker;
        private System.Windows.Forms.ComboBox arrTownCombo;
        private System.Windows.Forms.Label arrTownLbl;
        private System.Windows.Forms.Label arrivalLbl;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label warningLbl;
        private System.Windows.Forms.Label billListLbl;
    }
}

