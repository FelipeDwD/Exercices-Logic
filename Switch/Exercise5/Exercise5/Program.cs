using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a integer number to see day of week: ");
            int dayNumber = int.Parse(Console.ReadLine());
            string day;

            switch (dayNumber)
            {
                case 1:
                    day = "Sunday";
                    break;

                case 2:
                    day = "Monday";
                    break;

                case 3:
                    day = "Tuesday";
                    break;

                case 4:
                    day = "Wednesday";
                    break;

                case 5:
                    day = "Thursday";
                    break;

                case 6:
                    day = "Friday";
                    break;

                case 7:
                    day = "Saturday";
                    break;

                default:
                    day = "Day don´t exists in week!";
                    break;
            }
            Console.WriteLine(day);
        }
    }
}
