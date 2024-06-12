using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //Liskov
    class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }
    }

    class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        // Method specific to Car
        public void OpenSunroof()
        {
            Console.WriteLine("Sunroof opened.");
        }
    }

    // Derived class representing a Motorcycle
    class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started.");
        }

        // Method specific to Motorcycle
        public void PerformWheelie()
        {
            Console.WriteLine("Performed a wheelie!");
        }
    }

    class Program1
    {
        static void Main()
        {
            // Using LSP: substituting Motorcycle for Vehicle
            Vehicle car = new Car();
            Vehicle motorcycle = new Motorcycle();

            // Start engines without knowing specific types
            car.StartEngine();          // Outputs: Car engine started.
            motorcycle.StartEngine();   // Outputs: Motorcycle engine started.

            //if we called
            //car.OpenSunroof(); This will give error
        }
    }
}
