using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Create a vector called week with 7 elements already containing all the names over 
             * the days of the week. Then ask the user for a number and present the corresponding day
             * of the week in the vector, if number is invalid displaying a message, "invalid day".
             **/

            string[] week = {"sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday"};

            Console.Write($"Type a number to day of week: ");
            int day = int.Parse(Console.ReadLine());

            while (day < 1 || day > 7)
            {
                Console.WriteLine($"Don´t exist day {day} in week. Try again!");
                day = int.Parse(Console.ReadLine());
            }
            

            Console.WriteLine($"{week[(day - 1)]}");
        }
    }
}
