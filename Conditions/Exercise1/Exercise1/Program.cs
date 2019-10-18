using System;


namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Develop a program that asks a number. If this number is greater than 20, 
             * then it should display half of this number, otherwise it should display 
             * the number without changes.
             */

            Console.WriteLine("Type a number: ");

            float number = float.Parse(Console.ReadLine());

            if (number > 20.0)
            {
                number /= 2;
            }

            Console.WriteLine(number);
        }
    }
}
