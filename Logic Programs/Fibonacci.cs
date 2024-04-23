using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Programs
{
    public class Fibonacci
    {
        int no1, no2, no3, count;

        public Fibonacci()
        {
            no1= 0;
            no2 = 1;
        }

        public void FibonacciSeries()
        {
            Console.WriteLine("Fibonacci Series Problem \n");
            Console.WriteLine("Till what do you want the series?");
            count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibonacci series is : " + no1 + " " + no2);

            for (int i = 2; i < count; ++i)
            {
                no3 = no1 + no2;
                Console.Write(" " + no3 );
                no1 = no2;
                no2 = no3;

            }
        }

        
    }
}
