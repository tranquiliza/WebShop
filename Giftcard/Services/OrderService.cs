using Giftcard.Models;
using Giftcard.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Giftcard.Services
{
    public class OrderService : IOrderService
    {
        void IOrderService.UpdateOrderStatus(string orderIdentifier, OrderStatus orderStatus)
        {
            throw new NotImplementedException();
        }
    }
}
