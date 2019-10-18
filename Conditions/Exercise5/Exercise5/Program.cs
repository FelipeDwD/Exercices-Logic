using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that asks 4 student grades, displays a pass or fail message along with the total grade, 
             * for the student to pass the grade must be greater than or equal to 5.
             **/

            Console.WriteLine("Type the first note");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Type the second note");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Type the third note");
            double n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Type the fourth note");
            double n4 = double.Parse(Console.ReadLine());

            double average = (n1 + n2 + n3 + n4) / 4;

            string approved = "";
            if (average >= 5.0)
            {
                approved = "Approved!";
            }
            else
            {
                approved = "don´t approved!";
            }
            
            Console.WriteLine($"\n\n{approved} \n{average:F}");

        }
    }
}
