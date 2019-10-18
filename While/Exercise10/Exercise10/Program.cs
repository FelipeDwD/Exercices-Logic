using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that has the powers of 3 ranging from 0 to 15. It must be considered 
             * that any number raised to zero is 1, and raised to 1 is itself. The presentation should 
             * observe the following screen display:

            3 raised to 0 = 1
            3 raised to 1 = 3
            3 raised to 2 = 9
            ...
            3 raised to 15 = 14348907

            NOTE: Do it using Math.Pow ();
            **/


            int potency = 0;
            double result = 0;
            string display = "";

            while (potency <= 15)
            {
                result = Math.Pow(3, potency);
                display += $"3 raised to {potency} = {result}\n";
                potency++;
            }

            Console.WriteLine(display);
        }
    }
}
