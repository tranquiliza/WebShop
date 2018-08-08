using Giftcard.Models;
using Giftcard.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Giftcard.Repositories
{
    public class OrderRepository : IOrderRepository
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
