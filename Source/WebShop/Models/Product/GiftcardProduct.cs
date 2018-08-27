﻿using System;

namespace WebShop.Models
{
    public class GiftcardProduct : Product
    {
        /// <summary>
        /// If True, allows to override the price of the giftcard externally
        /// </summary>
        public bool IsPriceOverrideable { get; private set; }

        public string Name
        {
            get
            {
                return ProductInformation.Name;
            }
        }

        public string Description
        {
            get
            {
                return ProductInformation.Description;
            }
        }

        private GiftcardProduct() { }

        public GiftcardProduct(string name, int price) : base(name, price)
        {
        }

        public GiftcardProduct(string name, string description, int price) : base(name, description, price)
        {
        }

        public void SetPriceOverrideAble(bool isPriceOverrideable)
        {
            IsPriceOverrideable = isPriceOverrideable;
        }

        public void UpdateName(string name)
        {
            ProductInformation.UpdateName(name);
        }

        public void UpdateDescription(string description)
        {
            ProductInformation.UpdateDescription(description);
        }
    }
}
