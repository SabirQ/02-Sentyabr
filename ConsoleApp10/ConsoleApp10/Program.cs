using ConsoleApp10.Models;
using ConsoleApp10.Repositories;
using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
    public delegate decimal DiscountDelegate(decimal price);

    internal class Program
    {
        static void Main(string[] args)
        {
            DiscountDelegate discount = new DiscountDelegate(DiscountOperation.ApplyDiscount);

            Book book = new Book("Harry Potter", "Lima", 340, 35.9m);
            Book book1 = new Book("Lord of rings", "Kenan", 650, 89.9m);
            Book book2 = new Book("Skyrim", "Ali", 140, 50);
            Book book3 = new Book("Ali ve Nino", "Avaz", 70, 35);


           
            LibraryService library = new LibraryService(new List<Book>());
            Order order = new Order();
            order.Books.Add(book);
            order.Books.Add(book1);
            order.Books.Add(book3);
            order.Books.Add(book2);
            Console.WriteLine(order.Purchase(discount));
            library.list.Add(book);
            library.list.Add(book1);
            library.list.Add(book2);
            library.list.Add(book3);

            Console.WriteLine("Predicate for pagecount: ");
            foreach (var item in library.list.FindAll(x => x.PageCount >= 300 && x.PageCount <= 700))
            {
                Console.WriteLine(item.PageCount);
            }
            Console.WriteLine("Predicate for name search:");
            foreach (var item in library.list.FindAll(x => x.Name.Contains("Ali") || x.AuthorName.Contains("Ali")))
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("all books contain elements in name:");
            foreach (var item in library.list.FindAll(x => x.Name.Contains("ri")))
            {
                Console.WriteLine(item.Name);
            }
            library.Remove(x => x.Code == "HA101");
            Console.WriteLine("removed by code:");
            foreach (var item in library.list)
            {
                Console.WriteLine(item.Code);
            }
            library.RemoveAll(x => x.Name.Contains("Lord"));
            Console.WriteLine("removed all by Name:");
            foreach (var item in library.list)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
