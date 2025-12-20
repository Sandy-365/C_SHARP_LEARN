/*
NOTE:

This program demonstrates two simple classes to explain
basic Object-Oriented Programming (OOP) concepts in C#.

---------------------------------------------------------
CLASS 1: _15_BankAccount
---------------------------------------------------------
Purpose:
Represents a bank account with basic data and behavior.

Data Members:
- AccNum   : Stores the account number of the user.
- Balance  : Stores the current balance in the account.

Method:
- Deposit(double amount)
  Adds the given amount to the existing balance.
  This method performs a credit operation.

Concepts Used:
- Class and Object
- Public data members
- Method to modify object state

---------------------------------------------------------
CLASS 2: _15_Employee
---------------------------------------------------------
Purpose:
Represents an employee with basic details.

Data Members:
- Name   : Stores the employee name (nullable string).
- Salary : Stores the employee salary.

Method:
- DisplayDetails()
  Prints employee name and salary to the console.

Concepts Used:
- Class and Object
- Nullable reference type
- Method for displaying object data

---------------------------------------------------------
Overall Concepts Demonstrated:
- Multiple class definitions in a single program
- Encapsulation of data and behavior
- Simple real-world entity modeling using classes
*/

class _15_BankAccount
{
    public int AccNum;
    public double Balance;

    public void Deposit(double amount)
    {
        Balance += amount;
    }

}

class _15_Employee
{
    public string? Name;
    public double Salary;

    public void DisplayDetails()
    {
        Console.WriteLine($"{Name} earns {Salary}");
    }
}