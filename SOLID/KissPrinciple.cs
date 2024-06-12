using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Product
    {
        public int Price { get; set; }
        public int Quantity { get; set; }

    }

    internal class KissPrinciple
    {
        //Without KISS
        public void CalculateAndPrintTotalPrice(List<Product> products)
        {
            decimal totalPrice = 0;
            foreach (var item in products)
            {
                totalPrice += item.Price * item.Quantity;
            }

            Console.WriteLine($"Total Price: {totalPrice:C}");
        }
        //With KISS
        public void CalculateAndPrintTotalPrice1(List<Product> products)
        {
            decimal totalPrice = products.Sum(item => item.Price * item.Quantity);
            Console.WriteLine($"Total Price: {totalPrice:C}");
        }

    }
}
