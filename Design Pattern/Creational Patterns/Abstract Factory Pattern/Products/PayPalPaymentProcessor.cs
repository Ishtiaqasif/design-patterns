namespace Design_Pattern.Creational_Patterns.Abstract_Factory_Pattern
{
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public Transaction ProcessPayment(decimal amount)
        {
            return new Transaction { Id = Guid.NewGuid().ToString(), Amount = amount, Status = "Processed via PayPal" };
        }

        public Transaction AuthorizePayment(decimal amount)
        {
            return new Transaction { Id = Guid.NewGuid().ToString(), Amount = amount, Status = "Authorized via PayPal" };
        }

        public Transaction CapturePayment(string transactionId)
        {
            return new Transaction { Id = transactionId, Amount = 0, Status = "Captured via PayPal" };
        }

        public Transaction VoidPayment(string transactionId)
        {
            return new Transaction { Id = transactionId, Amount = 0, Status = "Voided via PayPal" };
        }
    }
}