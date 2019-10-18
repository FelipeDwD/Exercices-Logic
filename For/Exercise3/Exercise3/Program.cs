using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that displays the results of a multiplication table of any number entered by the user (multiplication table).
             * */

            Console.WriteLine("Type a integer number to calculated the multiple table");
            int number = int.Parse(Console.ReadLine());
            int multiplication = 0;

            for (int i = 0; i <= 10; i++)
            {
                multiplication = number * i;
                Console.WriteLine($"{number} x {i} = {multiplication}");
            }
            
        }
    }
}
