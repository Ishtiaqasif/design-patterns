using Design_Pattern.Behavioral_Patterns.Observer_Pattern.Observables.Concrete_Observables;

namespace Design_Pattern.Behavioral_Patterns.Observer_Pattern.Observers.Concrete_Observers
{
    internal class DesktopAppObserver : IObserver
    {
        private readonly StockMarketTracker _observable;

        public DesktopAppObserver(StockMarketTracker observable)
        {
            _observable = observable;
        }

        public void Update()
        {
            List<StockPrice> updatedPrices = _observable.GetStockPrices();
            DisplayUpdate(updatedPrices);
        }

        private void DisplayUpdate(List<StockPrice> updatedPrices)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Update List at Desktop App: ");
            Console.WriteLine("------------------------------------------");
            foreach (var price in updatedPrices)
            {
                Console.WriteLine($"Symbol: " + price.Symbol);
                Console.WriteLine("New Price: " + (int)price.CurrentPrice);
                Console.WriteLine("Last Update Time: " + price.LastUpdateTime);
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------------");
        }
    }
}