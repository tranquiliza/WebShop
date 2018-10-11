using System;
using WebShop.Models.Products;

namespace WebShop.Models.Orders
{
    public class OrderLine : Entity
    {
        public int Amount { get; set; }

        public Product Product { get; set; }

        protected OrderLine() { }

        public OrderLine(int amount, Product product)
        {
            if (amount <= 0) throw new ArgumentException("amount cannot be negative or zero");

            Amount = amount;
            Product = product ?? throw new ArgumentNullException(nameof(product));
        }
    }
}
