using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoatRentals
{
    public partial class boatRentalForm : Form
    {
        public boatRentalForm()
        {
            InitializeComponent();
            defaultValues();
        }

        private void defaultValues()
        {
            if (depTimeCombo.SelectedIndex == depTimeCombo.Items.Count)
            {
                depTimeCombo.SelectedIndex = 0;
                arrTimeCombo.SelectedIndex = 0;
            }
            else
            {
                depTimeCombo.SelectedIndex = DateTime.Now.Hour + 1;
                arrTimeCombo.SelectedIndex = DateTime.Now.Hour + 1;
            }

            depDatePicker.Value = DateTime.Today;
            arrDatePicker.Value = DateTime.Today;
            enginePowerCounter.SelectedIndex = enginePowerCounter.Items.Count - 1;
            peopleCounter.SelectedIndex = peopleCounter.Items.Count - 1;
            showWarning();
        }

         private void calculateBtn_Click(object sender, EventArgs e)
                {
                    Quote quote = new Quote(getUpstreamSegments(), getTotalHours(), getEnginePower(), getGuestCount());
            billListLbl.Text = quote.getBill();
                }

        private int getEnginePower()
        {
            return enginePowerCounter.Items.Count - enginePowerCounter.SelectedIndex;
        }

        private int getGuestCount()
        {
            return peopleCounter.Items.Count - peopleCounter.SelectedIndex;
        }
        private int getTotalHours()
        {
            int depHours = Convert.ToInt32(depTimeCombo.Text);
            int arrHours = Convert.ToInt32(arrTimeCombo.Text);
            return ((arrDatePicker.Value - depDatePicker.Value).Days*24) + (arrHours - depHours);
        }

        private int getUpstreamSegments()
        {
            return depTownCombo.SelectedIndex - arrTownCombo.SelectedIndex;
        }

        private void depTimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            showWarning();
        }

        private void arrTimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            showWarning();
        }

        private void showWarning()
        {
            if (depTimeCombo.SelectedIndex < 6 || depTimeCombo.SelectedIndex >= 22)
                warningLbl.Show();
            else if (arrTimeCombo.SelectedIndex < 6 || arrTimeCombo.SelectedIndex >= 22)
                warningLbl.Show();
            else if (getEnginePower() >= 4)
                warningLbl.Show();
            else
                warningLbl.Hide();
        }

        private void enginePowerCounter_SelectedItemChanged(object sender, EventArgs e)
        {
            showWarning();
        }
    }
}
