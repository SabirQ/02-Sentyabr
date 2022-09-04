using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10.Models
{
    public static class DiscountOperation
    {
        public static decimal ApplyDiscount(decimal price)
        {
            if (price>100&&price<=200)
            {
                price = price - (price / 10);
                Console.WriteLine("You applied 10% discount");
            }
            else if(price > 200)
            {
                price = price - (price / 5);
                Console.WriteLine("You applied 20% discount");
            }
            return price;
        }
    }
}
