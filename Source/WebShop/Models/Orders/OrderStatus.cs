namespace WebShop.Models.Orders
{
    public enum OrderStatus
    {
        OrderCreated = 0,
        OrderPlaced = 1,
        OrderDispatched = 2,
        PaymentPending = 3,
        PaymentAccepted = 4,
        OrderCompleted = 5
    }
}
