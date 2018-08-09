using System.Collections.Generic;

namespace Giftcard.Models
{
    public class Order
    {
        private ICollection<OrderLine> OrderLines { get; set; }

        public int Id { get; private set; }
        public string OrderIdentifier { get; private set; }
        public OrderStatus OrderStatus { get; private set; }
        public Customer Buyer { get; private set; }
        public Customer Recipient { get; private set; }
        public string MessageToHotel { get; private set; }

        private Order()
        {
            OrderLines = new List<OrderLine>();
        }
        
        public static Order CreateNew()
        {
            var newOrder = new Order();
            newOrder.SetOrderStatusCreated();
            return newOrder;
        }
        
        public void AddOrderLine(OrderLine orderLine)
        {
            OrderLines.Add(orderLine);
        }

        public void SetOrderStatusCreated()
        {
            OrderStatus = OrderStatus.Created;
        }

        public void SetOrderStatusPending()
        {
            OrderStatus = OrderStatus.Pending;
        }

        public void SetOrderStatusAccepted()
        {
            OrderStatus = OrderStatus.Accepted;
        }

        public void SetOrderStatusCompleted()
        {
            OrderStatus = OrderStatus.Completed;
        }

        public int GetTotal()
        {
            var total = 0;

            foreach (var orderline in OrderLines)
            {
                total += orderline.Giftcard.Price * orderline.Amount;
            }

            return total;
        }

        public void SetMessageToHotel(string message)
        {
            if (string.IsNullOrWhiteSpace(message)) throw new System.ArgumentException("Message cannot be empty.", nameof(message));

            MessageToHotel = message;
        }
    }
}
