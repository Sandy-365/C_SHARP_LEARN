/*
NOTE:
This program demonstrates how important methods of System.Object work in C#.

Covered Concepts:
1. Equals(object)
   - Overridden to implement value-based equality.
   - Two _32_Portfolio objects are equal if their Name values are equal.

2. == Operator
   - Not overloaded in this program.
   - Performs reference equality for class types.

3. GetHashCode()
   - Overridden to stay consistent with Equals().
   - Required for correct behavior in hash-based collections.

4. GetType()
   - Returns the runtime type of the object.
   - Shows polymorphism: base class reference pointing to derived object.

5. ReferenceEquals(object, object)
   - Checks whether two references point to the same memory location.
   - Ignores any overridden Equals() logic.

Extra Notes:
- If Equals() is overridden, GetHashCode() must also be overridden.
- GetType() cannot be overridden.
- ReferenceEquals() always checks identity, not value.
- By default, classes use reference equality unless overridden.
- Overloading == and != provides full value equality support.

*/

class _32_Portfolio
{
    public string Name;

    public override bool Equals(object obj)
    {
        _32_Portfolio p = obj as _32_Portfolio;   // Safe casting using 'as'
        return p != null && p.Name == Name;       // Value-based comparison
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();                // Same Name → same hash code
    }
}

class _32_Trade
{
    // Base class
}

class _32_EquityTrade : _32_Trade
{
    // Derived class
}

class _32_Program
{
    public void Main()
    {
        _32_Portfolio p1 = new _32_Portfolio { Name = "Sandeep" };
        _32_Portfolio p2 = new _32_Portfolio { Name = "Sandeep" };
        _32_Portfolio p3 = new _32_Portfolio { Name = "Kumar" };

        Console.WriteLine("\nNow Checking EQUALS with p1 and p2 with SAME name");
        Console.WriteLine($"Checking the equality using Equals ::>> {p1.Equals(p2)}");   // True (value equality)
        Console.WriteLine($"Checking the equality using '==' ::>> {(p1 == p2)}");       // False (reference equality)

        Console.WriteLine("\nNow Checking HashCode with p1 and p2 with SAME name");
        Console.WriteLine($"HashCode of P1 is {p1.GetHashCode()} and HashCode of p2 is {p2.GetHashCode()}"); // Same hash

        Console.WriteLine("\nNow Checking EQUALS with p1 and p3 with DIFFERENT name");
        Console.WriteLine($"Checking the equality using Equals ::>> {p1.Equals(p3)}");  // False
        Console.WriteLine($"Checking the equality using '==' ::>> {p1 == p3}");         // False

        Console.WriteLine("\nNow Checking HashCode with p1 and p3 with DIFFERENT name");
        Console.WriteLine($"HashCode of P1 is {p1.GetHashCode()} and HashCode of p3 is {p3.GetHashCode()}"); // Different hash

        _32_Trade tradeObj = new _32_EquityTrade();   // Base reference → derived object
        Console.WriteLine($"\nChecking the type of tradeObj ::>> {tradeObj.GetType()}");        // Prints runtime type (_32_EquityTrade)

        _32_Trade tradeObj2 = tradeObj;               // Both references point to same object
        Console.WriteLine($"\nChecking the refrence address is equal for both tradeObj and tradeObj2 ::>> {ReferenceEquals(tradeObj, tradeObj2)}"); // True
    }
}
