using System;
using WebShop.Models.Products;

namespace WebShop.Models.Orders
{
    public class GiftCardOrderLine : OrderLine
    {
        public string Message { get; private set; }
        public string From { get; private set; }
        public string To { get; private set; }

        protected GiftCardOrderLine() { }

        public GiftCardOrderLine(GiftcardProduct giftcard, int amount, string message, string from, string to) : base(amount, giftcard)
        {
            if (string.IsNullOrWhiteSpace(message)) throw new ArgumentException("Message must contain something", nameof(message));
            if (string.IsNullOrWhiteSpace(from)) throw new ArgumentException("There has to be a sender", nameof(from));
            if (string.IsNullOrWhiteSpace(to)) throw new ArgumentException("There has to be a receiver", nameof(to));

            Message = message;
            From = from;
            To = to;
        }
    }
}
