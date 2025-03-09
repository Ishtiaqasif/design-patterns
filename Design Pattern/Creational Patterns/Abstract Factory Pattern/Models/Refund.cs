namespace Design_Pattern.Creational_Patterns.Abstract_Factory_Pattern
{
    public class Refund
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public decimal Amount { get; set; }
        public string Status { get; set; } = "Refunded";
    }
}