/*
NOTE:

This class demonstrates the use of **constructors** and **encapsulation**
in Object-Oriented Programming (OOP) using C#.

---------------------------------------------------------
CLASS: _16_Wallet
---------------------------------------------------------
Purpose:
Represents a wallet that stores money securely and allows
controlled access to modify and read the balance.

Data Member:
- Money (private)
  Stores the amount of money in the wallet.
  It is kept private to prevent direct access from outside the class.

Constructor:
- _16_Wallet(double amount)
  Initializes the wallet with a starting amount.
  This constructor is called automatically when an object is created.

Methods:
- AddMoney(double amount)
  Adds the specified amount to the wallet balance.
  Also displays a confirmation message.

- GetMoney()
  Returns the current amount of money in the wallet.

---------------------------------------------------------
Concepts Used:
- Constructor
- Encapsulation (private data member)
- Controlled access using public methods
- Data hiding for security

---------------------------------------------------------
Key Learning:
Private variables should be accessed and modified only
through public methods to maintain data safety.
*/

class _16_Wallet
{
    private double Money;
    public _16_Wallet(double amount)
    {
        Money = amount;
    }

    public void AddMoney(double amount)
    {
        Money += amount;
        Console.WriteLine($"{amount} is added to your wallet");
    }

    public double GetMoney()
    {
        return Money;
    }
}