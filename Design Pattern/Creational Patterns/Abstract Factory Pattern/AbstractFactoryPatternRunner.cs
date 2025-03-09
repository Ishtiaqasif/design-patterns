namespace Design_Pattern.Creational_Patterns.Abstract_Factory_Pattern
{
    public static class AbstractFactoryPatternRunner
    {
        public static void Run()
        {
            Console.WriteLine("Select Payment Gateway: 1. PayPal  2. Stripe  3. Square");
            string choice = Console.ReadLine();

            IPaymentGatewayFactory paymentFactory = choice switch
            {
                "1" => new PayPalFactory(),
                "2" => new StripeFactory(),
                "3" => new SquareFactory(),
                _ => throw new Exception("Invalid Choice")
            };

            IPaymentProcessor paymentProcessor = paymentFactory.CreatePaymentProcessor();

            Transaction transaction = paymentProcessor.ProcessPayment(100.00m);
            Console.WriteLine($"Transaction ID: {transaction.Id}, Amount: {transaction.Amount}, Status: {transaction.Status}");
            
            Console.WriteLine();

            Console.WriteLine("Select Payment Gateway: 1. PayPal  2. Stripe  3. Square");
            
            choice = Console.ReadLine();

            IPaymentGatewayFactory refundFactory = choice switch
            {
                "1" => new PayPalFactory(),
                "2" => new StripeFactory(),
                "3" => new SquareFactory(),
                _ => throw new Exception("Invalid Choice")
            };


            IRefundProcessor refundProcessor = refundFactory.CreateRefundProcessor();

            Refund refund = refundProcessor.ProcessRefund(100.00m);
            Console.WriteLine($"Transaction ID: {refund.Id}, Amount: {refund.Amount}, Status: {refund.Status}");
        }
    }
}