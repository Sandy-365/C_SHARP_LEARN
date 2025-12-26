/*
NOTE:
This program demonstrates CORE GENERICS concepts in C# in a clean and exam-ready way.

Concepts Covered:
1. Generic Class with Constraint
   - Repo<D> uses a type parameter.
   - 'where D : class' ensures only reference types are allowed.
   - Gives compile-time type safety and reusability.

2. Generic Method
   - Calculate<T>() is a method-level generic.
   - Type is decided at method call time.
   - Avoids writing multiple overloaded methods.

3. Why Generics Matter
   - Type safety (no runtime casting errors)
   - Better performance (no boxing/unboxing)
   - Reusable and clean design

Important Notes:
- Generics work at COMPILE TIME, not runtime.
- Constraints restrict what types are allowed.
- Generic classes are common in repository and service layers.
*/

class Repo<D> where D : class
{
    public D Data;      // D is guaranteed to be a reference type
}

class _33_Customer
{
    public string Name;
}

class _33_Trade
{
    public int TradeId { get; set; }
    public string Symbol { get; set; }
}

/*
Generic Calculator Class
Demonstrates a GENERIC METHOD
*/
class _33_Calculator
{
    public T Calculate<T>(T a, T b)
    {
        // This method is generic, but does NOT perform addition
        // It only returns 'a' to demonstrate method-level generics
        // Actual addition needs constraints or generic math
        return a;
    }
}

class _33_Program
{
    public void Main()
    {
        // ---------------- GENERIC CLASS USAGE ----------------

        Repo<_33_Customer> customerRepo = new Repo<_33_Customer>();
        customerRepo.Data = new _33_Customer { Name = "Sandeep" };

        Console.WriteLine($"Customer Name ::> {customerRepo.Data.Name}");
        // No casting needed → type safety at compile time

        Repo<_33_Trade> tradeRepo = new Repo<_33_Trade>();
        tradeRepo.Data = new _33_Trade
        {
            TradeId = 101,
            Symbol = "CG"
        };

        Console.WriteLine($"Trade Id ::> {tradeRepo.Data.TradeId}");
        Console.WriteLine($"Trade Symbol ::> {tradeRepo.Data.Symbol}");

        // ---------------- GENERIC METHOD USAGE ----------------

        _33_Calculator calc = new _33_Calculator();

        int intResult = calc.Calculate(10, 30);
        Console.WriteLine("Int Result ::> " + intResult);

        double doubleResult = calc.Calculate(10.5, 20.8);
        Console.WriteLine("Double Result ::> " + doubleResult);

        string stringResult = calc.Calculate("Hello", "World");
        Console.WriteLine("String Result ::> " + stringResult);

        /*
        What happened above:
        - Same method Calculate<T>()
        - Called with int, double, string
        - Compiler replaces T at compile time
        */
    }
}
