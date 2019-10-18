using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Fill in an array using loop and display it as below:

                0123456789
                0123456789
                0123456789
             **/

            int[,] mat = new int[3,10];
            string display = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mat[i, j] = j;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    display += mat[i,j];
                }
                display += "\n";
            }

            Console.WriteLine(display);

        }
    }
}
