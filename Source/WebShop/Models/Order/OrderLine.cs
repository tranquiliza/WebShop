using System;

namespace WebShop.Models.Order
{
    class OrderLine : Entity
    {
        public GiftcardProduct Giftcard { get; set; }
        public int Amount { get; set; }
        public string Message { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        private OrderLine() { }

        public OrderLine(GiftcardProduct giftcard, int amount, string message, string from, string to)
        {
            if (string.IsNullOrWhiteSpace(message)) throw new ArgumentException("Message must contain something", nameof(message));
            if (string.IsNullOrWhiteSpace(from)) throw new ArgumentException("There has to be a sender", nameof(from));
            if (string.IsNullOrWhiteSpace(to)) throw new ArgumentException("There has to be a receiver", nameof(to));

            Giftcard = giftcard ?? throw new ArgumentNullException(nameof(giftcard));
            Amount = amount;
            Message = message;
            From = from;
            To = to;
        }
    }
}
