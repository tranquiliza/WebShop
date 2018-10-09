using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Models.Order;
using WebShop.Repositories.Abstractions;

namespace WebShop.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        void IBaseRepository<Order>.Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        async Task<ICollection<Order>> IBaseRepository<Order>.Get()
        {
            throw new NotImplementedException();
        }

        async Task<Order> IBaseRepository<Order>.Get(int id)
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
