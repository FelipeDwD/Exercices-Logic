using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that has square numbers from 15 to 200.
             * */

            int number = 15;

            while (number <= 200)
            {
                Console.WriteLine($"{number}^2 = {Math.Pow(number, 2)}");
                number++;
            }
        }
    }
}
