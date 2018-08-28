namespace WebShop.Contracts.Label
{
    public class LabelValueDto
    {
        public int Id { get; set; }

        public string Language { get; set; }

        public string Value { get; set; }

        public string IsoCode { get; internal set; }
    }
}
