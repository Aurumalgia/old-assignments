using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2._1
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            int max = Convert.ToInt32(maxBox.Text);
            int min = Convert.ToInt32(minBox.Text);
            List<int> ls = new List<int>();
            for (int i = max; i >= min; i--)
            {
                if (!primeCheck(i) && i >=4)
                {
                    outputBox.AppendText(i.ToString() + ": " + primeFactors(i) + Environment.NewLine);
                }
            }
        }

        private string primeFactors(int n) {
            string str = "";

            while (!primeCheck(n)) 
            {
                if (n % 2 == 0)
                {
                    if (string.IsNullOrEmpty(str))
                    {
                        str += "2";
                        n /= 2;
                    }
                    else
                    {
                        str += " * 2";
                        n /= 2;
                    }
                }

                else
                {
                    for (int i = 3; i < n; i++)
                    {
                        if (primeCheck(i))
                        {
                            if (n % i == 0)
                            {
                                if (string.IsNullOrEmpty(str))
                                {
                                    str += i.ToString();
                                    n /= i;
                                    break;
                                }
                                else
                                {
                                    str += " * " + i.ToString();
                                    n /= i;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            str += " * " + n.ToString();

            return str;
        }


        private bool primeCheck(int n)
        {
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;



            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            int x;
            if (n > 7)
            {
                x = 7;
            }
            else
                x = n;


            for (int i = 5; i * i < n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0) {
                    return false;
                }

            }
            return true;
        }

    }
}
