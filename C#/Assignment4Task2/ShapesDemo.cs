using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4Task2
{
    public partial class ShapesDemo : Form
    {
        public ShapesDemo()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            float height = -1;
            float width = -1;

            try
            {
                height = float.Parse(heightBox.Text);
                width = float.Parse(widthBox.Text);

            }
            catch {
                if (height == -1 && width == -1 || (width == -1 || height == -1) && (!squareRadio.Checked)) {
                    errorLabel.Text = "Oh No! There's an invalid input! Please make sure that there is something in both if you're not doing a square area.";
                    errorLabel.Visible = true;
                }
            }

            if (squareRadio.Checked)
            {
                if (height == -1)
                {
                    areaLabel.Text = findArea(new Square(width)).ToString();
                }
                else if (width == -1)
                {
                    areaLabel.Text = findArea(new Square(height)).ToString();
                }
                else if (height != width)
                {
                    errorLabel.Text = "Oh no! The boxes must equal eachother for square, or have one box empty.";
                    errorLabel.Visible = true;
                }
                else
                {
                    areaLabel.Text = findArea(new Square(height, width)).ToString();
                }
            }

            else if (triangleRadio.Checked)
            {
                areaLabel.Text = findArea(new Triangle(height, width)).ToString();
            }
            else {
                areaLabel.Text = findArea(new Rectangle(height, width)).ToString();            
            }
        }

        private float findArea(GeometricFigure g) {
            return g.computeArea();
        }

    }
}
