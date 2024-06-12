using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //Dependency Inversion 
    using System;

    // Engine interface representing common engine behaviors
    interface IEngine
    {
        void Start();
    }

    // Petrol engine class implementing IEngine
    class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Petrol engine started");
        }
    }

    // Electric engine class implementing IEngine
    class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric engine started");
        }
    }

    // Vehicle class depending on IEngine abstraction
    class Vehiclee
    {
        private readonly IEngine _engine;

        public Vehiclee(IEngine engine)
        {
            _engine = engine;
        }

        public void StartVehicle()
        {
            _engine.Start(); // Delegates starting to the injected engine
        }
    }

    class Program3
    {
        static void Main()
        {
            IEngine petrolEngine = new PetrolEngine();
            Vehiclee car = new Vehiclee(petrolEngine);
            car.StartVehicle(); // Outputs: Petrol engine started

            IEngine electricEngine = new ElectricEngine();
            Vehiclee eCar = new Vehiclee(electricEngine);
            eCar.StartVehicle(); // Outputs: Electric engine started
        }
    }

}
