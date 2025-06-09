namespace PublisherSubscriberExample
{
    public delegate void StockPriceChangeHandler(string Stock, decimal? Price);

    public class StockMarket
    {
        public event StockPriceChangeHandler StockPriceChanged;
        
        public void UpdateStockPrice(string stock, decimal newPrice)
        {
            Console.WriteLine($"StockMarket: Stock {stock} updated to {newPrice:C}");

            StockPriceChanged?.Invoke(stock, newPrice);
        }
    }
    public class Investor
    {
        public string Name {  get; set; }

        public Investor(string name) 
        { 
            Name = name;
        }

        public void OnStockPriceChanged(string stock, decimal? price)
        {
            Console.WriteLine($"{Name} notified: {stock} is now {price:C}");
        }
    }

    class Program
    {
        public static void Main(string[] args) 
        {
            // Create a stock market (publisher)
            var stockMarket = new StockMarket();

            // Create investors (subscribers)
            var investor1 = new Investor("Ritesh");
            var investor2 = new Investor("Abhijeet");

            // Subscribe to the stock market's price change event
            stockMarket.StockPriceChanged += investor1.OnStockPriceChanged;
            stockMarket.StockPriceChanged += investor2.OnStockPriceChanged;

            stockMarket.UpdateStockPrice("MRF", 10000);
            stockMarket.UpdateStockPrice("Adani", 3000);

            stockMarket.StockPriceChanged -= investor2.OnStockPriceChanged;
            stockMarket.UpdateStockPrice("GOOGL", 2800);

            Console.WriteLine("End of simulation.");
            Console.ReadLine();
        }
    }
}