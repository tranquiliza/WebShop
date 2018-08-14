namespace WebShop.Contracts.GiftcardItem
{
    public class GiftcardItemDto
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public bool IsPriceOverrideable { get; set; }
    }
}
