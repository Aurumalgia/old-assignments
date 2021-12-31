using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void Count_Click(object sender, EventArgs e)
        {
            String str = inputBox.Text;
            int lowerLetters = 0;
            int numbers = 0;
            for (int i = 0; i < str.Length; i++) {
                if (char.IsLower(str[i]))
                {
                    lowerLetters++;
                }

                else if (char.IsDigit(str[i])) {
                    numbers++;
                }
            }


            lowercaseLabel.Text = $"There are {lowerLetters} lowercase letters";
            numberLabel.Text = $"There are {numbers} numbers";
        }
    }
}
