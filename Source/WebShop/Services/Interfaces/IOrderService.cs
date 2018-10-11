using WebShop.Models.Order;

namespace WebShop.Services.Interfaces
{
    public interface IOrderService
    {
        void UpdateOrderStatus(string orderIdentifier, OrderStatus orderStatus);
    }
}