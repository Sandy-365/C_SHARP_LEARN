/*
NOTE:

This program demonstrates how to **swap two integer values**
without using a temporary variable in C#.

==============================================================
CLASS: SwapTwoNumber
==============================================================
Purpose:
To read two integers from the user, display their values
before swapping, swap them using arithmetic operations,
and then display the swapped values.

==============================================================
INPUT DETAILS
==============================================================
- User enters two integer values.
- First value is stored in num1.
- Second value is stored in num2.

==============================================================
METHOD: swap()
==============================================================
Purpose:
- Takes two integers as input.
- Prints values before swapping.
- Swaps values without using any extra variable.
- Prints values after swapping.

==============================================================
LOGIC USED (WITHOUT TEMP VARIABLE)
==============================================================
Step 1:
num1 = num1 + num2

Step 2:
num2 = num1 - num2

Step 3:
num1 = num1 - num2

After these operations:
- num1 contains original value of num2
- num2 contains original value of num1

==============================================================
EXPECTED OUTPUT FORMAT
==============================================================
Before swap: a = 1, b = 2
After swap:  a = 2, b = 1

==============================================================
CONCEPTS DEMONSTRATED
==============================================================
- Arithmetic operations
- Variable manipulation
- Console input and output
- Swapping logic without temporary variable

==============================================================
KEY LEARNING
==============================================================
Swapping values without a temporary variable can be
achieved using arithmetic operations, improving
understanding of variable manipulation.
*/


class SwapTwoNumber
{
    public void swap()
    {
        int num1;
        int num2;

        Console.Write("Enter first num ::>> ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second num ::>> ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Before Swap a is {num1} and b is {num2}");

        num1 = num1 + num2;  // 7
        num2 = num1 - num2;  // 7 - 4 = 3
        num1 = num1 - num2;  // 7 - 3 = 4
        Console.WriteLine($"After Swap a is {num1} and b is {num2}");
    }
}