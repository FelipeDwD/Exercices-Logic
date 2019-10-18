using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Develop a program that displays all numbers divisible by 4 and less than 200. To find out if the number 
             * is divisible by 4, you will need to check the logic of this condition with the if statement. 
             * Being divisible, show the number; Otherwise, continue to the next step. The variable that controls 
             * the counter must be started with the value 1.
             **/

            int count = 1;

            while (count <= 200)
            {
                if (count % 4 == 0)
                {
                    Console.WriteLine(count);
                }
                count++;
            }
        }
    }
}
