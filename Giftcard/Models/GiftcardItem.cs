using System;

namespace Giftcard.Models
{
    public class GiftcardItem
    {
        public int Id { get; private set; }
        /// <summary>
        /// Price in lowest unit (Dkk would be øre)
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// Name of the Product
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// If True, allows the user to override the price of the giftcard from frontend? 
        /// </summary>
        public bool IsPriceOverrideable { get; set; }

        private GiftcardItem() { }

        public GiftcardItem(string name, int price)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name must be given", nameof(name));
            if (price <= 0) throw new ArgumentException("Price must be above 0", nameof(price));

            Name = name;
            Price = price;
        }

        public GiftcardItem(string name, int price, bool isPriceOverrideable)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("message", nameof(name));
            if (price <= 0) throw new ArgumentException("Price must be above 0", nameof(price));

            Name = name;
            Price = price;
            IsPriceOverrideable = isPriceOverrideable;
        }

    }
}
