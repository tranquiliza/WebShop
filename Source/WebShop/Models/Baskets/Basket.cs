using System;
using WebShop.Models.Orders;

namespace WebShop.Models.Baskets
{
    public class Basket : Entity
    {
        /// <summary>
        /// Placeholder for actual reference to a user.
        /// </summary>
        public string User { get; private set; }

        public Order Order { get; private set; }

        //public Order Order { get; set; }

        private Basket() { }

        public Basket(string user)
        {
            if (string.IsNullOrWhiteSpace(user)) throw new ArgumentException("Basket cannot be created without a user assigned", nameof(user));

            Order = new Order();

            User = user;
        }

        public void AddToBasket(OrderLine orderLine)
        {
            if (orderLine == null) throw new ArgumentNullException(nameof(orderLine));

            Order.AddOrderLine(orderLine);
        }

        public int GetTotal()
        {
            return Order.GetTotal();
        }

        public int GetGiftcardSubTotal()
        {
            return Order.GetGiftcardSubTotal();
        }

        public void CompleteOrder()
        {
            Order.Purchase();
        }
    }
}
