using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Project_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            const int ROW = 3; //Number of rows
            const int COL = 3; //Number of columns
            int[,] TTT = new int[ROW, COL]; //Create int Array
            int val; //random value var

            Random rand = new Random(); //create random object

            //loops for adding rand values to array and updating MainForm
            for (int y=0; y<ROW; y++ ) //looping rows
            {
                for (int x = 0; x < COL; x++) //looping columns
                {
                    val = rand.Next(2); //get random value
                    TTT[x, y] = val; //update value in array
                    if (val == 1) //Label update (X or O)
                    {
                        ((Label)this.Controls.Find("array" + x.ToString() + y.ToString() + "Label",true)[0]).Text = "X";
                    }
                    else
                    {
                        ((Label)this.Controls.Find("array" + x.ToString() + y.ToString() + "Label", true)[0]).Text = "O";
                    }

                }
            }
            //These are used to sum each row, column and diagonal (sum of 3 = X winner, sum of 0 = O winner)
            //If array was larger I would have used a for loop to get sum.
            int line1 = TTT[0, 0] + TTT[0, 1] + TTT[0, 2]; //row0 sum
            int line2 = TTT[1, 0] + TTT[1, 1] + TTT[1, 2]; //row1 sum
            int line3 = TTT[2, 0] + TTT[2, 1] + TTT[2, 2]; //row2 sum
            int line4 = TTT[0, 0] + TTT[1, 0] + TTT[2, 0]; //col0 sum
            int line5 = TTT[0, 1] + TTT[1, 1] + TTT[2, 1]; //col1 sum
            int line6 = TTT[0, 2] + TTT[1, 2] + TTT[2, 2]; //col2 sum
            int line7 = TTT[0, 0] + TTT[1, 1] + TTT[2, 2]; //diag1 sum
            int line8 = TTT[2, 0] + TTT[1, 1] + TTT[0, 2]; //diag2 sum

            //added line sums to list so I can sort and get the winner
            List<int> winCheck = new List<int> { line1, line2, line3,line4,line5,line6,line7,line8 };
            winCheck.Sort();// List sorted

            if ((winCheck[0] == 0 && winCheck[7] == 3)||(winCheck[0] != 0 && winCheck[7] != 3)) //Check for tie
            {
                outputLabel.Text = "Tie!!!"; //update label with winner
            }
            else if (winCheck[0] == 0 && winCheck[7] != 3) //Check first and last position to see if O wins
            {
                outputLabel.Text = "Player O Wins!!!"; //update label with winner
            }
            else if (winCheck[0] != 0 && winCheck[7] == 3) //Check first and last position to see if X wins
            {
                outputLabel.Text = "Player X Wins!!!"; //update label with winner
            }
            
            //used MessageBox to verify my results
            //MessageBox.Show(line1.ToString() + " " + line2.ToString() + " " + line3.ToString() + " " + line4.ToString() + " " + line5.ToString() + " " + line6.ToString() + " " + line7.ToString() + " " + line8.ToString());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Close the application
        }
    }
}
