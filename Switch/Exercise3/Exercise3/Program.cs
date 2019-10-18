using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that asks for a number and returns in response if the number is odd or even
             **/


            Console.Write("Type a integer number: ");
            int number = int.Parse(Console.ReadLine());
            double n = number % 2;

            switch (n)
            {
                case 0:
                    Console.WriteLine("This number is pair");
                    break;

                case 1:
                    Console.WriteLine("This number id odd");
                    break;
            }
        }
    }
}
