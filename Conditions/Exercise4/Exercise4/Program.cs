using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that asks for an integer value and displays that value if it is divisible by 4 and 5. 
             * If it is not divisible by the numbers given, a message should be displayed.
             * */

            Console.WriteLine("Type a integer number: ");

            int number = int.Parse(Console.ReadLine());

            bool div = number % 4 == 0 && number % 5 == 0;

            if (div)
            {
                Console.WriteLine("You number is divisible per 4 and 5.");
            }
            else
            {
                Console.WriteLine("You number don´t visible per 4 and 5");
            }
        }
    }
}
