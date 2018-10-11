using System.Collections.Generic;
using WebShop.Models.Products;

namespace WebShop.Services.Interfaces
{
    public interface IGiftcardProductService
    {
        void CreateGiftcard(string name, int price, bool isPriceOverrideable);
        void CreateGiftcard(string name, int price);
        GiftcardProduct Get(int id);
        IEnumerable<GiftcardProduct> Get();
    }
}
