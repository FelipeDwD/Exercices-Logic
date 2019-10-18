using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that presents all divisible numbers by 5 that are less than 50.
             **/

            for (int i = 0; i <= 50; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
