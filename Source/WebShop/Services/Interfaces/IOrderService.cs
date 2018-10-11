using WebShop.Models.Orders;

namespace WebShop.Services.Interfaces
{
    public interface IOrderService
    {
        void UpdateOrderStatus(string orderIdentifier, OrderStatus orderStatus);
    }
}