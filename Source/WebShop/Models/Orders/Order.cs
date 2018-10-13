using System;
using System.Collections.Generic;
using WebShop.Models.Customers;
using WebShop.Models.Organisations;
using WebShop.Models.Payments;

namespace WebShop.Models.Orders
{
    public class Order : Entity
    {
        public Organisation Organisation { get; set; }

        public PaymentInformation PaymentInformation { get; private set; }

        private ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

        public string OrderIdentifier { get; private set; }

        public OrderStatus OrderStatus { get; private set; } = OrderStatus.OrderCreated;

        public Customer Buyer { get; private set; }

        public Customer DeliveryAddress { get; private set; }


        public Order()
        {
        }

        internal void AddOrderLine(OrderLine orderLine)
        {
            OrderLines.Add(orderLine);
        }

        internal int GetTotal()
        {
            var total = 0;

            foreach (var orderline in OrderLines)
            {
                total += orderline.Product.Price * orderline.Amount;
            }

            return total;
        }

        internal int GetGiftcardSubTotal()
        {
            var subTotal = 0;

            foreach (GiftCardOrderLine giftCardOrderLine in OrderLines)
            {
                subTotal += giftCardOrderLine.Product.Price;
            }

            return subTotal;
        }

        internal void PlaceOrder()
        {
            OrderStatus = OrderStatus.OrderPlaced;
        }

        internal void OrderDispatched()
        {
            OrderStatus = OrderStatus.OrderDispatched;
        }

        internal void SetOrderCompleted()
        {
            OrderStatus = OrderStatus.OrderCompleted;
        }
    }
}
