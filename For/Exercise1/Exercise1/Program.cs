using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that displays all odd integer values ​​in the range 1000 to 1500.
             **/

            for (int i = 1000; i <= 1500; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
