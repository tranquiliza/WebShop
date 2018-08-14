using WebShop.Contracts.GiftcardItem;

namespace WebShop.Contracts.Order
{
    public class OrderLineDto
    {
        public GiftcardItemDto GiftcardItem { get; set; }
        public int Amount { get; set; }
    }
}
