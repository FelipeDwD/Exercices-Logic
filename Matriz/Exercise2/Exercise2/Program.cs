using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Make a program to read two integers X and Y, and then read an array of order X rows by Y columns containing integers, 
             * and there may be repetitions. Then read an integer A. If A exists in the matrix should be displayed each occurrence of it, 
             * show the values ​​on the left, above, right, and below A, if A does not exist in the matrix a message should be displayed.
             **/

            Console.Write("Enter the number of rows in the matrix: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns in the matrix: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] mat = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Enter a value to fetch from the array: ");
            int value = int.Parse(Console.ReadLine());
            int count = 0;
            bool exist = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mat[i, j] == value)
                    {
                        count++;
                        int right = j + 1;
                        int left = j - 1;
                        int top = i - 1;
                        int down = i + 1;
                        Console.WriteLine($"{count}º result: ");
                        Console.WriteLine($"Position: [{i}],[{j}]");
                        if (right < columns)
                        {
                            Console.WriteLine($"Right: {mat[i, right]}");
                        }
                        else
                        {
                            Console.WriteLine("Right: Limit!");
                        }

                        if (left >= 0)
                        {
                            Console.WriteLine($"Left: {mat[i, left]}");
                        }
                        else
                        {
                            Console.WriteLine("Left: Limit!");
                        }
                        if (down < rows)
                        {
                            Console.WriteLine($"Down: {mat[down, j]}");
                        }
                        else
                        {
                            Console.WriteLine("Down: Limit!");
                        }
                        if (top >= 0)
                        {
                            Console.WriteLine($"Top: {mat[top, j]}");
                        }
                        else
                        {
                            Console.WriteLine("Top: Limit!");
                        }
                        exist = true;

                        Console.WriteLine();
                    }                  
                }
            }
            if (exist == true)
            {
                Console.WriteLine($"Total: {count}");
            }
            else
            {
                Console.WriteLine($"This number don´t exist in matrix!");
            }
            

        }
    }
}
