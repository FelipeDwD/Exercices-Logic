using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Develop a program what asks integer number and show if he is negative or positive.
             * **/

            Console.WriteLine("Type a number integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1)
            {
                Console.WriteLine("The number is positive!");
            }else if (number == 0)
            {
                Console.WriteLine("The number is null!");
            }
            else
            {
                Console.WriteLine("The number is negative!");
            }
        }
    }
}
