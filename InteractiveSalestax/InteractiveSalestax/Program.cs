using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveSalestax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sales Tax Calculator
            double itemprice;
            doubletotal;
            const double TAX RATE = 0.06;
            string itemPriceString;

            Console.WriteLine("Enter the price of the an item >> ");
            itemPriceString = Console.ReadLine();

            itemPrice = Convert.ToDouble(itemPriceString);
            total = itemPrice * TAX_RATE;

            Console.WriteLine("\a With a tax rate of {0}, \n a {1} item " +
                "cost {2} more.", TAX_RATE, itemPrice.ToString("C"), total.ToString("C"));

        }
    }
}
