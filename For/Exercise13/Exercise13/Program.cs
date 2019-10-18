using System;
using System.Globalization;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            const double INCH = 2.54;

            Console.Write("Type the limit of conversions: ");
            int limit = int.Parse(Console.ReadLine());

            double centimetersInches = 0.0;

            string display = "INCHES   -   CENTIMETERS\n";

            for (int i = 0; i < limit; i++)
            {
                centimetersInches += INCH;
                display += $"   {(i + 1)}     -       {centimetersInches.ToString("F2", CultureInfo.InvariantCulture)}\n";
            }

            Console.WriteLine(display);

        }
    }
}
