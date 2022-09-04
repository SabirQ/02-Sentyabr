using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp10.Models
{
    public class Book
    {
        public static int Count = 100;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public short PageCount { get; set; }
        public string Code { get; }
        public decimal Price { get; set; }
        public Book(string name, string authorName, short pageCount, decimal price)
        {

            Count++;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Price = price;
            if (!String.IsNullOrEmpty(name))
            {
                Code = String.Join("", name.Trim().Split(' ').Select(c => Char.ToUpper(c[0]))) + $"-{Count}";
            }
            
        }
    }
}
