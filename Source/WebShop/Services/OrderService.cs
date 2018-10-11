using System;
using WebShop.Models.Order;
using WebShop.Services.Interfaces;

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
