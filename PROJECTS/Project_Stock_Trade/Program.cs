class Program
{
    public static void Main(string[] args)
    {
        StockPrice originalPriceObj = new StockPrice();
        originalPriceObj.StockSymbol = "CG";
        originalPriceObj.Price = 40000.0f;

        StockPrice chanegPriceObj = originalPriceObj;
        chanegPriceObj.Price = 3000;


        Trade tradeObj = new Trade
        {
            TradeID = "123",
            StockSymbol = "CG",
            Quantity = 456
        };

        Trade copyObj = tradeObj;
        copyObj.Quantity = 700;

        Console.WriteLine($"Original Stock Price: {originalPriceObj.StockSymbol} - {originalPriceObj.Price}");
        Console.WriteLine($"Trade Stock Price: {tradeObj.StockSymbol} - {tradeObj.Quantity}");
    }
}