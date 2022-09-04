using ConsoleApp10.Models;
using ConsoleApp10.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10.Repositories
{
    public class LibraryService : GenericService<Book>, ILibraryService
    {
        public LibraryService(List<Book> books):base(books)
        {

        }
    }
}
