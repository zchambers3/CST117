//Name: Zack Chambers
//Class: CST-117
//Instructor: Dominga Gardner
//Date: 08/04/2019

using System;

namespace Exercise06
{
    class Die
    {
        Random genRandNumb = new Random();
        public int numberOfSides { get; set; }
        public int rollCount { get; set; }

        public Die()
        {
            numberOfSides = 6;
        }

        public int rollDie()
        {
            rollCount++;
            return genRandNumb.Next(1, numberOfSides + 1);
        }

        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
        }
    }
}