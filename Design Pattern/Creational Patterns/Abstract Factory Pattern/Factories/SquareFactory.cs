namespace Design_Pattern.Creational_Patterns.Abstract_Factory_Pattern
{
    public class SquareFactory : IPaymentGatewayFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new SquarePaymentProcessor();
        }

        public IRefundProcessor CreateRefundProcessor()
        {
            return new SquareRefundProcessor();
        }
    }
}