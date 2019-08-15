using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    class Class1
    {
        //#1 This method returns the value of two integers num1/2
        public static void aSum(int num1, int num2)
        {
            System.Console.WriteLine(num1 + num2);
        }
        //#2 this method will take five doubles and return the average
        public double AvgOfFive(double one, double two, double three, double four, double five)
        {
            System.Console.WriteLine((one + two + three + four + five) / 5.0);
        }
        //#3 Generates random number
        public int RandomNumbers()
        {
            Random numb = new Random();
            int numberOne = numb.Next(100, 1000);
            int numberTwo = numb.Next(1000, 100000);
            System.Console.WriteLine("Random Number 1 = " + numberOne + "/n Random number 2 = ", +numberTwo + " Equal ", (numberOne + numberTwo));
        }
        //#4
        public bool divisibleByThree(int numb1, int numb2, int numb3)
        {
            if (((numb1 + numb2 + numb3) % 3) == 0)
            {
                System.Console.WriteLine(true);
            }
            else
            {
                System.Console.WriteLine(false);
            }
        }
        //#5
        public string whosLongest(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                System.Console.WriteLine(true);
            }
            else
            {
                System.Console.WriteLine(false);
            }
        }
        //#6
        public static void maxArray()
        {
            int[] array = { 1, 3, 5, 7, 9, 11 };
            int highNumb = Enumerable.Range(0, array.Length).Aggregate((max, i) => array[max] > array[i] ? max : i);
            int displayHighNumb = array[highNumb];
            System.Console.WriteLine("The highest number in the array is: " + displayHighNumb);
        }
        //#7 <-- Very wrong, had to comment as I just had difficulties with this one.
        //public static int[] fiftyRandomNumbers();
        //{
        //    Random numbah = new Random();
        //    int[] fiftyRandom = new int[50];
        // 
        //     for (int i = 0; i < 50; i++)
        //    {
        //         int randomNumbah = numbah.Text(1, 100);
        //         fiftyRandom[i] = randomNumbah;
        //     }
        //         System.Console.WriteLine(fiftyRandom);
        // }
        
        //#8
        public bool equalBool(bool bool1, bool bool2)
        {
            if (bool1 == bool2)
            {
                System.Console.WriteLine(true);
            }
            else
            {
                System.Console.WriteLine(false);
            }
        }
        //#9
        Public static var variable()
        {
            var numberz = new double[] { 11, 2.2, 99999999999999, 99.9 };
            var result = numberz.Sum(x => y ? 1);
            System.Console.WriteLine(result);
        }
        //#10 - Probably wrong, very wrong...
        public double twoDArry(int[][] numbahz)
            {
            int arrayValue = 0;
            int allValue = numbahz.Length + numbahz.Length[z].Length;

            for (int a = 0; a < numbahz.Length; a++);
                {
                for (int b = 0; b < numbahz.Length[a].Length; j++)
                arrayValue = arrayValue + numbahz[a][b];
                }
            System.Console.WriteLine("The Array Total Is: " + numbahz + arrayValue);
            }

        }
    }
}