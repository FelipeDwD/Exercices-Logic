using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
           * 
          Develop a program that receives two integer values ​​from the user. The first value will be for him to 
          choose the number of rows of an array, and the second the number of columns of the same.

          * The array must be of integer type;

          At the end display:

          * All even values;

          * All odd values;

          * The ordered matrix.
           **/


            Console.Write("Enter the number of rows in the matrix: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter a number of matrix columns: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] mat = new int[rows, columns];

            int pair = 0;
            int odd = 0;

            string displayMatrix = "";


            //Getting array values
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter value\n" +
                        $"[{i}][{j}]" +
                        $"\n: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Checking Even and Odd Values
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mat[i, j] % 2 == 0)
                    {
                        pair++;
                    }
                    else
                    {
                        odd++;
                    }
                }
            }

            //Loop to feed the variable that the matrix will be displayed
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    displayMatrix += $"{mat[i, j]} ";
                }
                displayMatrix += "\n";
            }

            Console.WriteLine($"Amount of values ​​pair: {pair}\n" +
                $"Amount of values odd: {odd}\n" +
                $"Matrix:\n{displayMatrix}");
        }
    }
}
