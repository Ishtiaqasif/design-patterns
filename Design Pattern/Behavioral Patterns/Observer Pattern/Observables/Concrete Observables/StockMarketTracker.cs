using Design_Pattern.Behavioral_Patterns.Observer_Pattern.Observers;

namespace Design_Pattern.Behavioral_Patterns.Observer_Pattern.Observables.Concrete_Observables
{
    internal class StockMarketTracker : IObservable
    {
        private readonly List<IObserver> observers;

        public StockMarketTracker()
        {
            observers = new List<IObserver>();
        }

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public List<StockPrice> GetStockPrices()
        {
            return StockPrice.GenerateRandomStockPrices();
        }
    }
}