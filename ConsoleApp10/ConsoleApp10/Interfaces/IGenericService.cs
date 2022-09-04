using ConsoleApp10.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp10.Services
{
    public interface IGenericService<T> where T : class
    {
        public void RemoveAll(Func<T, bool> predicate);
        public List<T> FindAll(Func<T, bool> predicate);
        public T Get(Func<T, bool> predicate);
        public void Remove(Func<T, bool> predicate);
    }
}
