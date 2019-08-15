using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name: Zack Chambers
//Class: CST-117
//Date: 8/11/19
//Instructor:  Dominga Gardner

namespace Exercise08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonClose(object sender, EventArgs e)
        {
            //Closes the application
            this.Close();
        }

        private void buttonClear(object sender, EventArgs e)
        {
            //Clears all text fields
            textCalorie2Carb.Text = "";
            textFat2Calorie.Text = "";
            textbox2.Text = "";
            textbox1.Text = "";
        }

        private void buttonFat2Calorie(object sender, EventArgs e)
        {
            //Test for double
            double doubleConvert;
            if (!double.TryParse(textFat2Calorie.Text, out doubleConvert))
            {
                //Displays in the text box invalid numbers only
                textFat2Calorie.Text = "Invalid Input, Numbers Only";
            }
            else
            {
                //Calculate calories using method
                textbox1.Text = Convert.ToString(Fat2Calories(doubleConvert));
            }
        }

        //Method to convert fat grams to calories
        public double Fat2Calories(double gramofCalories)
        {
            //Formula provided in text book
            return gramofCalories * 9.0;
        }

        //Method to convert carb grams to calories
        public double Carbs2Calories(double gramofCarbs)
        {
            //Formula provided in text book
            return gramofCarbs * 4.0;
        }

        private void buttonCalorie2Carb(object sender, EventArgs e)
        {
            double doubleConvert;
            if (!double.TryParse(textCalorie2Carb.Text, out doubleConvert))
            {
                //Displays in the text box invalid numbers only
                textCalorie2Carb.Text = "Invalid Input, Numbers Only";
            }
            else
            {
                //Converts the carbs to calories
                textbox2.Text = Convert.ToString(Carbs2Calories(doubleConvert));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}