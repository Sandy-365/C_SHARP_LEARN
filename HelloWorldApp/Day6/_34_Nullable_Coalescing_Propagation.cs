/*
NOTE:
This program demonstrates:
1. Nullable Types (?)
2. Null Coalescing Operator (??)
3. Null Propagation Operator (?.)

Why this matters:
- Real-world data can be missing
- APIs can return null
- Market feeds may fail
- Systems must NOT crash

These features help write SAFE, STABLE, and CLEAN code.
*/

class _34_Account
{
    public double Balance { get; set; }
}

class _34_Stock
{
    public string Symbol { get; set; }
    public double? LivePrice { get; set; }   // Nullable type
}

class _34_Program
{
    public void Main()
    {
        // --------------------------------------------------
        // 1. NULLABLE TYPES (?)
        // --------------------------------------------------

        double? livePrice = null;              // Price not yet received
        int? quantity = null;                  // Quantity unknown

        // Nullable value types can safely hold null
        Console.WriteLine("Live Price ::> " + livePrice);
        Console.WriteLine("Quantity ::> " + quantity);

        // --------------------------------------------------
        // 2. NULL COALESCING OPERATOR (??)
        // --------------------------------------------------

        // If livePrice is null, use default value 0.0
        double displayPrice = livePrice ?? 0.0;

        Console.WriteLine("Display Price ::> " + displayPrice);

        /*
        Equivalent logic:
        if (livePrice != null)
            displayPrice = livePrice.Value;
        else
            displayPrice = 0.0;
        */

        // --------------------------------------------------
        // 3. NULL PROPAGATION OPERATOR (?.)
        // --------------------------------------------------

        _34_Account acc = null;                     // Account not initialized

        // Safe access using ?. operator
        double? balance = acc?.Balance;

        Console.WriteLine("Account Balance ::> " + balance);

        /*
        Without ?. this would crash:
        acc.Balance -> NullReferenceException
        */

        // --------------------------------------------------
        // 4. COMBINED USAGE (?. and ??)
        // --------------------------------------------------

        // Safe access + default value
        double finalBalance = acc?.Balance ?? 0.0;

        Console.WriteLine("Final Balance ::> " + finalBalance);

        /*
        Step-by-step:
        1. acc?.Balance  -> null (safe)
        2. null ?? 0.0   -> 0.0
        3. Program continues safely
        */

        // --------------------------------------------------
        // 5. REAL-WORLD STOCK MARKET EXAMPLE
        // --------------------------------------------------

        _34_Stock stock = new _34_Stock
        {
            Symbol = "CG",
            LivePrice = null                  // Feed not yet available
        };

        // Safe price retrieval
        double stockPrice = stock?.LivePrice ?? 0.0;

        Console.WriteLine("Stock Symbol ::> " + stock.Symbol);
        Console.WriteLine("Stock Price ::> " + stockPrice);
    }
}
