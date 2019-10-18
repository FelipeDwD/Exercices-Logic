using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that asks any integer and makes sure it is in the range 1 to 10
             * */

            Console.WriteLine("Type a integer value");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("The number it is in range the 1 the 10.");
            }
            else
            {
                Console.WriteLine("The number don´t it is in range the 1 the 10.");
            }
        }
    }
}
