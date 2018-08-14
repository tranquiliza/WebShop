using WebShop.Contracts.GiftcardItem;
using System.Collections.Generic;

namespace WebShop.Contracts.Order
{
    public class PlaceOrderDto
    {
        public CustomerDto Buyer { get; set; }
        public CustomerDto Recipient { get; set; }
        public string Note { get; set; }
        public IEnumerable<OrderLineDto> Orderlines { get; set; }
    }
}
