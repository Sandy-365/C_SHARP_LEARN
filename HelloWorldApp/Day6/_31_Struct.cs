/*
NOTE:
This program demonstrates the difference between VALUE TYPES (struct)
and REFERENCE TYPES (class) in C#.

Key Concepts:
1. struct (_31_StockPrice)
   - Structs are VALUE TYPES.
   - Assignment creates a COPY of data.
   - Changes in the copied variable do NOT affect the original variable.

2. class (_31_Trade)
   - Classes are REFERENCE TYPES.
   - Assignment copies the REFERENCE, not the object.
   - Changes through one reference affect the same object in memory.

3. This program clearly shows:
   - Struct → copy-by-value behavior
   - Class → copy-by-reference behavior

Extra Notes:
- Structs are usually small, immutable data containers.
- Classes are preferred for complex objects with shared state.
- Value types are stored on stack (conceptually), reference types on heap.
- Understanding this is critical for performance and bug-free code.

*/

public struct _31_StockPrice
{
    public string StockSymbol;
    public float Price;
}

class _31_Trade
{
    public string? TradeID;
    public string? StockSymbol;
    public float Quantity;
}

class _31_Program
{
    public void Main()
    {
        _31_StockPrice originalPriceObj = new _31_StockPrice();
        originalPriceObj.StockSymbol = "CG";
        originalPriceObj.Price = 40000.0f;

        _31_StockPrice chanegPriceObj = originalPriceObj;   // COPY of struct (value type)
        chanegPriceObj.Price = 3000;                        // Does NOT affect originalPriceObj

        _31_Trade tradeObj = new _31_Trade
        {
            TradeID = "123",
            StockSymbol = "CG",
            Quantity = 456
        };

        _31_Trade copyObj = tradeObj;                        // COPY of reference
        copyObj.Quantity = 700;                              // Affects tradeObj as well

        Console.WriteLine($"Original Stock Price: {originalPriceObj.StockSymbol} - {originalPriceObj.Price}");
        // Prints 40000.0 → original value unchanged

        Console.WriteLine($"Trade Stock Price: {tradeObj.StockSymbol} - {tradeObj.Quantity}");
        // Prints 700 → same object modified via copyObj
    }
}
