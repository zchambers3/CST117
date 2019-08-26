using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Project_5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //This form will use user input to generate a lucky number. Their selections will also
        // be used to change the background color. The values will used for the RGB color selection.


        //vars needed from various events
        public int age;
        public int numSelect;
        public int daySelect;
        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            //Vars needed for algorithm
            string val1;
            string val2;
            string val3;
            if (int.TryParse(ageTextBox.Text, out age))//verify if a number is in textbox
            {
                
                if (0 < age && age <= 110)//chech age range
                {
                    val1 = ((0.0845 * Math.Pow(age, 2)) - (9.4182 * age) + 263.33).ToString("n0");//formula for val1 calc
                    val2 = ((Math.Sqrt(age) + 9.4182) / (0.0845 * 2)).ToString("n0");//deriv of var1 formula and solved for y
                    val3 = (0.0845 * 2 * age).ToString("n0");//2nd deriv of var1 formula 
                    if (ageTextBox.TextLength > 0)//verify there is a value in textbox
                    {
                        algoValuesComboBox.Items.Clear();//clear combobox
                    }
                    //add new values to combobox
                    algoValuesComboBox.Items.Add(val1);
                    algoValuesComboBox.Items.Add(val2);
                    algoValuesComboBox.Items.Add(val3);
                    //MessageBox.Show(val1 + " " + val2 + " " + val3);

                }
                else //Clear items in textbox and combobox
                {
                    //MessageBox.Show("Enter an age between 1 and 110.");
                    ageTextBox.Clear();
                    algoValuesComboBox.Items.Clear();
                }
            }
            else if (ageTextBox.Text == "")//Check if all the data has been removed from textbox
            {
                MessageBox.Show("Enter an age between 1 and 110.");//let the user know there was an issue with the input
                algoValuesComboBox.Items.Clear(); //Clear combobox
            }
            else//clear items
            {
                ageTextBox.Clear();
                algoValuesComboBox.Items.Clear();
            }
        }

        private void algoValuesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dayOfWeekComboBox.Items.Clear();//Clear combobox so the list doesn't keep populating
            
            int.TryParse(algoValuesComboBox.SelectedItem.ToString(), out numSelect);//get the number selected 

            //Add the days to the dayOfWeekComboBox
            dayOfWeekComboBox.Items.Add("Sunday");
            dayOfWeekComboBox.Items.Add("Monday");
            dayOfWeekComboBox.Items.Add("Tuesday");
            dayOfWeekComboBox.Items.Add("Wednesday");
            dayOfWeekComboBox.Items.Add("Thursday");
            dayOfWeekComboBox.Items.Add("Friday");
            dayOfWeekComboBox.Items.Add("Saturday");
        }

        private void dayOfWeekComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> dayVal = new List<int> { 200, 100, 50, 0, 170, 120, 250 };
            daySelect = dayVal[dayOfWeekComboBox.SelectedIndex];
            //MessageBox.Show(dayVal[dayOfWeekComboBox.SelectedIndex].ToString());
            //MessageBox.Show(dayOfWeekComboBox.SelectedItem.ToString());

        }

        private void luckyButton_Click(object sender, EventArgs e)
        {
            ResultsForm DisplayMessage = new ResultsForm();//new result form object
            int luckyResult; //var for result
            int.TryParse((Math.Sqrt((age * 2) + numSelect + daySelect)).ToString("n0"), out luckyResult);//set luckyResult value

            DisplayMessage.luckyLabel.Text = luckyResult.ToString(); //set the luckyLabel value in the ResultsForm
            DisplayMessage.BackColor = Color.FromArgb(luckyResult, numSelect, daySelect); //Change the background color using the vars from other events

            if (Math.Pow(luckyResult, 2) <= 250)//if statement needed if background is dark so the text can be change to white
            {
                DisplayMessage.luckyLabel.ForeColor = Color.FromArgb(255, 255, 255);//Changing label colors to white
                DisplayMessage.yourLuckLabel.ForeColor = Color.FromArgb(255, 255, 255);//Changing label colors to white
            }
            DisplayMessage.ShowDialog();//Display the ResultsForm

        }
    }
}
