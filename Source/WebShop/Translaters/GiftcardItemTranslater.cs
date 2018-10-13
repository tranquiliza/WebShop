using System.Collections.Generic;
using WebShop.Contracts.GiftcardProduct;
using WebShop.Models.Products;

namespace WebShop.Translaters
{
    public static class GiftcardProductTranslater
    {
        public static GiftcardProductDto Map(this GiftcardProduct giftcardProduct)
        {
            return new GiftcardProductDto
            {
                Id = giftcardProduct.Id,
                IsPriceOverrideable = giftcardProduct.IsPriceOverrideable,
                Name = giftcardProduct.Name,
                Price = giftcardProduct.Price,
            };
        }

        public static IEnumerable<GiftcardProductDto> Map(this IEnumerable<GiftcardProduct> giftcardProducts)
        {
            var result = new List<GiftcardProductDto>();

            foreach (var giftcardProduct in giftcardProducts)
            {
                result.Add(giftcardProduct.Map());
            }

            return result;
        }
    }
}
