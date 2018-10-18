namespace WebShop.Models.Payments
{
    public class PaymentInformation : Entity
    {
        public PaymentStatus PaymentStatus { get; private set; }

        public string TransationIdentifier { get; private set; }

        public string DibsMerchantId { get; private set; }

        protected PaymentInformation() { }
    }
}