using System;
using System.Globalization;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Develop a program that asks a person's weight and also asks the code of the planet on which they 
             * would like to get their weight value on that planet. The information in the table below (only the Code and Planet columns) 
             * should appear as a user choice menu:

             Code | Planet | Relative Gravity
            ---------------------------------
                1 | Mercury | 0.37
                2 | Venus   | 0.88
                3 | Mars    | 0.38
                4 | Jupiter | 2.64
                5 | Saturn  | 1.15
                6 | Uranus  | 1.17

            To calculate the weight on the chosen planet, use the formula:

            weightNoPlanet = (weightOnEarth / 10) * Relative gravity

            If the user enters a code that is not in the table, inform
            that the code you entered is wrong.
             **/

            double relativeGravity = 0.0;
            double weightPlanet = 0.0;

            Console.WriteLine("Enter your weight: ");
            double weightEarth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string home = "Cod. | Planet" +
                        "\n-----|--------" +
                        "\n 1   | Mercury" +
                        "\n 2   | Venus" +
                        "\n 3   | Mars" +
                        "\n 4   | Jupiter" +
                        "\n 5   | Saturn" +
                        "\n 6   | Uranus";

            Console.WriteLine($"Choose one of the planets to get your weight value in response: \n" +
                $"{home}");
            int opcaoUser = int.Parse(Console.ReadLine());


            switch (opcaoUser)
            {
                case 1:
                    relativeGravity = 0.37;
                    break;

                case 2:
                    relativeGravity = 0.88;
                    break;

                case 3:
                    relativeGravity = 0.38;
                    break;

                case 4:
                    relativeGravity = 2.64;
                    break;

                case 5:
                    relativeGravity = 1.5;
                    break;

                case 6:
                    relativeGravity = 1.17;
                    break;

                default:
                    Console.WriteLine("Invalid code!");
                    break;
            }

            weightPlanet = (weightEarth / 10) * relativeGravity;

            Console.WriteLine($"Weight on the planet: {weightPlanet.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
