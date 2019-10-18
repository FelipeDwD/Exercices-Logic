using System;

namespace Exercise11
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

            NOTE: Do without using Math.Pow ();
            **/


            int _base = 3;
            int potency = 0;

            double result = _base;
            string display = "";


            if (potency == 0)
            {
                result = 1;
            }

            while (potency <= 15)
            {

                for (int i = 1; i < potency; i++)
                {
                    result *= _base;
                }
                display += $"3 raised to { potency} = {result}\n";
                result = _base;
                potency++;
            }
            Console.WriteLine(display);





        }
    }
}
