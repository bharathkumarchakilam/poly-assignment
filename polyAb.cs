using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_assignment
{
    abstract class Vehicle
    {
        public abstract void StartEngine();

        public void DisplayInfo()
        {
            Console.WriteLine("This is a vehicle.");
        }
    }

    class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started with a key.");
        }
    }

    class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started with a self-start button.");
        }
    }

    class Truck : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Truck engine started with a push button.");
        }
    }

    //class Sixth
    //{
    //    static void Main()
    //    {
    //        Vehicle myCar = new Car();
    //        myCar.StartEngine();
    //        myCar.DisplayInfo();

    //        Vehicle myMotorcycle = new Motorcycle();
    //        myMotorcycle.StartEngine();
    //        myMotorcycle.DisplayInfo();

    //        Vehicle myTruck = new Truck();
    //        myTruck.StartEngine();
    //        myTruck.DisplayInfo();
    //    }
    //}
}
