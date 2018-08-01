using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bonus16
{
    class MainClass //CarApp
    {
        public static void Main(string[] args)
        {
            // List of Cars you build
            List<Car> cars = new List<Car>(7); // empty list you're adding to

            // create objects because not asking for input, and the vars are initialized with data below
            // can list a string, but will pass an int so user can select vehicle by number on list to get info
            Car c1 = new Car("Ford", "Focus", 2017, 12000);
            Car c2 = new Car("Chevy", "Impala", 2017, 15000);
            Car c3 = new Car("GMC", "Terrain", 2017, 22000);
            UsedCar u1 = new UsedCar("Cadillac", "XT5", 2017, 35000, 35987.6);
            UsedCar u2 = new UsedCar("BMW", "i8", 2017, 90000, 50432.8);
            UsedCar u3 = new UsedCar("Range Rover", "Sport", 2017, 82000, 60342.8);
           
            cars.Add(c1);
            cars.Add(c2);
            cars.Add(c3);
            cars.Add(u1);
            cars.Add(u2);
            cars.Add(u3);


            while (true)
            {
                Console.Clear();

                Console.WriteLine("Current Inventory: ");

                if (cars.Count() == 0) // no inventory on list 
                {
                    Console.WriteLine("Sorry, we're sold out!");
                }
                else // if they choose a number of the inventory greater than 0
                {
                    foreach (Car c in cars) // for each listed item that was stored, print info input
                    {
                        Console.WriteLine($"{cars.IndexOf(c) + 1,1}: {c.Year,-5} {c.Make,-5} {c.Model,-5}");
                    }
                    Console.WriteLine("=================================");
                    Console.WriteLine("Please choose a vehicle number from the list above: ");
                }
                if (cars.Count() > 0)
                {
                    try
                    {
                        string input = Console.ReadLine();
                        foreach (Car c in cars) // for each listed item that was stored, print info input
                        {
                            if (cars.IndexOf(c) + 1 == int.Parse(input))
                            {
                                c.PrintInfo();
                                string yn = "";
                                Console.WriteLine();
                            }
                        }
                    }
                    catch(Exception e)
                    {
                     // if no add an exception
                    }
                }
                Console.WriteLine("Do you want to view another car? Y/N");
                    string choice = Console.ReadLine();
                if (choice.ToLower() == "n") //so it doesn't matter if it's lower case or uppper case input
                    break;

                Console.Clear();
                // print car list method?
                Console.WriteLine("Current Inventory: ");
                Console.WriteLine("Make Model Year Price Mileage");
                Console.WriteLine("===== ===== ===== ===== =====");

                foreach (Car c in cars) // for each listed item that was stored
                {
                    c.ToString();
                }
                foreach (Car c in cars) // for each listed item that was stored, print info input
                {
                    c.PrintInfo();
                }
            }
        }
    }
}


////Console.WriteLine("How many cars are you entering: ");
//Console.WriteLine("Please provide Make of the car:");
//c.Make = Console.ReadLine();

//Console.WriteLine("Please provide the Model of the car:");
//c.Model = Console.ReadLine();

//Console.WriteLine("Please provide the Year:");
//c.Year = int.Parse(Console.ReadLine());

//Console.WriteLine("Please provide the Price of the car:");
//c.Price = double.Parse(Console.ReadLine());


//Console.WriteLine("Please provide the Mileage used for this car:");
//c.Mileage = double.Parse(Console.ReadLine());

// add the temp object to the Car list
//cars.Add(c); 
