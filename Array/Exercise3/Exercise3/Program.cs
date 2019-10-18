using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that asks for five integer elements of a vector a. 
             * At the end, present the sum of all the odd elements.
             **/

            int[] a = new int[5];
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {                
                Console.Write($"Type the {i+1}º integer number: ");
                a[i] = int.Parse(Console.ReadLine());

                //Validation to check if odd
                if (a[i] % 2 != 0)
                {
                    sum += a[i];
                    Console.WriteLine($"{a[i]} is odd, added in vector a");
                }
               
            }

            Console.WriteLine($"Sum total of integers number in vector a: {sum}");
        }
    }
}
