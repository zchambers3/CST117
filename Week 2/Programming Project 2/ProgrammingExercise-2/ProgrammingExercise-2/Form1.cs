using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string state;

            if(stateListBox.SelectedIndex !=-1)
            {
                state = stateListBox.SelectedItem.ToString();

                switch (state)
                {
                    case "California":
                        timeZoneLabel.Text = "Pacific";
                        break;

                    case "Delaware":
                        timeZoneLabel.Text = "Eastern";
                        break;


                    case "Hawaii":
                        timeZoneLabel.Text = "Eastern";
                        break;


                    case "Wyoming":
                        timeZoneLabel.Text = "Mountain";
                        break;

                    case "Texas":
                        timeZoneLabel.Text = "Central";
                        break;

                }

            }
            else
            {
                MessageBox.Show("Select a Correct State from the Selection");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (blueRadioButton.Checked)
                {
                this.BackColor = Color.Blue;

            }

        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (normalRadioButton.Checked)
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void pinkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pinkRadioButton.Checked)
            {
                this.BackColor = Color.LightPink;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (nameCheckBox.Checked)
            {
                Console.Write("This is America");
            }
        }

        private void dateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dateCheckBox.Checked)
            {
                Console.Write("Yeet");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            if (nameCheckBox.Checked == true)
            {
                MessageBox.Show ("You have selected the name box");
            }

            if (dateCheckBox.Checked == true)
            {
                MessageBox.Show ("You have selected the date box.");
            }

            if (nameCheckBox.Checked & dateCheckBox.Checked == true)
            {
                MessageBox.Show("You have selected both Boxes. These are your name and dates."  +
                    " It is November, 4th, 2018 and your name is? ");


            }
            
        }

    }
}
