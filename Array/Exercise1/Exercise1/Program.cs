using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Create 2 vectors called name and profession, each with 5 elements. Ask the user for the name 
             * and profession of 5 people and fill in these vectors. At the end display a report indicating the 
             * name and profession of each of the 5 people registered.
             **/

            string[] profession = new string[5];
            string[] people = new string[5];
            string report = "Id  -  Name  - Profession:";

            for (int i = 0; i < profession.Length; i++)
            {
                Console.WriteLine($"People: {(i + 1)}");
                Console.Write("Type the name of people: ");
                people[i] = Console.ReadLine();
                Console.Write($"Type the profession of {people[i]}:");
                profession[i] = Console.ReadLine();

                Console.Clear();

                report += $"\n{(i + 1)} - {people[i]} - {profession[i]}";
            }

            Console.WriteLine(report);
        }
    }
}
