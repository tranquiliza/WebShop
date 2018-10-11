using System;
using WebShop.Models.Orders;
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
