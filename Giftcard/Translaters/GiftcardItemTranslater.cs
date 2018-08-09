using Giftcard.Contracts.GiftcardItem;
using Giftcard.Models;
using System.Collections.Generic;

namespace Giftcard.Translaters
{
    public static class GiftcardItemTranslater
    {
        public static GiftcardItemDto Map(this GiftcardItem giftcardItem)
        {
            return new GiftcardItemDto
            {
                Id = giftcardItem.Id,
                IsPriceOverrideable = giftcardItem.IsPriceOverrideable,
                Name = giftcardItem.Name,
                Price = giftcardItem.Price,
            };
        }

        public static IEnumerable<GiftcardItemDto> Map(this IEnumerable<GiftcardItem> giftcardItems)
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
