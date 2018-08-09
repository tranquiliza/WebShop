using Giftcard.Models.Order;
using Giftcard.Services.Abstractions;
using System;

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
