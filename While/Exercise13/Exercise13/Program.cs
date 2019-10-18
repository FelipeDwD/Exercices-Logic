using System;
using System.Globalization;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {

            double number = 0;
            double bigger = 0;
            double smaller = 0;

            double average = 0;
            int count = 0;

            while (number != (-1))
            {
                Console.WriteLine("Type a decimal number our -1 to exit: ");
                number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (count == 0)
                {
                    smaller = number;
                    bigger = number;
                }
                else
                {
                    if (number > bigger && number != (-1))
                    {
                        bigger = number;
                    }

                    if (number < smaller && number != (-1))
                    {
                        smaller = number;
                    }
                }

                if (number != (-1))
                {
                    average += number;
                }                
                count++;
            }

            average /= count;

            Console.WriteLine($"Bigger: {bigger}" +
                $"\nSmaller: {smaller}" +
                $"\nAverage: {average.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
