using WebShop.Models.Order;
using WebShop.Services.Abstractions;
using System;

namespace WebShop.Services
{
    public class OrderService : IOrderService
    {
        void IOrderService.UpdateOrderStatus(string orderIdentifier, OrderStatus orderStatus)
        {
            throw new NotImplementedException();
        }
    }
}
