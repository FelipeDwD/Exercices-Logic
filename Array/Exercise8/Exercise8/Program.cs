using System;
using System.Globalization;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            string reportNotes = "";

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write($"Type the name of {(i+1)}º student: ");
                string nome = Console.ReadLine();

                Console.Write($"Type the note of Pr1 of {nome}: ");
                double pr1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write($"Type the note of Pr2 of {nome}: ");
                double pr2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                students[i] = new Student(nome, pr1, pr2);

                reportNotes += students[i];

                Console.Clear();
            }

            Console.WriteLine(reportNotes);
        }
    }
}
