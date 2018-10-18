using System;
using WebShop.Models.Orders;
using WebShop.Models.Users;

namespace WebShop.Models.Baskets
{
    public class Basket : Entity
    {
        /// <summary>
        /// Placeholder for actual reference to a user.
        /// </summary>
        public User User { get; private set; }

        public Order Order { get; private set; }

        protected Basket() { }

        public Basket(User user)
        {
            Order = new Order();
            User = user ?? throw new ArgumentNullException(nameof(user));
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
            Order.PlaceOrder();
        }
    }
}
