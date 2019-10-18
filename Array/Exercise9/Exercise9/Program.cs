using System;
using System.Collections.Generic;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {

            /***
             * Developing a program that asks the names of 10 different people, will then start a kind of game where the user
             * must enter all the names he has previously entered.

               Considerations:

               * The game should have a panel showing the total score and the names the user hit;

               * Each correct name is worth one point;

               * The user cannot score with the same name more than once;

               * If the user misses a name the game should be terminated and the points panel should be displayed. That is, the user only gets maximum score if no name is missed;

               * If the user hits all the names the program should display a message congratulating him and the panel should be shown;

               * The user does not need to match the names in the order he entered (previous step).

               Use array and array list!
             **/

            string[] names = new string[10];
            List<string> correctNamesUser = new List<string>();

            string correctNames = "";
            bool hit = false;
            string status = "";
            int points = 0;
            int indexCorrectNames = 1;

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Type the {(i + 1)}º name: ");
                names[i] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("The game is going to start!" +
                "\nHit any key");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Points: {points}");

            do
            {
                Console.Write($"Type a name to find in vector names: ");
                string find = Console.ReadLine();
                string alreadyRight = "";

                //panel
                string panel = $"\n::::::Panel of points::::::\n" +
                                $"\n\nTotal of points: {points}" +
                                $"\n\nCorrect names: \n{correctNames}";


                if (correctNamesUser.Contains(find))
                {
                    alreadyRight = "You already scored with that name, try another one.";
                }
                else
                {
                    foreach (string name in names)
                    {

                        if (name.Equals(find))
                        {
                            correctNamesUser.Add(find);
                            points++;
                            correctNames += $"{indexCorrectNames} - {find} \n";
                            indexCorrectNames++;
                            status = $"Points: {points}" +
                                $"\nGood, name {find} exist in array :)";

                            panel = $"\n::::::Panel of points::::::\n" +
                                $"\n\nTotal of points: {points}" +
                                $"\n\nCorrect names: \n{correctNames}";

                            hit = true;
                            if (points == names.Length)
                            {
                                alreadyRight = "You got them all right. Congratulations!";
                                status += panel;
                                hit = false;
                            }
                            break;
                        }
                        else
                        {
                            status = $"{find} don´t exist in array :(\n\n";
                            status += panel;
                            hit = false;
                        }
                    }
                }                
                Console.Clear();
                Console.WriteLine(alreadyRight);
                Console.WriteLine(status);
            } while (hit);
        }
    }
}
