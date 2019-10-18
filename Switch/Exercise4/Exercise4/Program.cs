using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             *  Develop a program for the user to type an acronym of one of the states of Brazil, after typing the program should 
             *  display the name of the corresponding state. If there is none the program should ask again until the user gets it right.
             **/

            Console.WriteLine("Type a type an acronym for one of the states of brazil: ");
            string state = Console.ReadLine();


            string initials = "";

            bool exists = true;

            while (exists)
            {
                switch (state)
                {
                    case "ac":
                        initials = "Acre";
                        exists = false;
                        break;

                    case "al":
                        initials = "Alagoas";
                        exists = false;
                        break;

                    case "ap":
                        initials = "Amapá";
                        exists = false;
                        break;

                    case "es":
                        initials = "Espírito Santo";
                        exists = false;
                        break;

                    case "sp":
                        initials = "São Paulo";
                        exists = false;
                        break;

                    case "rj":
                        initials = "Rio de Janeiro";
                        exists = false;
                        break;
                }
                if (exists)
                {
                    Console.Write("Invalid or unregistered acronym. Try again!: ");
                    state = Console.ReadLine();
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(initials);
        }
    }
}
