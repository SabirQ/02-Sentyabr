using ConsoleApp10.Interfaces;
using ConsoleApp10.Models;
using ConsoleApp10.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10.Services
{
    public class OrderService : GenericService<Order>, IOrderService
    {
        public OrderService(List<Order> orders) : base(orders)
        {

        }
    }
}
