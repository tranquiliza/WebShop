using WebShop.Models;
using WebShop.Models.Order;
using WebShop.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Repositories
{
    class OrderRepository : IOrderRepository
    {
        void IBaseRepository<Order>.Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        ICollection<Order> IBaseRepository<Order>.Get()
        {
            throw new NotImplementedException();
        }

        Order IBaseRepository<Order>.Get(int id)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<Order>.Insert(Order entity)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<Order>.Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
