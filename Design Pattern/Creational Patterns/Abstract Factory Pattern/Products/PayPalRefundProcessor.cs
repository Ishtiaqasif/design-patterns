namespace Design_Pattern.Creational_Patterns.Abstract_Factory_Pattern
{
    public class PayPalRefundProcessor : IRefundProcessor
    {
        public Refund ProcessRefund(decimal amount)
        {
            return new Refund() { Id = Guid.NewGuid().ToString(), Amount = amount, Status = "Refunded by PayPal" };
        }
    }
}