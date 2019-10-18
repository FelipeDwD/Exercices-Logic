using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that asks for eight elements in a vector a, build a vector b of 
             * the same dimension with the elements of vector a multiplied by 3. Present at the end vector b. 
             * In the display, the element b [1] must be implied by the element a [1] * 3, 
             * the element b [2] implied by the a [2] * 3, and so on, up to 8.
             **/

            int size = 8;
            int[] a = new int[size];
            int[] b = new int[size];
            string outVectB = "";

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Type the {i+1}º value of vector a: ");
                a[i] = int.Parse(Console.ReadLine());
                b[i] = a[i] * 3;
                outVectB += $" {b[i]}" ;
            }
            Console.WriteLine(outVectB);

        }
    }
}
