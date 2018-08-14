namespace WebShop.Contracts.Order
{
    public class UpdateOrderStatusDto
    {
        public string OrderIdentifier { get; set; }
        public OrderStatusDto OrderStatus { get; set; }
    }
}
