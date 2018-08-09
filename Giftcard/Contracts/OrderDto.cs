using System.Collections.Generic;

namespace Giftcard.Contracts
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string OrderIdentifier { get; set; }
        public OrderStatusDto OrderStatus { get; set; }
        public CustomerDto Buyer { get; set; }
        public CustomerDto Recipient { get; set; }
        public string MessageToHotel { get; set; }
        public IEnumerable<GiftcardItemDto> Giftcards { get; set; }
    }
}
