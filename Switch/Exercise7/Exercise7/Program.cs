using System;
using System.Globalization;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
               * Develop a program that asks the user two numbers (can be decimal).

                And then ask what the user wants to do with the numbers:

                a - Artimetric mean between numbers entered;
                b - Difference from largest to smallest;
                c - Product between numbers entered;
                d - Division of the first by the second;
             **/


            double[] numbers = new double[2];
            double result = 0.0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Type the {(i + 1)}º number: ");
                numbers[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine($"What do you wanna do with the numbers {numbers[0]} and {numbers[1]}:\n" +
                $"[a] - Artimetric mean between numbers entered" +
                $"\n[b] - Difference from largest to smallest" +
                $"\n[c] - Product between numbers entered" +
                $"\n[d] - Division of the first by the second");

            string opcaoUser = Console.ReadLine();

            switch (opcaoUser)
            {
                case "a":
                    result = (numbers[0] + numbers[1]) / 2;
                    break;

                case "b":
                    if (numbers[0] > numbers[1])
                    {
                        result = numbers[0] - numbers[1];
                    }
                    else if(numbers[1] > numbers[0])
                    {
                        result = numbers[1] - numbers[0];
                    }
                    else
                    {
                        Console.WriteLine("Equals numbers!");
                    }
                    break;

                case "c":
                    result = numbers[0] * numbers[1];
                    break;

                case "d":
                    result = numbers[0] / numbers[1];
                    break;

                default:
                    Console.WriteLine("Inválid code!");
                    break;
            }

            Console.WriteLine($"\n\n" +
                $"Result: {result}");
        }
    }
}
