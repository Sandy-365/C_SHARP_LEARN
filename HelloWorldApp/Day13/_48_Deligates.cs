/*
TOPIC: Delegates and Extension Methods in C#

1) Delegate
A delegate is a type-safe function pointer.
It allows a method to be assigned to a variable and called indirectly.
Here, PaymentDelegate represents any method that takes a decimal and returns void.

2) Delegate Usage Flow
- Define delegate
- Create a class with a method matching delegate signature
- Assign method to delegate variable
- Invoke delegate like a normal method

3) Extension Method
An extension method allows adding new methods to an existing type
without modifying its source code.
It is defined inside a static class and must be static itself.
The first parameter uses the 'this' keyword to specify the type being extended.

4) In this program
- decimal type is extended with IsValidPayment()
- Delegate is used to call payment processing dynamically
- Validation is done before processing payment

5) Multicast Delegate
A delegate that holds references to more than one method.
When invoked, it executes all methods in the invocation list in order.

6) Built-in Delegates
Action   -> no return value
Func     -> returns a value
Predicate-> returns bool only

This example shows how delegates, extension methods,
multicast delegates, and built-in delegates work together.
*/

using System;

// Delegate declaration
// Can point to any method that takes a decimal parameter and returns void
delegate void PaymentDelegate(decimal amount);

class PaymentServices
{
    // Method matching delegate signature
    // This method will be invoked using delegate
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Payment of " + amount + " processed successfully.");
    }
}

// Static class is mandatory for extension methods
static class PaymentExtensions
{
    // Extension method for decimal type
    // Allows calling: amt.IsValidPayment()
    // Acts as if this method belongs to decimal type
    public static bool IsValidPayment(this decimal amount)
    {
        // Payment must be positive and within allowed limit
        return amount > 0 && amount <= 1_000_000;
    }
}

// Delegate for order notification system
// Accepts orderId and returns nothing
delegate void OrderDelegate(string orderId);

class NotificationService
{
    // First method for delegate
    // Sends email notification
    public void SendEmail(string id)
    {
        Console.WriteLine("Email sent for Order " + id);
    }

    // Second method for delegate
    // Sends SMS notification
    public void SendSMS(string id)
    {
        Console.WriteLine("SMS sent for order " + id);
    }
}

class _48_Program
{
    public void Main()
    {
        // Creating service object
        PaymentServices service = new PaymentServices();

        // Assigning instance method to delegate
        PaymentDelegate payment = service.ProcessPayment;

        // Calling delegate like a normal method
        payment(5000);

        // Payment amount for validation
        decimal amt = 5948;

        // Using extension method on decimal type
        // Compiler converts this to: PaymentExtensions.IsValidPayment(amt)
        if (amt.IsValidPayment())
        {
            Console.WriteLine("Payment found");

            // Delegate invocation after validation
            payment(amt);
        }
        else
        {
            Console.WriteLine("Inavalid payment found");
        }

        // ---------------- MULTICAST DELEGATE ----------------

        // Creating notification service object
        NotificationService NotService = new NotificationService();

        // Declaring delegate reference
        OrderDelegate notify = null;

        // Adding multiple methods to delegate invocation list
        notify += NotService.SendEmail;
        notify += NotService.SendSMS;

        // Invoking multicast delegate
        // Both SendEmail and SendSMS will execute
        notify("ORD1001");

        // ---------------- ACTION DELEGATE ----------------

        // Action<T> represents a method that takes one parameter and returns void
        Action<string> LogActivity = message =>
            Console.WriteLine("Log Entry: " + message);

        // Calling Action delegate
        LogActivity("User logged in at 10:30 AM");

        // ---------------- FUNC DELEGATE ----------------

        // Func<T1, T2, TResult>
        // Takes two decimal inputs and returns decimal result
        Func<decimal, decimal, decimal> calculateDiscount =
            (price, discount) => price * discount / 100;

        decimal price = 1000m;

        // Calling Func delegate
        Console.WriteLine(calculateDiscount(price, 10));

        // ---------------- PREDICATE DELEGATE ----------------

        // Predicate<T> always returns boolean
        Predicate<int> IsValidAge = age => age >= 18;

        // Calling Predicate delegate
        Console.WriteLine("Checking age 19 is valid or not ::>> " + IsValidAge(19));
    }
}
