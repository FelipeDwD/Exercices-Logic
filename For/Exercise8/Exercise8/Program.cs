using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Develop a program that asks 5 times a person's full name, gender and age, and displays 
             * the full name of people who are male and 21 or older.
             **/
            string men21 = "";
            int codReport = 1;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Type the name of people: ");
                string nameComplete = Console.ReadLine();
                Console.WriteLine("Type the sex of people: ");
                char sexo = char.Parse(Console.ReadLine());
                Console.WriteLine("Type the age of people: ");
                int age = int.Parse(Console.ReadLine());
                Console.Clear();

                if (sexo.Equals('m') && age >= 21)
                {
                    men21 += $"{codReport} - {nameComplete}\n";
                    codReport++;
                }
            }
            if (men21.Equals(""))
            {
                Console.WriteLine("Don´t exists people´s with this parameters");
            }
            else
            {
                Console.WriteLine(men21);
            }
            
        }
    }
}
