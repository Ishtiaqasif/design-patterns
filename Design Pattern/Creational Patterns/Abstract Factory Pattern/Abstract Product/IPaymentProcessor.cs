namespace Design_Pattern.Creational_Patterns.Abstract_Factory_Pattern
{
    public interface IPaymentProcessor
    {
        Transaction ProcessPayment(decimal amount);

        Transaction AuthorizePayment(decimal amount);

        Transaction CapturePayment(string transactionId);

        Transaction VoidPayment(string transactionId);
    }
}