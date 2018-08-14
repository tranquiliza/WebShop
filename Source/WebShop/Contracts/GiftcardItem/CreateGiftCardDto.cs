namespace WebShop.Contracts.GiftcardItem
{
    public class CreateGiftCardDto
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsPriceOverrideable { get; set; }
    }
}