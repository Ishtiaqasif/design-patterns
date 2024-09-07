using Design_Pattern.Behavioral_Patterns.Observer_Pattern.Observables.Concrete_Observables;

namespace Design_Pattern.Behavioral_Patterns.Observer_Pattern
{
    internal class FakeStockMarket
    {
        private static readonly Random _random = new Random();
        private Timer _timer;
        private readonly StockMarketTracker _tracker;

        public FakeStockMarket(StockMarketTracker tracker)
        {
            _tracker = tracker;
            // Initialize the timer with a callback method and an initial due time of 0
            _timer = new Timer(TimerCallback, null, Timeout.Infinite, Timeout.Infinite);
            StartRandomTimer();
        }

        private void StartRandomTimer()
        {
            // Calculate a random interval between 1 and 10 seconds (in milliseconds)
            int interval = _random.Next(1000, 10001); // 1000 ms = 1 sec, 10000 ms = 10 sec
            _timer.Change(interval, Timeout.Infinite);
        }

        private void TimerCallback(object state)
        {
            Notify(); // Call the Notify method

            // Restart the timer with a new random interval
            StartRandomTimer();
        }

        public void Notify()
        {
            Console.WriteLine();
            _tracker.Notify();
            Console.WriteLine();
            // Add your notify logic here
        }
    }
}