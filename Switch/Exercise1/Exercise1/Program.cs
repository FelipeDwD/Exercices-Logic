using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             *  Develop a car shop program using list and switch case.

                The program should have the following functions:

                1 - Insert
                2 - Update
                3 - Delete
                4 - Select
                0 - exit

                Considerations:

                * Cars (objects) should be stored in the list. Thus:
                - Insert: inserts cars (objects) in the list;
                - Update: changes the attributes of cars (objects) that are already in the list;
                - Delete: delete cars (objects) from the list;
                - Select: Displays data for a car (object) from the list.

                * No need to provide the list all option;
                * No need to validate if there is already registered car with the name in force;

                * It will be necessary to validate if there are items in the list to execute the update, delete and select options, if the 
                  list is empty please display a message.
             **/


            List<Car> listCars = new List<Car>();
            bool run = true;

            do
            {
                Console.Write(":: Select a option to make in program" +
                    "\n1 - Insert" +
                    "\n2 - Update" +
                    "\n3 - Delete" +
                    "\n4 - Select" +
                    "\n0 - exit" +
                    "\n\n>_: ");

                int opUser = int.Parse(Console.ReadLine());

                switch (opUser)
                {
                    case 1:
                        Console.Write("Type the name of car: ");
                        string carModel = Console.ReadLine();

                        Console.Write($"Type the cor of car {carModel}: ");
                        string color = Console.ReadLine();

                        Console.Write($"Type the year of car {carModel}: ");
                        int year = int.Parse(Console.ReadLine());

                        Car car = new Car(carModel, color, year);
                        listCars.Add(car);

                        Console.Clear();

                        Console.Write($"{carModel} added in array list!");

                        Console.ReadKey();
                        break;

                    case 2:
                        string statusUpdate = "";
                        if (listCars.Count != 0)
                        {
                            Console.Write("Which car you edit: ");
                            string carEdit = Console.ReadLine();

                            foreach (Car cars in listCars)
                            {
                                if (carEdit.Equals(cars.ModelCar))
                                {
                                    Console.Write($"Update name car {cars.ModelCar}? (y/n): ");
                                    string updateName = Console.ReadLine();

                                    if (updateName.Equals("y") || updateName.Equals("Y"))
                                    {
                                        Console.Write("Type a new name car: ");
                                        cars.ModelCar = Console.ReadLine();
                                    }

                                    Console.Write($"Update color of car {cars.ModelCar}? (y/n): ");
                                    string updateColor = Console.ReadLine();

                                    if (updateColor.Equals("Y") || updateColor.Equals("y"))
                                    {
                                        Console.Write($"Type a new color of car {cars.ModelCar}: ");
                                        cars.Color = Console.ReadLine();
                                    }

                                    Console.Write($"Update year of car {cars.ModelCar}? (y/n): ");
                                    string updateYear = Console.ReadLine();

                                    if (updateYear.Equals("Y") || updateYear.Equals("y"))
                                    {
                                        Console.Write($"Type the new yar of car {cars.ModelCar}: ");
                                        cars.Year = int.Parse(Console.ReadLine());
                                    }
                                    statusUpdate = "The car update witch SUCESS";
                                    break;

                                }
                                else
                                {
                                    statusUpdate = "car don´t find in list!";
                                }
                            }
                        }
                        else
                        {
                            statusUpdate = "Don´t exist car registered in list!";
                        }
                        Console.Write(statusUpdate);
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 3:
                        string statusDelete = "";
                        if (listCars.Count != 0)
                        {
                            Console.Write("Wich name of car you delete? ");
                            string nameDelete = Console.ReadLine();


                            foreach (Car cars in listCars)
                            {
                                if (nameDelete.Equals(cars.ModelCar))
                                {
                                    listCars.Remove(cars);
                                    statusDelete = $"{nameDelete} removed witch sucess!";
                                    break;
                                }
                                else
                                {
                                    statusDelete = $"don´t exist car {nameDelete} in list!";
                                }
                            }
                        }
                        else
                        {
                            statusDelete = $"Don´t exist cars in list!";
                        }

                        End(statusDelete);

                        break;

                    case 4:
                        string statusSelect = "";

                        if (listCars.Count != 0)
                        {
                            Console.Write("Type a name to find car: ");
                            string selectCar = Console.ReadLine();

                            foreach (Car cars in listCars)
                            {
                                if (selectCar.Equals(cars.ModelCar))
                                {
                                    statusSelect = $"Cars data: \n {cars}";
                                    break;
                                }
                                else
                                {
                                    statusSelect = $"Don´t exist the car {selectCar} in list!";
                                }
                            }
                        }
                        else
                        {
                            statusSelect = $"Don´t exist car registered in list";
                        }
                        End(statusSelect);

                        break;

                    case 0:
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }

            } while (run);
        }

        static void End(string exit)
        {
            Console.WriteLine(exit);
            Console.ReadKey();
            Console.Clear();
        }
    }

}
