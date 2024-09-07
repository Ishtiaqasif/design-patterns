using Design_Pattern.Behavioral_Patterns.Observer_Pattern.Observables.Concrete_Observables;
using Design_Pattern.Behavioral_Patterns.Observer_Pattern.Observers.Concrete_Observers;

namespace Design_Pattern.Behavioral_Patterns.Observer_Pattern
{
    internal static class ObserverPatternRunner
    {
        public static void Run()
        {
            StockMarketTracker marketTraker = new();

            marketTraker.Add(new WebAppObserver(marketTraker));
            marketTraker.Add(new MobileAppObserver(marketTraker));
            marketTraker.Add(new DesktopAppObserver(marketTraker));

            _ = new FakeStockMarket(marketTraker);

            Console.ReadKey();
        }
    }
}