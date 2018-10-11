using System;
using System.Collections.Generic;
using WebShop.Models.Customers;
using WebShop.Models.Organisations;

namespace WebShop.Models.Orders
{
    public class Order : Entity
    {
        private Organisation Organisation { get; set; }

        private ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

        internal string OrderIdentifier { get; private set; } // Should not be set until payment is request or the order is confirmed by the company?

        internal OrderStatus OrderStatus { get; private set; } = OrderStatus.OrderCreated;

        internal Customer Buyer { get; private set; }

        internal Customer DeliveryAddress { get; private set; }

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

        internal void Purchase(object token)
        {
            //Token needed for capture of money later?
            //Do some stuff, then set the status of the order 
            OrderStatus = OrderStatus.OrderPlaced;

            //If order requires payment, initiate payment flow and set PaymentPending status after
            //I do payment stuff
            // Logic for saving the needed things regarding the order, such as OrderId, MerchantId etc. 
            // we want to save this with the order, so that all if it is available, in case we need it later (Reservation of money, then capture later etc).
            OrderStatus = OrderStatus.PaymentPending;
        }

        internal void SetOrderDispatched()
        {
            OrderStatus = OrderStatus.OrderDispatched;
            // In Denmark it's not legal to capture payment before the goods are send from the providier, therefore this is probably needed. 
            // Once order is dispatched, it will be possible to Capture Payment
            //
        }

        internal void SetPaymentCompleted(object paymentInfo)
        {
            //We want to save the information regarding payments etc. 
            // If everything is cool we set the status to payment completed
            OrderStatus = OrderStatus.PaymentAccepted;
        }

        internal void SetOrderCompleted()
        {
            //Once everything has been proccessed etc, but staff or whatever is needed to be done, we set the Order Completed.
            OrderStatus = OrderStatus.OrderCompleted;
        }
    }
}
