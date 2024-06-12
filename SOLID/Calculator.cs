using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Calculator
    {
        public void Add()
        {
            Console.WriteLine("Add");
        }
        public void Subtract()
        {
            Console.WriteLine("Subtract");
        }
        public void Multiply()
        {
            Console.WriteLine("Multiply");
            
        }
        public void Divide()
        {
            Console.WriteLine("Divide");
        }
    }
    public class ScientificCalc : Calculator
    {
        public void Sin()
        {
            Console.WriteLine("Sin calc");
        }
        public void Cos()
        {
            Console.WriteLine("Cos calc");
        }

    }
    public class BusinessCalc : Calculator
    {
        public void Tax()
        {
            Console.WriteLine("Tax calc");
        }
        public void Emi()
        {
            Console.WriteLine("Emi calc");
        }

    }
}
