using System;

namespace Exericse2
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that asks for a person's gender and gives the following answer Instructions:

                If male: men's bathroom on the right;
                If not: women's toilet on the left.
            **/

            Console.WriteLine("Wich your sex? " +
                "\n w - woman" +
                "\n m - men");

            string sex = Console.ReadLine();

            switch (sex)
            {
                case "w":
                    Console.WriteLine("female toilet on the left");
                    break;

                case "m":
                    Console.WriteLine("male toilet on the right");
                    break;

            }
        }
    }
}
