namespace Design_Pattern.Creational_Patterns.Abstract_Factory_Pattern
{
    public class PayPalFactory : IPaymentGatewayFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new PayPalPaymentProcessor();
        }

        public IRefundProcessor CreateRefundProcessor()
        {
            return new PayPalRefundProcessor();
        }
    }
}