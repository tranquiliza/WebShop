using WebShop.Contracts.Product;

namespace WebShop.Contracts.GiftcardProduct
{
    public class CreateGiftcardProductDto : ProductDto
    {
        public bool IsPriceOverrideable { get; set; }
    }
}