using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that asks for two integers and displays the difference from largest to smallest
             * */

            Console.WriteLine("Type a integer number: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type another number: ");
            int n2 = int.Parse(Console.ReadLine());

            int output = 0;

            if (n1 != n2)
            {
                if (n1 > n2)
                {
                    output = n1 -= n2;
                }
                else
                {
                    output = n2 -= n1;
                }
                Console.WriteLine(output.ToString());
            }
            else
            {
                Console.WriteLine("The numbers are equals!");
            }
        }
    }
}
