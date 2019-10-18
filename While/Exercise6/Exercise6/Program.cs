using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that reads any number n less than or equal to 50 and displays the value obtained 
             * by successively multiplying n by 3 while the product is less than 250. Ex.: (6 x 3; 18 x 3; 54 x 3).
             **/

            Console.WriteLine("Type a integer number smaller or equal 50");
            int number = int.Parse(Console.ReadLine());
            int multiplication = 0;

            while (number < 0 || number > 50)                
            {
                Console.WriteLine("Invalid number. Try again!");
                number = int.Parse(Console.ReadLine());

            }

            while (multiplication <= 250)
            {
                multiplication = number * 3;
                Console.WriteLine($"{number} x 3 = {multiplication}");
                number = 0;
                number += multiplication;
            }
        }
    }
}
