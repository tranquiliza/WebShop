using Giftcard.Models.Order;

namespace Giftcard.Services.Abstractions
{
    public interface IOrderService
    {
        void UpdateOrderStatus(string orderIdentifier, OrderStatus orderStatus);
    }
}