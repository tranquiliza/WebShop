using System;

namespace WebShop.Models
{
    public abstract class Product : Entity
    {
        /// <summary>
        /// Information about the product
        /// </summary>
        protected ProductInformation ProductInformation { get; private set; }

        /// <summary>
        /// Price in lowest unit (Dkk would be øre)
        /// </summary>
        public int Price { get; set; }

        protected Product() { }

        protected Product(string name, int price)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name must be given", nameof(name));
            if (price <= 0) throw new ArgumentException("Price must be above 0", nameof(price));

            ProductInformation = new ProductInformation(name);
            Price = price;
        }

        protected Product(string name, string description, int price) 
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name must be given", nameof(name));
            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentException("Description must be given", nameof(description));

            ProductInformation = new ProductInformation(name, description);
            Price = price;
        }
    }
}
