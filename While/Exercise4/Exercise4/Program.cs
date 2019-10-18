using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program what sum the numbers of range of 1 until 100.
             **/

            int firstNumber = 1;
            int sumNumbers = 0;

            while (firstNumber <= 100)
            {
                sumNumbers += firstNumber;
                firstNumber++;
            }

            Console.WriteLine(sumNumbers);

        }
    }
}
