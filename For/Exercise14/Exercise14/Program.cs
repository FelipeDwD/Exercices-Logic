using System;
using System.Globalization;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            /***          
             Developing a program that asks for the name, grade 1, and grade 2 of 15 students in a class, and at the end, 
             shows the total grade average, each student's name, grade, and pass status. an average of 6.0 or more is required
             **/


            Student[] students = new Student[15];            
            double averageClass = 0.0;
            string report = "";

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write($"Type the name of {(i + 1)}º student: ");
                string name = Console.ReadLine();

                Console.Write($"Type the note 1 of student {name}: ");
                double note1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write($"Type the note 2 of student {name}: ");
                double note2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                students[i] = new Student(name, note1, note2);

                averageClass += students[i].Average;

                report += students[i];

                Console.Clear();
            }

            averageClass /= students.Length;

            Console.WriteLine($"Total of average class: \n" +
                $"{averageClass.ToString("F2", CultureInfo.InvariantCulture)}\n\n" +
                $"Students:\n\n " +
                $"{report}");

           
        }
    }
}
