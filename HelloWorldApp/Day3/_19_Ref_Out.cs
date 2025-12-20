/*
NOTE:

This class explains **parameter passing mechanisms** in C#:
ref, out, and in keywords.

---------------------------------------------------------
CLASS: _19_Refrencse
---------------------------------------------------------
Purpose:
Demonstrates how values are passed to methods by reference
instead of by value, allowing direct interaction with variables.

---------------------------------------------------------
1. ref PARAMETER
---------------------------------------------------------
Example:
- IncByTen(ref int a)

Explanation:
- Variable MUST be initialized before passing.
- Changes made inside the method affect the original variable.
- Used when you want both input and output behavior.

Flow:
x = 10
IncByTen(ref x)
x becomes 20

---------------------------------------------------------
2. out PARAMETER
---------------------------------------------------------
Example:
- Divide(int a, int b, out int quotient, out int remainder)
- GetResult(int marks, out string grade)

Explanation:
- Variable does NOT need to be initialized before passing.
- Method MUST assign a value before returning.
- Mainly used to return multiple values from a method.

Examples:
- Returning quotient and remainder together.
- Returning pass/fail result based on marks.

---------------------------------------------------------
3. in PARAMETER
---------------------------------------------------------
Example:
- Print(in int x)

Explanation:
- Variable must be initialized before passing.
- Passed by reference but treated as read-only.
- Method cannot modify the value.

---------------------------------------------------------
COMPARISON SUMMARY
---------------------------------------------------------
ref :
- Must initialize before call
- Can read and modify

out :
- No initialization required
- Must assign inside method
- Used for output

in :
- Must initialize
- Read-only reference

---------------------------------------------------------
KEY LEARNING
---------------------------------------------------------
Use ref when modifying existing data,
use out when returning multiple values,
use in when passing large data safely without modification.
*/


class _19_Refrencse
{
    public void runProgram()
    {
        Console.WriteLine("\nExample of 'ref' ");
        int x = 10;
        Console.WriteLine($"Value of x before ref parameter is called ::>> {x}");
        IncByTen(ref x);
        Console.WriteLine($"Value of x after ref parameter is called ::>> {x}");


        Console.WriteLine("\n\nExample of 'out' ");
        int q, r;   // no initialization required
        Divide(10, 3, out q, out r);
        Console.WriteLine("Quotient = " + q);
        Console.WriteLine("Remainder = " + r);


        Console.WriteLine("\n\nAnother example of 'out' ");
        string result;
        GetResult(75, out result);
        Console.WriteLine(result);


        int num = 50;
        Print(in num);


    }

    void IncByTen(ref int a)
    {
        a += 10;
    }

    public static void Divide(int a, int b, out int quotient, out int remainder)
    {
        quotient = a / b;
        remainder = a % b;
    }


    public static void GetResult(int marks, out string grade)
    {
        if (marks >= 60)
            grade = "Pass";
        else
            grade = "Fail";
    }

    void Print(in int x)
    {
        Console.WriteLine(x);
    }


}