using WebShop.Models;
using System.Collections.Generic;

namespace WebShop.Services.Abstractions
{
    public interface IGiftcardProductService
    {
        void CreateGiftcard(string name, int price, bool isPriceOverrideable);
        void CreateGiftcard(string name, int price);
        GiftcardProduct Get(int id);
        IEnumerable<GiftcardProduct> Get();
    }
}
