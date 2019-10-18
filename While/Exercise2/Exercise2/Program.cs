using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program what show the numbers of 100 to 1 in decrecent order.
             **/

            int number = 100;

            while (number >= 1)
            {
                Console.WriteLine(number);
                number--;
            }
        }
    }
}
