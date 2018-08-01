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
            List<Car> cars = new List<Car>(); // empty list you're adding to


            //makeModel regex = @"^[a-z][A-Z]

            while (true)
            {

                Console.Clear();

                Console.WriteLine("Welcome to the Grand Circus Motors admin console!");

                //Console.WriteLine("How many cars are you entering: ");
                Console.WriteLine("Please provide Make of the car:");

                Car c = new Car(); //create object type car
                c.Make = Console.ReadLine();

                Console.WriteLine("Please provide the Model of the car:");
                c.Model = Console.ReadLine();

                Console.WriteLine("Please provide the Year:");
                c.Year = int.Parse(Console.ReadLine());

                Console.WriteLine("Please provide the Price of the car:");
                c.Price = double.Parse(Console.ReadLine());

                Console.WriteLine("Please provide the Mileage used for this car:");
                c.Mileage = double.Parse(Console.ReadLine());

                cars.Add(c);// add the temp object to the Car list 

                Console.WriteLine("Do you want to add another car? Y/N");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "n") //so it doesn't matter if it's lower case or uppper case input
                    break;
            }

            Console.Clear();
             // print car list method?
            Console.WriteLine("Current Inventory: ");
            Console.WriteLine("Make Model Year Price Mileage");
            Console.WriteLine("===== ===== ===== ===== =====");

            foreach (Car c in cars) //{ ma,mo,yr,p,mi} // for each listed item that was stored, print info input
            {
                c.ToString();
            }
        }
    }
}
