using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class BoatRental : Form
    {

        //Upstream -> Downstream
        String[] cities = { "Arco", "Buttek", "Camdel", "Dertoth", "Esmoll" };
        int maxPeople = 6;
        int minPeople = 1;
        int maxEngPower = 4;
        int minEngPower = 1;




        public BoatRental()
        {
            InitializeComponent();

            for (int i = 0; i < cities.Length; i++)
            {
                arrivalCityComboBox.Items.Add(cities[i]);
                departureCityComboBox.Items.Add(cities[i]);
            }

            for (int i = minPeople; i <= maxPeople; i++)
            {
                passNumComboBox.Items.Add(i.ToString());
            }

            for (int i = minEngPower; i <= maxEngPower; i++)
            {
                enginePowerComboBox.Items.Add(i.ToString());
            }

            warningLabel.Visible = false;
            DTWarning1.Visible = false;
            DTWarning2.Visible = false;
            passNumComboBox.SelectedIndex = 0;
            enginePowerComboBox.SelectedIndex = 0;
            departureCityComboBox.SelectedIndex = 0;
            arrivalCityComboBox.SelectedIndex = 0;
            grandTotalLabel.Visible = false;
            departureTimePicker.Value = DateTime.Now.AddHours(1);
            arrivalTimePicker.Value = DateTime.Now.AddHours(2);
           

            

        }

        double basePrice = 179.99;
        double extraHour = 11.5;
        int startChargeExtraHour = 18;
        double extraEngineLevelCharge = .085;
        double extraPerson = .08;
        double upstreamCharge = 47;

        // keep positive!
        double downstreamDiscount = 30;
        double tax = .0605;
        //Start mus be before 12PM.
        int afterHourStart = 22;
        int afterHourEnd = 6;






        private void arrivalTimePicker_ValueChanged(object sender, EventArgs e)
        {
            checkRequiredLicense();
        }

        private void departureTimePicker_ValueChanged(object sender, EventArgs e)
        {
            checkRequiredLicense();
        }
        

        private void enginePowerComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            checkRequiredLicense();
        }

       
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // reset
            DTWarning1.Visible = false;
            DTWarning2.Visible = false;
            quoteBox.Text = "";
            grandTotalLabel.Visible = false;


            DateTime departure = new DateTime(departureDatePicker.Value.Year, departureDatePicker.Value.Month, departureDatePicker.Value.Day, departureTimePicker.Value.Hour, 0, 0);
            DateTime arrival = new DateTime(arrivalDatePicker.Value.Year, arrivalDatePicker.Value.Month, arrivalDatePicker.Value.Day, arrivalTimePicker.Value.Hour, 0, 0);
            if (departure.CompareTo(arrival) > 0) {
                DTWarning1.Visible = true;
                DTWarning2.Visible = true;
            }
            else
                calculateTotal(departure, arrival);
        }
        private void checkRequiredLicense()
        {
            if (afterHourStart > afterHourEnd)
            {
                if (departureTimePicker.Value.Hour >= afterHourStart || departureTimePicker.Value.Hour <= afterHourEnd || arrivalTimePicker.Value.Hour >= afterHourStart || arrivalTimePicker.Value.Hour <= afterHourEnd || enginePowerComboBox.SelectedIndex == 3)
                {
                    warningLabel.Visible = true;
                }
                else
                {
                    warningLabel.Visible = false;
                }
            }
            else
            {
                if (departureTimePicker.Value.Hour >= afterHourStart && departureTimePicker.Value.Hour <= afterHourEnd || arrivalTimePicker.Value.Hour >= afterHourStart && arrivalTimePicker.Value.Hour <= afterHourEnd || enginePowerComboBox.SelectedIndex == 3)
                {
                    warningLabel.Visible = true;
                }
                else
                {
                    warningLabel.Visible = false;
                }
            }
        
        }

        private void calculateTotal(DateTime departure, DateTime arrival) 
        {
            double total = basePrice;
            quoteBox.AppendText("Base Price: " + basePrice.ToString("C"));
            
            double extraHourCharge = calculateExtraHours(departure, arrival);
            total += extraHourCharge;


            for (int i = 0; i < enginePowerComboBox.SelectedIndex; i++)
            {
                quoteBox.AppendText(Environment.NewLine + (100 * extraEngineLevelCharge).ToString() + "%  Level " + (i+2).ToString() + " Engine Charge: " + (extraEngineLevelCharge * total).ToString("C"));
                total *= (extraEngineLevelCharge + 1);
            }
            double segmentCharge = calculateSegmentChargeDiscount();
            total += segmentCharge;

          
            for (int p = 4; p <= passNumComboBox.SelectedIndex + 1; p++) {
                quoteBox.AppendText(Environment.NewLine + (100 * extraPerson).ToString() + "% charge for person " + p + ": " + (total * extraPerson).ToString("C"));
                total *= (extraPerson + 1);
            }


            quoteBox.AppendText(Environment.NewLine + (100 * tax).ToString() + "% Tax: " + (total * tax).ToString("C"));
            total *= (tax + 1);

            grandTotalLabel.Visible = true;
            grandTotalLabel.Text = "Grand Total: " + total.ToString("C");
        
        }

        private double calculateSegmentChargeDiscount() {
            int segmentAmount = departureCityComboBox.SelectedIndex - arrivalCityComboBox.SelectedIndex;
            double r = 0;
            // if Downstream
            if (segmentAmount < 0)
            {
                r = segmentAmount * downstreamDiscount;
                quoteBox.AppendText(Environment.NewLine + downstreamDiscount.ToString("C") + " * " + (segmentAmount * -1).ToString() + " Downstream Segement Discount: " + r.ToString("C"));
            }
            else 
            {
                r = segmentAmount * upstreamCharge;
                quoteBox.AppendText(Environment.NewLine + upstreamCharge.ToString("C") + " * " + (segmentAmount).ToString() + " Upstream Segment Charge: " + r.ToString("C"));
            }
            return r;

        
        }



        private double calculateExtraHours(DateTime departure, DateTime arrival) {
            TimeSpan interval = arrival - departure;
            double r = 0;
            if (interval.TotalHours > startChargeExtraHour)
            {
                r = (interval.TotalHours - startChargeExtraHour) * extraHour;
                quoteBox.AppendText(Environment.NewLine + extraHour.ToString("C") + " * " + (interval.TotalHours - startChargeExtraHour).ToString() + " Extra Hours above " + startChargeExtraHour + ": " + r.ToString("C"));

            }
            else
                quoteBox.AppendText(Environment.NewLine + extraHour.ToString("C") + " * 0 Extra Hours above " + startChargeExtraHour + ": " + r.ToString("C"));

            return r;



        }


    }
}
