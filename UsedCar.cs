using System;
namespace Bonus16
{
    class UsedCar : Car // inheriting from Car class 
    {
        // fields--- private and lowercase 
        private double mileage;


        // properties {get set}
        public double Mileage
        {
            set { mileage = value; }
            get { return mileage; }
        }


        // constructor methods
        // default constructor... same as the class, and no params
        //public UsedCar() : base:
        public UsedCar()
        {
            mileage = 30000;
        }

        // overload constructor
        public UsedCar(string ma, string mo, int yr, int p, double mi) : base(ma, mo, yr, p) // you're using the previous stored info and only adding double mil
        {
            Mileage = mi;
        }

        // methods
        // virtual method derived from the Base class method c.ToString()
        //public override void ToString()
        //{
        //   Console.WriteLine($"{Mileage, -5}");
        //}

        public virtual void ToString()
        {
            Console.WriteLine($"{Make,-5} {Model,-5} {Year,-5} {Price,-5} {Mileage,-5}");
        }
    }
}
