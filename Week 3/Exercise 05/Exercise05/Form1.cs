using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise05
{
    public partial class ApproximatePiForm : Form
    {
        public ApproximatePiForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Zack Chambers

            //CST-117

            //07/28/2019

            int numberTerms;

            if (int.TryParse(numberTermsTextBox.Text, out numberTerms))
            {
                double pi = 4;
                
                if (numberTerms == 1) //Pi is 4 after only one term, so that is displayed here
                {
                    termsLabel.Text = "Approximate value of Pi after 1 term: ";
                }
                else if (numberTerms > 1 && numberTerms <= int.MaxValue)
                {
                    long denominator = 3;
                    bool addSubtract = false; //false sets symbol to subtract, true sets symbol to add.

                    termsLabel.Text = "Approximate value of Pi after " + numberTerms.ToString() + " terms:";
                    
                    for (int i = 2; i <= numberTerms; i++)
                    {
                        switch (addSubtract)
                        {
                            //false causes subtraction, true causes addition
                            case false:
                                pi = pi - ((double)4 / denominator);
                                denominator += 2;
                                addSubtract = !addSubtract;
                                break;

                            case true:
                                pi = pi + ((double)4 / denominator);
                                denominator += 2;
                                addSubtract = !addSubtract;
                                break;

                        }
                    }
                }

                approximationLabel.Text = pi.ToString();
            }
            else
            {
                //Parse has failed.
                MessageBox.Show("Invalid input for the number of terms. It must be a whole number between 1 and " + int.MaxValue.ToString());
            }
        }
    }
}
