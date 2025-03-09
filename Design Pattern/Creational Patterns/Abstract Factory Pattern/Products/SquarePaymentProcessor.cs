namespace Design_Pattern.Creational_Patterns.Abstract_Factory_Pattern
{
    public class SquarePaymentProcessor : IPaymentProcessor
    {
        public Transaction ProcessPayment(decimal amount)
        {
            return new Transaction { Id = Guid.NewGuid().ToString(), Amount = amount, Status = "Processed via Square" };
        }

        public Transaction AuthorizePayment(decimal amount)
        {
            return new Transaction { Id = Guid.NewGuid().ToString(), Amount = amount, Status = "Authorized via Square" };
        }

        public Transaction CapturePayment(string transactionId)
        {
            return new Transaction { Id = transactionId, Amount = 0, Status = "Captured via Square" };
        }

        public Transaction VoidPayment(string transactionId)
        {
            return new Transaction { Id = transactionId, Amount = 0, Status = "Voided via Square" };
        }
    }
}