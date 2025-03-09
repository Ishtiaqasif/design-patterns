namespace Design_Pattern.Creational_Patterns.Abstract_Factory_Pattern
{
    public class StripeFactory : IPaymentGatewayFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new StripePaymentProcessor();
        }

        public IRefundProcessor CreateRefundProcessor()
        {
            return new StripeRefundProcessor();
        }
    }
}