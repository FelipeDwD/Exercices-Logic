using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that asks the user two integers, and stores in two variables "b" and "e". 
             * Since "b" is the power variable, and "e" is the exponent, please do not use Math.Pow ();
             **/

            Console.Write("Type a integer number to used as base: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Type a integer number to used as exponent: ");
            int e = int.Parse(Console.ReadLine());


            int count = 1;
            int result = b;

            if (e == 0)
            {
                result = 1;
            }
            else
            {
                while (count < e)
                {
                    result *= b;
                    count++;
                }
            }            
            Console.WriteLine($"Result: {result}");
        }
    }
}
