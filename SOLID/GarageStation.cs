using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class GarageStation
    {
        public void Welcoming()
        {
            Console.WriteLine("Welcoming Customer");
        }
        public void ManageCounter() 
        {
            Console.WriteLine("Managing Transaction");
        }
        public void ModifyingVehicles()
        {
            Console.WriteLine("Making Modification");
        }
        public void RepairingVehicles()
        {
            Console.WriteLine("Making Modification");
        }
    }


    public class Guards
    {
        public void OpenGate()
        {
            Console.WriteLine("Welcoming Customer");
        }
        public void Parking()
        {
            Console.WriteLine("park");
        }
        public void MaintainSecurity()
        {
            Console.WriteLine("Security");
        }
    }
    public class Manager
    {
        public void MakingBill()
        {
            Console.WriteLine("Managing Transaction");
        }
        public void TakePayment()
        {
            Console.WriteLine("Managing Transaction");
        }
    }

    public class VehicleExperts
    {
        public void ModifyingVehicles()
        {
            Console.WriteLine("Making Modification");
        }
        public void RepairingVehicles()
        {
            Console.WriteLine("Making repair");
        }
    }
}
