using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Develop a program that allows the student to answer which is the capital of Brazil. 
             * The program should display whether the answer is right or wrong.
             * */

            Console.WriteLine("What is the capital of Brazil?");

            string city = Console.ReadLine();

            if (city.Equals("Brasília") || city.Equals("brasília"))
            {
                Console.WriteLine("you're right!");
            }
            else
            {
                Console.WriteLine("you missed!");
            }
        }
    }
}
