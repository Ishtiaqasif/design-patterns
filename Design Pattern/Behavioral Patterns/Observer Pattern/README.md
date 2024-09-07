# Observer Pattern Implementation

## Definition

The **Observer Pattern** is a behavioral design pattern that establishes a one-to-many relationship between objects. This pattern allows one object (the **Observable** or **Subject**) to notify multiple dependent objects (the **Observers**) about changes in its state. The Observer Pattern promotes loose coupling and dynamic interaction between components by allowing the observable to maintain and update its observers automatically.

## Key Components

1. **Observable (Subject)**: Maintains a list of observers and provides methods to add, remove, and notify them. The observable is responsible for broadcasting state changes.
2. **Observer**: Receives updates from the observable when its state changes. Observers implement a method to process and act upon these updates.
3. **ConcreteObservable**: A specific implementation of the Observable. It manages the state of interest and notifies registered observers of any changes.
4. **ConcreteObserver**: A specific implementation of the Observer. It defines how to handle updates from the Observable.

## Implementation Example

In this example, the Observer Pattern is used to handle updates in a stock market tracker and notify various applications.

### Components

1. **IObservable Interface**

   Defines the methods required for adding, removing, and notifying observers.

2. **ConcreteObservable**

   - **StockMarketTracker**: Implements the `IObservable` interface and manages a list of observers. It notifies all registered observers about changes in stock prices and provides a method to generate random stock prices.

3. **IObserver Interface**

   Defines the `Update()` method that observers must implement to handle updates from the observable.

4. **Concrete Observers**

   - **WebAppObserver**: Implements `IObserver` to handle updates and display stock prices in a web application format.
   - **MobileAppObserver**: Implements `IObserver` to handle updates and display stock prices in a mobile application format.
   - **DesktopAppObserver**: Implements `IObserver` to handle updates and display stock prices in a desktop application format.

5. **FakeStockMarket Class**

   Simulates stock market data changes and triggers notifications at random intervals. It causes the `StockMarketTracker` to notify all registered observers.

6. **Runner Class**

   Demonstrates the Observer Pattern by setting up the `StockMarketTracker`, adding various observers, and initializing the `FakeStockMarket` to simulate stock price updates.

### Example Usage

The `StrategyPatternRunner` class shows how to use different notification services to send messages through various channels. Each service uses its associated strategy to handle notification delivery.

```csharp
public static void Run()
{
    StockMarketTracker marketTracker = new();

    marketTracker.Add(new WebAppObserver(marketTracker));
    marketTracker.Add(new MobileAppObserver(marketTracker));
    marketTracker.Add(new DesktopAppObserver(marketTracker));

    _ = new FakeStockMarket(marketTracker);

    Console.ReadKey();
}
```
### Summary
This documentation illustrates the Observer Pattern using a stock market tracker and multiple application observers. The StockMarketTracker class (ConcreteObservable) notifies the observers (WebAppObserver, MobileAppObserver, DesktopAppObserver) about changes in stock prices. The FakeStockMarket class simulates stock price updates and triggers notifications at random intervals. The Observer Pattern provides a flexible and decoupled design, facilitating easier management and scalability of systems with multiple dependent components.