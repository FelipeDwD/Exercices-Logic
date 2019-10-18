using System;
using System.Globalization;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that asks five elements of a vector a. At the end, present the sum of all elements of this vector.
             **/

            double[] a = new double[5];
            double sum = 0.0;

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Type the value of {i+1}º element: ");
                a[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += a[i];
            }
            Console.WriteLine($"Sum of elements: {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
