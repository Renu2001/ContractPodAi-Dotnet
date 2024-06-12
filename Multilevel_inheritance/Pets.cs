using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_inheritance
{
    internal class Pets : Dog
    {
        public override void Eat()
        {
            Console.WriteLine("Eat Pedigree or food given by owner");
        }

        public void Stay()
        {
            Console.WriteLine("Stay with owner in house");
        }

        public void Nature()
        {
            Console.WriteLine("Mostly friendly nature");
        }
    }
}
