using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that has the powers of 2, ranging from 0 to 10.
             **/


            double potency = 0;

            for (int i = 0; i <= 10; i++)
            {
                potency = Math.Pow(2, i);
                Console.WriteLine($"2 ^{i} = {potency}");
            }
        }
    }
}
