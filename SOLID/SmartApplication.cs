using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    using System;

    // Interface for basic functionalities common to all devices
    interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }

    // Interface specific to devices that can connect to the internet
    interface IInternetConnectable
    {
        void ConnectToInternet();
        void DisconnectFromInternet();
    }

    // Interface specific to devices that can make phone calls
    interface IPhoneCallable
    {
        void MakeCall(string phoneNumber);
        void ReceiveCall();
    }

    // Class representing a Smart TV that can connect to the internet
    class SmartTV : IDevice, IInternetConnectable
    {
        public void TurnOn()
        {
            Console.WriteLine("Smart TV turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Smart TV turned off.");
        }

        public void ConnectToInternet()
        {
            Console.WriteLine("Smart TV connected to the internet.");
        }

        public void DisconnectFromInternet()
        {
            Console.WriteLine("Smart TV disconnected from the internet.");
        }
    }

    // Class representing a Smartphone that can connect to the internet and make calls
    class Smartphone : IDevice, IInternetConnectable, IPhoneCallable
    {
        public void TurnOn()
        {
            Console.WriteLine("Smartphone turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Smartphone turned off.");
        }

        public void ConnectToInternet()
        {
            Console.WriteLine("Smartphone connected to the internet.");
        }

        public void DisconnectFromInternet()
        {
            Console.WriteLine("Smartphone disconnected from the internet.");
        }

        public void MakeCall(string phoneNumber)
        {
            Console.WriteLine($"Calling {phoneNumber} from Smartphone.");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Smartphone is receiving a call.");
        }
    }

    class Program2
    {
        static void Main()
        {
            // Using Smart TV
            SmartTV smartTv = new SmartTV();
            smartTv.TurnOn();
            smartTv.ConnectToInternet();
            smartTv.DisconnectFromInternet();
            smartTv.TurnOff();

            // Using Smartphone
            Smartphone smartphone = new Smartphone();
            smartphone.TurnOn();
            smartphone.ConnectToInternet();
            smartphone.MakeCall("123-456-7890");
            smartphone.ReceiveCall();
            smartphone.DisconnectFromInternet();
            smartphone.TurnOff();
        }
    }

}
