using WebShop.Models.Order;

namespace WebShop.Services.Abstractions
{
    public interface IOrderService
    {
        void UpdateOrderStatus(string orderIdentifier, OrderStatus orderStatus);
    }
}