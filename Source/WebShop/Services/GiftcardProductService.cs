using System;
using System.Collections.Generic;
using WebShop.Models.Products;
using WebShop.Repositories.Interfaces;
using WebShop.Services.Interfaces;

namespace WebShop.Services
{
    public class GiftcardProductService : IGiftcardProductService
    {
        private readonly IGiftcardProductRepository _giftcardProductRepository;

        public GiftcardProductService(IGiftcardProductRepository giftcardProductRepository)
        {
            _giftcardProductRepository = giftcardProductRepository ?? throw new ArgumentNullException(nameof(giftcardProductRepository));
        }

        void IGiftcardProductService.CreateGiftcard(string name, int price)
        {
            var giftcard = new GiftcardProduct(name, price);

            _giftcardProductRepository.Insert(giftcard);
        }

        void IGiftcardProductService.CreateGiftcard(string name, int price, bool isPriceOverrideable)
        {
            var giftcard = new GiftcardProduct(name, price);
            giftcard.SetPriceOverrideAble(isPriceOverrideable);

            _giftcardProductRepository.Insert(giftcard);
        }

        GiftcardProduct IGiftcardProductService.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<GiftcardProduct> IGiftcardProductService.Get()
        {
            throw new NotImplementedException();
        }
    }
}
