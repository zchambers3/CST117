using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CST_117_Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int charFound = 0; //Used to count the number of e's and t's
                StreamReader inputFile = File.OpenText("Exercise10_File.txt"); //Open the file
                while (!inputFile.EndOfStream)
                {
                    string lineInfo = inputFile.ReadLine(); //Read the line
                    int cnt = 0; //counter needed for indexing

                    foreach (char letter in lineInfo) //use foreach to check each char
                    {
                        if (letter.ToString() == " " || letter.ToString() == "." || letter.ToString() == "!" || 
                            letter.ToString() == "," || letter.ToString() == "?" || letter.ToString() == ";" || 
                            letter.ToString() == ":") //Use if statement to find the end of a word
                        {
                            //Check if E and T are at the end of the word (before space or other punctuation)
                            if ((cnt != 0 && lineInfo[cnt-1].ToString().ToUpper() == "T") || 
                                (cnt != 0 && lineInfo[cnt - 1].ToString().ToUpper() == "E")) 
                            {
                                charFound += 1; //Counter for e and t finds
                            }
                            
                        }
                        cnt += 1;//increment cnt by 1 for index
                    }

                }
                inputFile.Close(); // close the file

                //write the info found and display in console
                Console.WriteLine("There are "+ charFound.ToString()+ " words that end in t or e.");
                Console.WriteLine("Press enter to close...");
                Console.Read();

            }
            catch (Exception EX) //Error catching
            {
                Console.WriteLine(EX.Message); //Display error
                Console.Read();
            }
            
        }
    }
}
