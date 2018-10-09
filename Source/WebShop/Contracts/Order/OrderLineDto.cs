using WebShop.Contracts.Product;

namespace WebShop.Contracts.Order
{
    public class OrderLineDto
    {
        public ProductDto GiftcardItem { get; set; }
        public int Amount { get; set; }
    }
}
