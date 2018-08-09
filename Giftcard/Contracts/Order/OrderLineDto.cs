using Giftcard.Contracts.GiftcardItem;

namespace Giftcard.Contracts.Order
{
    public class OrderLineDto
    {
        public GiftcardItemDto GiftcardItem { get; set; }
        public int Amount { get; set; }
    }
}
