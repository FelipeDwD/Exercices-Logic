using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that displays the sum total of n integers from number 1 through n, where n is a user-entered value.
             **/

            Console.WriteLine("Type a integer number for limit calculated: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Total: {sum}");

        }
    }
}
