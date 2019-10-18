using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that asks for a positive or negative integer value. 
             * And display as a response the modulus of this value, ie the number as positive
             * **/

            Console.WriteLine("Type a integer number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                number *= -1;
                Console.WriteLine($"Number converted to positive: {number}");
            }
            else
            {
                Console.WriteLine("The number is already positive");
            }
        }
    }
}
