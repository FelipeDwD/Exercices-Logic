using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             *  In the Udemy online course portal, each user has a unique code, represented by an integer.
                Each Udemy portal instructor can have multiple courses, and the same student can enroll in as many
                courses you want. Thus, the total number of students of an instructor is not simply the sum of 
                the students of all
                courses he has, as there may be students repeated in more than one course.
                Instructor Joaquim has three courses A, B and C, and wants to know your total number of students.
                Your program should read students from Instructor Joaquim's courses A, B, and C, then show the 
                total amount and students
                his.
             ***/



            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();
            int cod = 0;
            int amount = 0;

            Console.Write("How many students have course A? ");
            amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student codes for course A: ");

            for (int i = 0; i < amount; i++)
            {
                cod = int.Parse(Console.ReadLine());
                courseA.Add(cod);
            }

            Console.Write("How many students have course B? ");
            amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student codes for course B: ");

            for (int i = 0; i < amount; i++)
            {
                cod = int.Parse(Console.ReadLine());
                courseB.Add(cod);
            }

            Console.Write("How many students have course C? ");
            amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student codes for course C: ");

            for (int i = 0; i < amount; i++)
            {
                cod = int.Parse(Console.ReadLine());
                courseC.Add(cod);
            }

            courseA.UnionWith(courseB);
            courseA.UnionWith(courseC);
            amount = 0;

            foreach (int amountStudents in courseA)
            {
                amount++;
            }

            Console.WriteLine($"Total of students: {amount}");
        }
      
    }
}
