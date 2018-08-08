using System.Collections.Generic;

namespace Giftcard.Contracts
{
    public class OrderDto
    {
        public CustomerDto Buyer { get; set; }
        public CustomerDto Recipient { get; set; }
        public string MessageToHotel { get; set; }
        public IEnumerable<GiftcardItemDto> Giftcards { get; set; }
    }
}
