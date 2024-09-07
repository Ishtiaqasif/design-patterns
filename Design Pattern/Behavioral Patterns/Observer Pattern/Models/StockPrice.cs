namespace Design_Pattern.Behavioral_Patterns.Observer_Pattern.Observables.Concrete_Observables
{
    public class StockPrice
    {
        public string Symbol { get; set; }         // The stock's ticker symbol (e.g., "AAPL" for Apple)
        public decimal CurrentPrice { get; set; }  // The current price of the stock
        public decimal OpeningPrice { get; set; }  // The price of the stock at market open
        public decimal HighPrice { get; set; }     // The highest price of the stock for the current period
        public decimal LowPrice { get; set; }      // The lowest price of the stock for the current period
        public DateTime LastUpdateTime { get; set; } // The last time the stock price was updated

        private static readonly Random _random = new Random();

        public static List<StockPrice> GenerateRandomStockPrices()
        {
            int count = _random.Next(1, 4); // Random count between 1 and 10
            var stockPrices = new List<StockPrice>();

            for (int i = 0; i < count; i++)
            {
                var stockPrice = new StockPrice
                {
                    Symbol = $"SYM{i}", // Assign a unique symbol or generate as needed
                    OpeningPrice = (decimal)(_random.NextDouble() * 100), // Example opening price between 0 and 100
                    CurrentPrice = (decimal)(_random.NextDouble() * 100),
                    HighPrice = (decimal)(_random.NextDouble() * 100),
                    LowPrice = (decimal)(_random.NextDouble() * 100),
                    LastUpdateTime = DateTime.Now
                };

                // Adjust HighPrice and LowPrice based on CurrentPrice
                stockPrice.HighPrice = Math.Max(stockPrice.CurrentPrice, stockPrice.HighPrice);
                stockPrice.LowPrice = Math.Min(stockPrice.CurrentPrice, stockPrice.LowPrice);

                // Randomize CurrentPrice within a certain range for the example
                decimal priceChangeRange = 0.05m; // 5% range
                decimal priceChange = (decimal)(_random.NextDouble() * (double)priceChangeRange * 2 - (double)priceChangeRange);
                stockPrice.CurrentPrice += priceChange;

                // Ensure the price stays within bounds
                stockPrice.CurrentPrice = Math.Max(stockPrice.LowPrice, Math.Min(stockPrice.CurrentPrice, stockPrice.HighPrice));

                // Update LastUpdateTime
                stockPrice.LastUpdateTime = DateTime.Now;

                stockPrices.Add(stockPrice);
            }

            return stockPrices;
        }
    }
}