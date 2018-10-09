using WebShop.Contracts.Product;

namespace WebShop.Contracts.GiftcardItem
{
    public class CreateGiftcardProductDto : ProductDto
    {
        public bool IsPriceOverrideable { get; set; }
    }
}