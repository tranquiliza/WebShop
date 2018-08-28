using System.Collections.Generic;
using WebShop.Contracts.GiftcardItem;
using WebShop.Models;

namespace WebShop.Translaters
{
    public static class GiftcardItemTranslater
    {
        public static GiftcardItemDto Map(this GiftcardProduct giftcardItem)
        {
            return new GiftcardItemDto
            {
                Id = giftcardItem.Id,
                IsPriceOverrideable = giftcardItem.IsPriceOverrideable,
                Name = giftcardItem.Name,
                Price = giftcardItem.Price,
            };
        }

        public static IEnumerable<GiftcardItemDto> Map(this IEnumerable<GiftcardProduct> giftcardItems)
        {
            var result = new List<GiftcardItemDto>();

            foreach (var giftcardItem in giftcardItems)
            {
                result.Add(giftcardItem.Map());
            }

            return result;
        }
    }
}
