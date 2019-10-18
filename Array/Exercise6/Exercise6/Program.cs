using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that asks 20 elements of a vector a and builds a vector b of the same size 
             * with the same elements a, which must be inverted, that is, the first element of a becomes the last 
             * element of b, and so on. against. Display vectors a and b.
             **/

            int[] a = new int[20];
            int[] b = new int[20];
            int position = 0;
            string vectorA = "";
            string vectorB = "";

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Type the {(i+1)}º integer number: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = b.Length - 1; i >= 0; i--)
            {
                b[position] = a[i];
                position++;
            }

            for (int i = 0; i < a.Length; i++)
            {
                vectorA += $"{a[i]} ";
                vectorB += $"{b[i]} ";
            }

            Console.WriteLine($"{vectorA}" +
                $"\n{vectorB}");
        }
    }
}
