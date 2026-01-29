/*
NOTE:

This class implements a **simple _5_Calculator application**
using Object-Oriented Programming concepts in C#.

==============================================================
CLASS: _5_Calculator
==============================================================
Purpose:
Performs basic arithmetic operations on two integers
entered by the user.

==============================================================
DATA MEMBERS
==============================================================
num1    → Stores first number  
num2    → Stores second number  
result  → Stores result of calculation  

These are instance variables used across methods.

==============================================================
CONSTRUCTOR: _5_Calculator()
==============================================================
Purpose:
- Displays a welcome message when the calculator object
  is created.
- Shows that constructors are executed automatically
  during object creation.

Concepts Used:
- Constructor
- Automatic method execution

==============================================================
PRIVATE METHOD: takeInput()
==============================================================
Purpose:
- Accepts two integer values from the user.
- Reused by all arithmetic operation methods.

Access Modifier:
- private → Accessible only within the _5_Calculator class.

Concepts Used:
- Code reuse
- Encapsulation
- Console input handling

==============================================================
ARITHMETIC OPERATIONS
==============================================================

1. Add()
--------------------------------------------------------------
- Takes input
- Performs addition (num1 + num2)
- Displays the result

2. Subtract()
--------------------------------------------------------------
- Performs subtraction (num1 − num2)

3. Multiply()
--------------------------------------------------------------
- Performs multiplication (num1 × num2)

4. Divide()
--------------------------------------------------------------
- Performs division (num1 ÷ num2)
- Uses integer division

5. Remainder()
--------------------------------------------------------------
- Calculates remainder using modulus operator (%)

Each method:
- Calls takeInput()
- Computes result
- Prints formatted output

==============================================================
CONCEPTS DEMONSTRATED
==============================================================
- Class and object
- Constructor usage
- Access modifiers (private, public)
- Method reuse
- Arithmetic operators
- Console input/output

==============================================================
KEY LEARNING
==============================================================
This class shows how to build a reusable and structured
calculator by combining constructors, private helper
methods, and public operation methods.
*/


class _5_Calculator
{
    int num1;
    int num2;
    int result;

    public _5_Calculator()
    {
        Console.WriteLine("\n\n\t\t-----------------------------------WELCOME TO CALCULATOR APP----------------------");
    }

    private void takeInput()
    {
        Console.Write("Enter first num ::>> ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second num ::>> ");
        num2 = Convert.ToInt32(Console.ReadLine());
    }
    public void Add()
    {
        Console.WriteLine("\n+++++++++++++++-----SUM------+++++++++++++++++++++");
        takeInput();
        result = num1 + num2;
        Console.WriteLine($"Sum of numbers is {result}");
        Console.WriteLine("+++++++++++++++++-----DONE------+++++++++++++++++++\n\n");

    }

    public void Subtract()
    {
        Console.WriteLine("\n++++++++++++++-----SUBTRACT-------++++++++++++++++");
        takeInput();
        result = num1 - num2;
        Console.WriteLine($"Subtraction of numbers is {result}");
        Console.WriteLine("+++++++++++++++++-----DONE------+++++++++++++++++++\n\n");

    }

    public void Multiply()
    {
        Console.WriteLine("\n++++++++++++++-----MULTIPLY-------++++++++++++++++");
        takeInput();
        result = num1 * num2;
        Console.WriteLine($"Multiply of numbers is {result}");
        Console.WriteLine("+++++++++++++++++-----DONE------+++++++++++++++++++\n\n");

    }

    public void Divide()
    {
        Console.WriteLine("\n++++++++++++++-----DIVISION-------++++++++++++++++");
        takeInput();
        result = num1 / num2;
        Console.WriteLine($"Division of numbers is {result}");
        Console.WriteLine("+++++++++++++++++-----DONE------+++++++++++++++++++\n\n");

    }

    public void Remainder()
    {
        Console.WriteLine("\n++++++++++++++-----REMAINDER-------++++++++++++++++");
        takeInput();
        result = num1 % num2;
        Console.WriteLine($"Remainder of numbers is {result}");
        Console.WriteLine("+++++++++++++++++-----DONE------+++++++++++++++++++\n\n");

    }
}