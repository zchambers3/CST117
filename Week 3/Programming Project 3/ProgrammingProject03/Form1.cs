using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Zack Chambers

//CST-117

//07/28/2019

namespace ProgrammingProject03
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            //check if a file was opened.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Declare variables
                String readText;
                String[] currentWord;
                String firstWordAlphabetically = ""; //Set to zzzzzzzz to ensure that nearly any value will precede when compared.
                String lastWordAlphabetically = ""; //See above.
                String longestWord = "";
                String mostVowels = "";
                char[] wordCharArray;
                int currentVowelCount;
                int mostVowelCount = 0;

                //Clear the list box
                statsListBox.Items.Clear();

                try
                {
                    //Setup for file system.
                    StreamReader textFile = new StreamReader(openFileDialog.FileName);
                    StreamWriter saveFile = File.CreateText("Statistics.txt");

                    while (!textFile.EndOfStream)
                    {
                        //load the file, convert it to lower case
                        readText = textFile.ReadLine();
                        readText = readText.ToLower();
                        //Split the line into an array of Strings in case the line contains more than one word
                        currentWord = readText.Split(' ');

                        //loop to analyze the current word within the array
                        for (int i = 0; i < currentWord.Length; i++)
                        {

                            currentVowelCount = 0;
                            //Character array for searching for vowels.
                            wordCharArray = currentWord[i].ToCharArray();
                            
                            //Compare the String in currentWord[i] to the current first word alphabetically.
                            if (firstWordAlphabetically == "")
                            {
                                //Protection from initial value overriding the predicted outcome
                                firstWordAlphabetically = currentWord[i];
                            }
                            else if (currentWord[i].CompareTo(firstWordAlphabetically) < 0)
                            {
                                //If it's first alphabetically, assign the word to its appropriate String variable.
                                firstWordAlphabetically = currentWord[i];
                            }
                            
                            if (lastWordAlphabetically == "")
                            {
                                lastWordAlphabetically = currentWord[i];
                            }
                            else if (currentWord[i].CompareTo(lastWordAlphabetically) > 0)
                            {
                                lastWordAlphabetically = currentWord[i];
                            }

                            //Find the longest word.
                            if (longestWord == "")
                            {
                                longestWord = currentWord[i];
                            }
                            else if (longestWord.Length < currentWord[i].Length)
                            {
                                longestWord = currentWord[i];
                            }

                            //find any vowels within the word and count them
                            for (int j = 0; j < wordCharArray.Length; j++)
                            {
                                if (wordCharArray[j] == 'a' ||
                                wordCharArray[j] == 'e' ||
                                wordCharArray[j] == 'i' ||
                                wordCharArray[j] == 'o' ||
                                wordCharArray[j] == 'u')
                                {
                                    currentVowelCount++;
                                }
                            }

                            //Compare for the most vowels.
                            if (currentVowelCount > mostVowelCount)
                            {
                                mostVowelCount = currentVowelCount;
                                mostVowels = currentWord[i];
                            }
                        }
                    }

                    //Write items to the list box.
                    statsListBox.Items.Add("First word alphabetically: " + firstWordAlphabetically);
                    statsListBox.Items.Add("Last word alphabetically: " + lastWordAlphabetically);
                    statsListBox.Items.Add("Longest word: " + longestWord + " at " + longestWord.Length + " characters.");
                    statsListBox.Items.Add("Word with the most vowels: " + mostVowels + " with " + mostVowelCount + " vowels");

                    //save the file to another file

                    saveFile.WriteLine("First word alphabetically: " + firstWordAlphabetically);
                    saveFile.WriteLine("Last word alphabetically: " + lastWordAlphabetically);
                    saveFile.WriteLine("Longest word: " + longestWord + " at " + longestWord.Length + " characters.");
                    saveFile.WriteLine("Word with the most vowels: " + mostVowels + " with " + mostVowelCount + " vowels");

                    saveFile.Close();
                    textFile.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
