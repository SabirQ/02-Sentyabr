using System;
using System.Collections.Generic;


namespace ConsoleApp10.Models
{
    public class Order
    {
        public static int Count=0;
        public int Id { get; set; }
        public List<Book> Books { get; set; }
        public decimal TotalPrice { get; set; } = 0;
        public DateTime Date { get; set; }

        public Order()
        {
            Count++;
            Id = Count;
            Books = new List<Book>();
            TotalPrice = 0;
            Date =DateTime.Now;
        }
        public decimal Purchase(DiscountDelegate func)
        {
            Books.ForEach(x => TotalPrice += x.Price);
            TotalPrice = func(TotalPrice);
            return TotalPrice;
        }
    }
}
