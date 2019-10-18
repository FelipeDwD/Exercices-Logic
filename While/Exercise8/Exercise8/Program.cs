using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Develop a program that displays all odd integer values ​​in the range 0 to 20. To find out if the number is odd, 
             * you will need to check this condition with the if command. Being odd, show it; If not, continue to the next step.
             **/

            int number = 1;

            while (number <= 20)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
        }
    }
}
