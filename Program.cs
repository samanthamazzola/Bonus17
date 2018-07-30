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
            
            // List of Car 
            List<Car> car = new List<Car>();
            // used to add new car to the list 
            while (true)
            {
                Console.Clear();
                Car temp = new Car();
                Console.WriteLine("Please provide Make of the car:");
                temp.Make = Console.ReadLine();

                Console.WriteLine("Please provide the Model of the car:");
                temp.Model = Console.ReadLine();

                Console.WriteLine("Please provide the Year:");
                temp.Year = int.Parse(Console.ReadLine());

                Console.WriteLine("Please provide the Price of the car:");
                temp.Price = float.Parse(Console.ReadLine());

                car.Add(temp);// add the temp object to the Car list 

                Console.WriteLine("Do you want to add another car? Y/N");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "n") //so it doesn't matter if it's lower case or uppper case input
                    break;
            }

             // print car list method?
            foreach (Car c in car)
            {
                Console.WriteLine($"{c.Make} | {c.Model} | {c.Year} | {c.Price} ");
                Console.WriteLine("==========================================");
            }

            //for (int i = 0; i < employees.Count; i++)
            //{
            //    Console.WriteLine($"{employees[i].FirstName} {employees[i].LastName}");
            //    Console.WriteLine("===================");
            //}

        }
    }
}
