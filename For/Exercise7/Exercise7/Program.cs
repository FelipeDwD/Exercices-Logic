using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that presents at the end the sum of the existing even values ​​in the range 3 to 21
             **/

            int sum = 0;

            for (int i = 3; i <= 21; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
