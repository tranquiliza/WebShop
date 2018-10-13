using WebShop.Contracts.Product;

namespace WebShop.Contracts.Order
{
    public class OrderLineDto
    {
        public ProductDto GiftcardProducts { get; set; }
        public int Amount { get; set; }
    }
}
