using Giftcard.Models;

namespace Giftcard.Services.Abstractions
{
    public interface IOrderService
    {
        void UpdateOrderStatus(string orderIdentifier, OrderStatus orderStatus);
    }
}