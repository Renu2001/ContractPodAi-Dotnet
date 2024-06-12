using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_inheritance
{
    internal class Dog : Animals
    {
        public void Sound()
        {
            Console.WriteLine("Bark");
        }

        public void type()
        {
            Console.WriteLine("Ominivores");
        }

        virtual public void Eat()
        {
            Console.WriteLine("Eat Food");
        }
    }
}
