using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Develop a program that asks for a number and shows that number's multiplication table
             **/

            Console.WriteLine("Type a integer number: ");
            int number = int.Parse(Console.ReadLine());
            int multiplication = 0;
            int numberMultiplication = 1;

            while (numberMultiplication <= 10)
            {
                multiplication = number * numberMultiplication;
                Console.WriteLine($"{number} x {numberMultiplication} = {multiplication}");
                numberMultiplication++;
            }
        }
    }
}
