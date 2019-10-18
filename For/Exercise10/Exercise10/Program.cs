using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {

            /***
             * Develop a program that presents the factorial of a number informed by the user.
             **/

            Console.WriteLine("Type a integer number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = (number - 1); i >= 1; i--)
            {
                number *= i;
            }

            Console.WriteLine(number);
        }
    }
}
