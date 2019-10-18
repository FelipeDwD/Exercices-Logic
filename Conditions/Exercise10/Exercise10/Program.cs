using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a programa what ask two integer number. Show if the second is divisible by the first.
             * */

            Console.WriteLine("Type a integer number: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type more a number: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 % n2 == 0)
            {
                Console.WriteLine("The first number is divisible by the second.");
            }
            else
            {
                Console.WriteLine("The first number don´t divisible by the second!");
            }
        }
    }
}
