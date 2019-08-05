//Name: Zack Chambers
//Class: CST-117
//Instructor: Dominga Gardner
//Date: 08/04/2019

using System;
using System.Windows.Forms;

namespace Exercise06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Die leftDie = new Die(6);
            Die rightDie = new Die(6);
            bool snakeEyes = false;


            int leftDi = 0;
            int rightDi = 0;

            leftDie.numberOfSides = 6;

            while (!snakeEyes)
            {
                textBox1.Text = ("1");
                textBox2.Text = ("1");
                leftDi = leftDie.rollDie();
                rightDi = rightDie.rollDie();
                if ((leftDi == rightDi) && (leftDi == 1))
                {
                    //change this to false - will be an endless and the program will crash, not recommended!
                    snakeEyes = true;
                    label1.Text = (" It took, " + leftDie.rollCount + " rolls to get Snake Eyes");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
