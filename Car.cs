using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bonus16
{
    class Car
    {

        // Fields
        private string make;
        private string model;
        private int year;
        private double price;


        // Properties
        public string Make
        {
            set { make = value; }
            get { return make; }
        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public int Year
        {
            set { year = value; }
            get { return year; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        public double Mileage { get; internal set; }


        // default constructor (takes no param)
        public Car()
        {
            Make = "not assigned";
            Model = "not assigned";
            Year = 2018;
            Price = 40000;
        }

        // overload constructor 
        public Car(string ma, string mo, int yr, int p)
        {
            Make = ma;
            Model = mo;
            Year = yr;
            Price = p;
        }

        // method from main class
        // virtual method


        public virtual void ToString()
        {
            Console.WriteLine($"{Make,-15} {Model,-15} {Year,-15} {Price,-15}");
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Make,-15} {Model,-15} {Year,-15} {Price,-15}");
        }
    }
}
