using System;
using System.Collections.Generic;
using WebShop.Models;
using WebShop.Repositories.Interfaces;
using WebShop.Services.Interfaces;

namespace WebShop.Services
{
    public class GiftcardProductService : IGiftcardProductService
    {
        private readonly IGiftcardProductRepository _giftcardItemRepository;

        public GiftcardProductService(IGiftcardProductRepository giftcardItemRepository)
        {
            _giftcardItemRepository = giftcardItemRepository ?? throw new ArgumentNullException(nameof(giftcardItemRepository));
        }

        void IGiftcardProductService.CreateGiftcard(string name, int price)
        {
            var giftcard = new GiftcardProduct(name, price);

            _giftcardItemRepository.Insert(giftcard);
        }

        void IGiftcardProductService.CreateGiftcard(string name, int price, bool isPriceOverrideable)
        {
            var giftcard = new GiftcardProduct(name, price);
            giftcard.SetPriceOverrideAble(isPriceOverrideable);

            _giftcardItemRepository.Insert(giftcard);
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
