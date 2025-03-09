namespace Design_Pattern.Creational_Patterns.Abstract_Factory_Pattern
{
    public interface IPaymentGatewayFactory
    {
        IPaymentProcessor CreatePaymentProcessor();

        IRefundProcessor CreateRefundProcessor();
    }
}