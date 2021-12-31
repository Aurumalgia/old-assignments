using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4Task1
{
    public partial class Assignment4Task1 : Form
    {
        Car[] cars = new Car[4];
        Label[] carModels;
        Label[] carMPGs;
        Label[] carPositions;
        public Assignment4Task1()
        {
            InitializeComponent();
            carModels = new Label[] {car1Model, car2Model, car3Model, car4Model};
            carMPGs = new Label[] { car1MPGlabel, car2MPGLabel, car3MPGLabel, car4MPGLabel };
            carPositions = new Label[] { position1Label, position2Label, position3Label, position4Label };

        }

       

        private void Submit_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            try
            {
                int position = Int32.Parse(positionBox.Text);
                int mpg;
                try
                {
                    mpg = Int32.Parse(mpgBox.Text);
                }
                catch
                {
                    mpg = -1;
                }
                String model = modelBox.Text;


                if (String.IsNullOrWhiteSpace(model))
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "You didn't put a name in for the model!";
                }
                else if (position > 4 || position < 1) {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Position is out of bounds! Please make sure it's between 1 and 4.";
                } 
                else
                {
                    addCar(position, mpg, model);
                
                }

            }
            catch (FormatException) {
                errorLabel.Visible = true;
                errorLabel.Text = "You forgot to put a number in the position box!";
            }

            

        }

        private void addCar(int position, int mpg, String model) {
            if (mpg >= 0)
            {
                cars[position - 1] = new Car(model, mpg);
            }
            else {
                cars[position - 1] = new Car(model);
            }

            Car[] test = cars;

            updateCar(position-1);
            
        }

        public void updateCar(int position) {
            Car[] test = cars;
            carModels[position].Visible = true;
            carModels[position].Text = cars[position].getModel();
            carMPGs[position].Visible = true;
            carMPGs[position].Text = cars[position].getMPG().ToString();
            carPositions[position].Visible = true;

        }

        private void removeCarButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            try
            {
                int position = Int32.Parse(positionBox.Text);
                if (position > 4 || position < 1)
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Invalid position! Please use a number between 1 and 4.";
                }
                else if (cars[--position] == null) { }
                else
                {
                    cars[position] = null;
                    carModels[position].Visible = false;
                    carMPGs[position].Visible = false;
                    carPositions[position].Visible = false;
                }

            }
            catch (FormatException)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "You forgot to put a number in the position box!";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;

            try
            {
                int position = Int32.Parse(positionBox.Text) - 1;
                if (cars[position] == null)
                {
                    errorLabel.Text = "There's no car at that position!";
                    errorLabel.Visible = true;
                }
                else
                {
                    cars[position]++;
                    updateCar(position);
                }
            }
            catch {
                errorLabel.Visible = true;
                errorLabel.Text = "You forgot to put a number in the position box!";
            }
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;

            try
            {
                int position = Int32.Parse(positionBox.Text) - 1;
                if (cars[position] == null)
                {
                    errorLabel.Text = "There's no car at that position!";
                    errorLabel.Visible = true;
                }
                else
                {
                    cars[position]--;
                    updateCar(position);
                }
            }
            catch
            {
                errorLabel.Visible = true;
                errorLabel.Text = "You forgot to put a number in the position box!";
            }
        }
    }
}
