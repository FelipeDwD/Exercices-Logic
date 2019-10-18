using System;

namespace Exeercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that presents at the end the sum of the even values ​​in the range 0 to 500. 
             * Use a loop that makes the variation of 2 in 2.
             **/

            int number = 0;
            string numbers = "";
            int result = 0;

            while (number < 500)
            {
                number += 2;
                numbers += $"{number}\n";
                result += number;
            }

            Console.WriteLine($"Sum: {result}\n" +
                $"Numbers:\n{numbers}");
        }
    }
}
