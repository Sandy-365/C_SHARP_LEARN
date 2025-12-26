/*
NOTE:
This program demonstrates TWO IMPORTANT C# FEATURES:

1. Extension Methods
   - Add new behavior to existing types
   - Do NOT modify original class
   - Do NOT use inheritance
   - Compile-time feature (no runtime overhead)

2. Pattern Matching
   - Combines type checking + casting
   - Safer and cleaner than old-style casting
   - Used heavily in polymorphic systems

Finance Context:
- Extension methods → Tax, brokerage, charges
- Pattern matching → Trade identification and routing
*/

using System;

// --------------------------------------------------
// PART A: EXTENSION METHOD
// --------------------------------------------------

static class _35_FinancialExtensions
{
    // Extension method on double
    // 'this double amount' tells compiler that double is being extended
    public static double Tax(this double amount)
    {
        return amount * 0.18;     // 18% tax calculation
    }
}

// --------------------------------------------------
// PART B: PATTERN MATCHING CLASSES
// --------------------------------------------------

class _35_Trade
{
    public int TradeId { get; set; }
}

class _35_EquityTrade : _35_Trade
{
    public string Symbol { get; set; }
}

// --------------------------------------------------
// MAIN PROGRAM
// --------------------------------------------------

class _35_Program
{
    public void Main()
    {
        // ---------------- EXTENSION METHOD USAGE ----------------

        double tradeAmount = 10000;

        // Calling extension method using dot notation
        double tax = tradeAmount.Tax();

        Console.WriteLine("Trade Amount ::> " + tradeAmount);
        Console.WriteLine("Tax (18%) ::> " + tax);

        /*
        Internally compiler converts this to:
        double tax = _35_FinancialExtensions.Tax(tradeAmount);
        */

        Console.WriteLine();

        // ---------------- PATTERN MATCHING USAGE ----------------

        _35_Trade trade = new _35_EquityTrade
        {
            TradeId = 101,
            Symbol = "CG"
        };

        // Pattern matching: check type + cast in one step
        if (trade is _35_EquityTrade et)
        {
            Console.WriteLine("Equity Trade Detected");
            Console.WriteLine("Trade Id ::> " + et.TradeId);
            Console.WriteLine("Symbol ::> " + et.Symbol);
        }
        else
        {
            Console.WriteLine("Unknown Trade Type");
        }
    }
}
