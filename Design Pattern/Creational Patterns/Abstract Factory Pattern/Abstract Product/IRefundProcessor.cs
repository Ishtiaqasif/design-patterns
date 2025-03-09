namespace Design_Pattern.Creational_Patterns.Abstract_Factory_Pattern
{
    public interface IRefundProcessor
    {
        Refund ProcessRefund(decimal amount);
    }
}