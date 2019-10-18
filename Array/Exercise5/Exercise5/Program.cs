using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Develop a program that asks 5 values ​​of vector a, then create a vector b of the 
             * same size containing the corresponding squared values ​​in vector a. At the end display the 2 vectors.
             */

            int size = 5;
            int[] a = new int[size];
            int[] b = new int[size];
            string outVectorA = "";
            string outVectorB = "";

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Type the {i+1}º integer number to vector a: ");
                a[i] = int.Parse(Console.ReadLine());

                //Casting
                b[i] = (int) Math.Pow(a[i], 2);

                if (i < a.Length - 1)
                {
                    if (b[i] < 10) //Formating output of vector b, to stay parallel witch the vector a.
                    {
                        outVectorA += $"{a[i]} | ";
                    }
                    else
                    {
                        outVectorA += $"{a[i]}  | ";
                    }
                    
                    outVectorB += $"{b[i]} | ";
                }
                else
                {
                    outVectorA += $"{a[i]}";
                    outVectorB += $"{b[i]}";
                }
            }
            Console.WriteLine($"Vector a: {outVectorA}" +
                $"\nVector b: {outVectorB}");
        }
    }
}
