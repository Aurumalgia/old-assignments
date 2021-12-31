using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BoatRental
{
    public partial class Form1 : Form
    {
        //create enum for combobox Depart town and Arrival town
        public enum RiverTowns
        {
            Arco,
            Buttek,
            Camdel,
            Dertoth,
            Esmoll
        }

        public Form1()
        {
            //sest window form when open
            InitializeComponent();
            this.Size = new Size(750, 750);//set window size
            //set departure combobox with enum
            DepartComboBox.DataSource = Enum.GetValues(typeof(RiverTowns));
            //set arrival combobox with enum
            ArrivalComboBox.DataSource = Enum.GetValues(typeof(RiverTowns));
            //set combobox to Buttek
            ArrivalComboBox.Text = "Buttek";
            //set person combobox from 1 to 6
            PersonComboBox.Items.AddRange(Enumerable.Range(1, 6).Cast<object>().ToArray());
            //start person combobox to 1
            PersonComboBox.Text = Convert.ToString(1);
            //set engine combobox from 1 to 4
           EngineComboBox.Items.AddRange(Enumerable.Range(1, 4).Cast<object>().ToArray());
            //start engine combobox to 1
            EngineComboBox.Text = Convert.ToString(1);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set the date to current and time to 1 hour a head
            DepartDatePicker.Value = DateTime.Today;//set date to current
            //set Departure date & time format to custom date and time
            DepartDatePicker.Format = DateTimePickerFormat.Custom;
            DepartDatePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            //set hour 1 ahead
            DepartDatePicker.Value = DateTime.Now.AddHours(1);
            //set Arrival date & time format to custom date and time
            ArrivalDatePicker.Value = DateTime.Today;
            ArrivalDatePicker.Format = DateTimePickerFormat.Custom;
            ArrivalDatePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            //set hour 1 ahead
            ArrivalDatePicker.Value = DateTime.Now.AddHours(1);
        }
        private void DepartComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ArrivalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PersonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DepartHourCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CalButton_Click(object sender, EventArgs e)
        {
            //Set hidden labels visible to true
            personLabel.Visible = true;
            TotalLabel.Visible = true;
            GrandTotalLabel.Visible = true;
            BasepayLabel.Visible = true;
            TaxLabel.Visible = true;
            EngineCalLabel.Visible = true;
            DockCalLabel.Visible = true;
            label9.Visible = true;
            DaysLabel.Visible = true;
            HoursCostLabel.Visible = true;
            
            //Convert combobox to int for constructor
            int perNum = Convert.ToInt32(PersonComboBox.Text);
            int level = Convert.ToInt32(EngineComboBox.Text);
            //variable set for constructor
            double totalCost = 0.0;
            int hourTotal = 0;
            //call class1
            Class1 rental = new Class1(perNum, level, DepartComboBox.Text, ArrivalComboBox.Text, totalCost, hourTotal);
            //variable for each charges
            double baseCost = 179.99, personCharge = 0.0, hourCost = 0.0;
            double levelCharge, dockCost, taxTotal, grandTotal;
            
            //If loop if user pick 4 or more passangers    
            if (perNum > 3)
                {   //calculate charges per extra passangers
                    personCharge = rental.PeopleCharge((perNum));
                    personLabel.Text = "Extra passanger charge: " + "$" + Convert.ToString(personCharge);
                }
                 //else 3 and under personCharge is set to 0
                else if (perNum <= 3)
                {   
                    personCharge = 0.0;
                    personLabel.Text = "Extra passanger charge: " + "$" + Convert.ToString(personCharge);
                }
            
            //If loop if user pick engine level 2 and over
            if (level > 1)
                {   //calculate charges for each level
                    levelCharge = rental.LevelCharge(level);
                    EngineCalLabel.Text = "Extra engine level charge: " + "$" + Convert.ToString(levelCharge);
                }
                else //level 1 levelCharge set at 0.0
                    {
                       levelCharge = 0.0;
                       EngineCalLabel.Text = "Extra engine level charge: " + "$" + Convert.ToString(levelCharge);
                    }

            //set Class1 method TownCost with both depart and arriavl town combobox
            dockCost = rental.TownCost(DepartComboBox.Text, ArrivalComboBox.Text);
            //set label with return calculation
            DockCalLabel.Text = "Dock segment cost: " + "$" + Convert.ToString(dockCost);
            //set DateTime from both Depart and Arrival DateTimePicker
            DateTime inTime = Convert.ToDateTime(DepartDatePicker.Text);
            DateTime outTime = Convert.ToDateTime(ArrivalDatePicker.Text);
            
            //if loop Arrival DateTime text is larger that Depart DateTime text
            if (outTime >= inTime)
                {  //calculate hours between both dates
                    DaysLabel.Text = outTime.Subtract(inTime).TotalHours.ToString();
                }
            
            //convert hours to int
            hourTotal = Convert.ToInt32(DaysLabel.Text);
            
            //if loop if hourTotals is over 18
            if (hourTotal > 18)
                {
                    //calculate charges for each hours
                    hourCost = rental.hoursCharge(hourTotal);
                    HoursCostLabel.Text = "Hours charge over 18 hours: " + "$" + Convert.ToString(hourCost);
                }
                else
                    {   //set hourCost to 0.0 if under 18 hours
                        hourCost = 0.00;
                        HoursCostLabel.Text = "Hours charge over 18 hours: " + "$" + Convert.ToString(hourCost);
                    }
            //Add cost for tax calculation
            totalCost = baseCost + personCharge + levelCharge + dockCost + hourCost;
            //calculate taxes
            taxTotal = rental.taxesTotal(totalCost);
            //set label to tax calculations
            TaxLabel.Text ="Taxes Total:" + "$" + Convert.ToString(taxTotal);
            //add all cost for grand total
            grandTotal = totalCost + taxTotal;
            //set label for grand total cost
            GrandTotalLabel.Text = "$" + Convert.ToString(grandTotal);
            //set label with base cost
            BasepayLabel.Text = "Basepay: " + "$" + baseCost;
            
        }

        private void DepartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            

        }
    }
}
