using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that presents the value of a power of any base raised to any exponent, that is, b ^ e, 
             * where the values ​​of b and e are provided by the user without using Math.pow ().
             **/


            Console.WriteLine("Type a integer number to used with based: ");
            int based = int.Parse(Console.ReadLine());

            Console.WriteLine("Type a integer number to used with potency: ");
            int potency = int.Parse(Console.ReadLine());

            
            int r = based;
            

            for (int i = 1; i < potency; i++)
            {                
                r *= based;
            }
            Console.WriteLine($"{based}^{potency} = {r}");
            
        }
    }
}
