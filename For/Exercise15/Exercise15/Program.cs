using System;
using System.Globalization;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             Develop a program that asks for the name and salary of 3 people and disregards their salary the 
             tax amount considering the conditions below:

            Salary less than 600.00: exempt
            Salary between 600.00 and 1499.99: 10% of the salary
            Salary from 1500.00: 15% of salary

            At the end display one of the 3 people, showing:

            * Name;
            * Whether to pay tax or not;
            * Salary amount updated.
             **/


            People[] peoples = new People[3];
            string report = "";

            for (int i = 0; i < peoples.Length; i++)
            {
                Console.Write($"Type the name of {(i + 1)}º people: ");
                string name = Console.ReadLine();

                Console.Write($"Type the salary of {name}: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                peoples[i] = new People(name, salary);

                peoples[i].ChargeTax();

                report += peoples[i];
            }

            Console.WriteLine(report);
        }
    }
}
