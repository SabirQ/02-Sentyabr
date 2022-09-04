using ConsoleApp10.Models;
using ConsoleApp10.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp10.Repositories
{
    public abstract class GenericService<T> : IGenericService<T> where T : class
    {
        public List<T> list { get; set; }
        public GenericService(List<T> values)
        {
            list = values;
        }
        public List<T> FindAll(Func<T,bool> predicate)
        {
            if (predicate!=null) return list.Where(predicate).ToList();
            return list;
        }
        public void RemoveAll(Func<T, bool> predicate)
        {
            if (predicate == null) return;
            List<T> values = list.Where(predicate).ToList();
            list=list.Except(values).ToList();
        }
        public void Remove(Func<T, bool> predicate)
        {
            if (predicate == null) return;
            T item = list.FirstOrDefault(predicate);
            if (item == null)
            {
                return;
            }
            list.Remove(item);
        }
        public T Get(Func<T, bool> predicate)
        {
            if (predicate == null) return null;
            return list.FirstOrDefault(predicate);
        }
    }
}
