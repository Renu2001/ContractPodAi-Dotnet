using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //Simple Factory
    using System;

    // Product Interface
    interface IVehicle
    {
        void Drive();
    }

    // Concrete Products
    class Car1 : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is being driven");
        }
    }

    class Motorcycle1 : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Motorcycle is being ridden");
        }
    }

    // Simple Factory
    class VehicleFactory
    {
        public IVehicle CreateVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car1();
                case "motorcycle":
                    return new Motorcycle1();
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }

    // Client code
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        VehicleFactory factory = new VehicleFactory();

    //        // Create a car
    //        IVehicle car = factory.CreateVehicle("car");
    //        car.Drive();

    //        // Create a motorcycle
    //        IVehicle motorcycle = factory.CreateVehicle("motorcycle");
    //        motorcycle.Drive();
    //    }
    //}

    //Factory Method


            // Product Interface
            interface IVehicle1
                {
                    void Drive();
                }

                // Concrete Products
                class Car2 : IVehicle
                {
                    public void Drive()
                    {
                        Console.WriteLine("Car is being driven");
                    }
                }

                class Motorcycle2 : IVehicle
                {
                    public void Drive()
                    {
                        Console.WriteLine("Motorcycle is being ridden");
                    }
                }

                // Creator Interface
                interface IVehicleFactory
                {
                    IVehicle CreateVehicle();
                }

                // Concrete Creators
                class CarFactory : IVehicleFactory
                {
                    public IVehicle CreateVehicle()
                    {
                        return new Car2();
                    }
                }

                class MotorcycleFactory : IVehicleFactory
                {
                    public IVehicle CreateVehicle()
        {
            return new Motorcycle2();
        }
    }

    // Client code
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IVehicleFactory carFactory = new CarFactory();
    //        IVehicle car = carFactory.CreateVehicle();
    //        car.Drive();

    //        IVehicleFactory motorcycleFactory = new MotorcycleFactory();
    //        IVehicle motorcycle = motorcycleFactory.CreateVehicle();
    //        motorcycle.Drive();
    //    }
    //}

    //Abstract Factory Pattern

// Abstract Product Interfaces
                interface IEngine3 { }
                    interface IWheel3 { }

                    // Concrete Product Classes
                    class CarEngine : IEngine3 { }
                    class CarWheel : IWheel3 { }

                    class MotorcycleEngine : IEngine3 { }
                    class MotorcycleWheel : IWheel3 { }

                    // Abstract Factory Interface
                    interface IVehicleFactory3
                    {
                        IEngine3 CreateEngine();
                        IWheel3 CreateWheel();
                    }

                    // Concrete Factory Classes
                    class CarFactory3 : IVehicleFactory3
                    {
                        public IEngine3 CreateEngine()
                        {
                            return new CarEngine();
                        }

                        public IWheel3 CreateWheel()
                        {
                            return new CarWheel();
                        }
                    }

                    class MotorcycleFactory3 : IVehicleFactory3
                    {
                        public IEngine3 CreateEngine()
                        {
                            return new MotorcycleEngine();
                        }

                        public IWheel3 CreateWheel()
                        {
                            return new MotorcycleWheel();
                        }
                    }

                    // Client code
                    //class Program
                    //{
                    //    static void Main(string[] args)
                    //    {
                    //        IVehicleFactory carFactory = new CarFactory();
                    //        IEngine carEngine = carFactory.CreateEngine();
                    //        IWheel carWheel = carFactory.CreateWheel();
                    //        Console.WriteLine("Car Engine and Wheel created.");

                    //        IVehicleFactory motorcycleFactory = new MotorcycleFactory();
                    //        IEngine motorcycleEngine = motorcycleFactory.CreateEngine();
                    //        IWheel motorcycleWheel = motorcycleFactory.CreateWheel();
                    //        Console.WriteLine("Motorcycle Engine and Wheel created.");
                    //    }
                    //}


                }
