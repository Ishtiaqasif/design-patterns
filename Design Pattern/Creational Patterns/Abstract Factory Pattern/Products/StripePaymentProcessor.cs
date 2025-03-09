namespace Design_Pattern.Creational_Patterns.Abstract_Factory_Pattern
{
    public class StripePaymentProcessor : IPaymentProcessor
    {
        public Transaction ProcessPayment(decimal amount)
        {
            return new Transaction { Id = Guid.NewGuid().ToString(), Amount = amount, Status = "Processed via Stripe" };
        }

        public Transaction AuthorizePayment(decimal amount)
        {
            return new Transaction { Id = Guid.NewGuid().ToString(), Amount = amount, Status = "Authorized via Stripe" };
        }

        public Transaction CapturePayment(string transactionId)
        {
            return new Transaction { Id = transactionId, Amount = 0, Status = "Captured via Stripe" };
        }

        public Transaction VoidPayment(string transactionId)
        {
            return new Transaction { Id = transactionId, Amount = 0, Status = "Voided via Stripe" };
        }
    }
}