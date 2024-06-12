using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // Target Interface
    interface Charger
    {
        void chargePhone();
    }

    // Adaptee - Existing OldCharger class
    class OldCharger
    {
        public void chargeWithOldPlug()
        {
            Console.WriteLine("Charging with old charger plug");
        }
    }

    // Adapter class implementing the Charger interface
    class ChargerAdapter : Charger
    {
        private OldCharger oldCharger;

        public ChargerAdapter(OldCharger oldCharger)
        {
            this.oldCharger = oldCharger;
        }

        public void chargePhone()
        {
            oldCharger.chargeWithOldPlug();
            Console.WriteLine("Adapter: Charging phone with new plug");
        }
    }

    // Client code
    class Program4
    {
        static void Main(string[] args)
        {
            OldCharger oldCharger = new OldCharger();
            Charger adapter = new ChargerAdapter(oldCharger);

            // Client code charges the phone using the Charger interface
            adapter.chargePhone();
        }
    }


}
