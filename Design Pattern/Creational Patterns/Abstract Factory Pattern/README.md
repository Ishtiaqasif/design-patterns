# Abstract Factory Pattern - Payment Gateway Example

## Definition

The **Abstract Factory Pattern** is a **creational design pattern** that provides an interface for creating families of related objects without specifying their concrete classes. This pattern encapsulates object creation logic, ensuring dynamic instantiation of objects based on specific requirements.

## Key Components

1. **Abstract Factory (IPaymentGatewayFactory)**: Declares methods for creating families of related objects.
2. **Concrete Factories (PayPalFactory, StripeFactory, SquareFactory)**: Implement the factory interface and create specific payment processors.
3. **Abstract Products (IPaymentProcessor, IRefundProcessor)**: Define interfaces for products created by factories.
4. **Concrete Products (PayPalPaymentProcessor, StripePaymentProcessor, SquarePaymentProcessor, PayPalRefundProcessor, etc.)**: Implement product interfaces.
5. **Client (PaymentClient)**: Uses the abstract factory to create objects.

## Implementation Example

In this example, the Abstract Factory Pattern is used to create different types of payment processors based on the selected payment gateway.

### Components

1. **IPaymentProcessor Interface**

   Defines the methods required for all payment processors.

2. **Concrete Classes**

   - **PayPalPaymentProcessor**: Implements `IPaymentProcessor` with PayPal-specific logic.
   - **StripePaymentProcessor**: Implements `IPaymentProcessor` with Stripe-specific logic.
   - **SquarePaymentProcessor**: Implements `IPaymentProcessor` with Square-specific logic.

3. **IRefundProcessor Interface**

   Defines the method for processing refunds.

4. **Concrete Refund Processor Classes**

   - **PayPalRefundProcessor**: Implements `IRefundProcessor` for PayPal.
   - **StripeRefundProcessor**: Implements `IRefundProcessor` for Stripe.
   - **SquareRefundProcessor**: Implements `IRefundProcessor` for Square.

5. **IPaymentGatewayFactory Interface**

   Declares methods to create `IPaymentProcessor` and `IRefundProcessor` objects.

6. **Concrete Factory Classes**

   - **PayPalFactory**: Implements `IPaymentGatewayFactory` to create PayPal processors.
   - **StripeFactory**: Implements `IPaymentGatewayFactory` to create Stripe processors.
   - **SquareFactory**: Implements `IPaymentGatewayFactory` to create Square processors.

7. **PaymentClient Class**

   Uses the appropriate factory to create payment processors based on user input.

8. **AbstractFactoryPatternRunner Class**

   Demonstrates the Abstract Factory Pattern by creating various payment processors.

### Example Usage

The `AbstractFactoryPatternRunner` class shows how to use different factories to create payment processors.

```csharp
public static class AbstractFactoryPatternRunner
    {
        public static void Run()
        {
            Console.WriteLine("Select Payment Gateway: 1. PayPal  2. Stripe  3. Square");
            string choice = Console.ReadLine();

            IPaymentGatewayFactory factory = choice switch
            {
                "1" => new PayPalFactory(),
                "2" => new StripeFactory(),
                "3" => new SquareFactory(),
                _ => throw new Exception("Invalid Choice")
            };

            IPaymentProcessor paymentProcessor = factory.CreatePaymentProcessor();

            Transaction transaction = paymentProcessor.ProcessPayment(100.00m);
            Console.WriteLine($"Transaction ID: {transaction.Id}, Amount: {transaction.Amount}, Status: {transaction.Status}");
        }
    }
```

## Benefits of Abstract Factory Pattern

- **Encapsulation of Object Creation**: Centralizes object creation logic, making the system more modular and maintainable.
- **Promotes Consistency**: Ensures that related objects are created together, maintaining consistency across families of objects.
- **Scalability**: Easily extendable to support new payment gateways without modifying existing code.
- **Improved Testability**: Dependency injection and abstraction make unit testing easier.

## Difference Between Abstract Factory and Factory Method

| Feature               | Factory Method Pattern | Abstract Factory Pattern |
|----------------------|----------------------|-------------------------|
| **Purpose**          | Provides a way to instantiate a single product type | Provides a way to create families of related products |
| **Factory Type**     | Single Factory Class | Multiple Factory Classes (One per product family) |
| **Product Scope**    | Creates one type of object | Creates multiple related objects (e.g., Payment and Refund processors) |
| **Flexibility**      | Less flexible when dealing with multiple related objects | More flexible for complex systems requiring families of objects |

This pattern is especially useful in scenarios where multiple products must be created together, such as different processors for payments and refunds in a payment gateway system.

