using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that asks for a number, present as an answer whether the number is odd or pair
             * */

            Console.WriteLine("Type a number integer: ");

            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("You number is pair.");
            }
            else
            {
                Console.WriteLine("You number is odd.");
            }

        }
    }
}
