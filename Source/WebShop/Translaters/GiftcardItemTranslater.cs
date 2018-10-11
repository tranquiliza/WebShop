using System.Collections.Generic;
using WebShop.Contracts.GiftcardItem;
using WebShop.Models.Products;

namespace WebShop.Translaters
{
    public static class GiftcardItemTranslater
    {
        public static GiftcardProductDto Map(this GiftcardProduct giftcardItem)
        {
            return new GiftcardProductDto
            {
                Id = giftcardItem.Id,
                IsPriceOverrideable = giftcardItem.IsPriceOverrideable,
                Name = giftcardItem.Name,
                Price = giftcardItem.Price,
            };
        }

        public static IEnumerable<GiftcardProductDto> Map(this IEnumerable<GiftcardProduct> giftcardItems)
        {
            var result = new List<GiftcardProductDto>();

            foreach (var giftcardItem in giftcardItems)
            {
                result.Add(giftcardItem.Map());
            }

            return result;
        }
    }
}
