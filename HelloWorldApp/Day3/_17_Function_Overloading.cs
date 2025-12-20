/*
NOTE:

This program demonstrates the concept of **Function (Method) Overloading**
in C# with multiple valid scenarios.

---------------------------------------------------------
CLASS: _17_FunctionOverloading
---------------------------------------------------------
Purpose:
Shows how multiple methods with the same name can exist
in a class as long as their **parameter lists are different**.

---------------------------------------------------------
IMPORTANT RULES OF METHOD OVERLOADING
---------------------------------------------------------
1. Method name must be the same.
2. Parameter list must be different in at least one way:
   - Data type
   - Number of parameters
   - Order of parameters
3. Return type alone CANNOT differentiate methods.
4. Method signature = Method Name + Parameter List.

---------------------------------------------------------
VALID OVERLOADING TYPES USED
---------------------------------------------------------

1. Overloading by Data Type
   - Add(int, int)
   - Add(double, int)
   - Add(int, double)

2. Overloading by Number of Parameters
   - Add(int, int, int)

3. Overloading by Order of Parameters
   - Add(int, double)
   - Add(double, int)

4. Overloading with Mixed Data Types
   - Add(double, int, double)

5. Overloading with String
   - Add(string, string)
   Used for string concatenation.

6. Overloading using params Keyword
   - Add(params int[])
   Accepts variable number of integer arguments.

7. Overloading with Optional Parameter
   - Add(int, int, int, int = 0)
   Allows calling method with 3 or 4 arguments.

---------------------------------------------------------
INVALID OVERLOADING (COMMENTED)
---------------------------------------------------------
- Same parameter list with different return type is NOT allowed.
- Causes compile-time error CS0111.

---------------------------------------------------------
KEY LEARNING
---------------------------------------------------------
Function overloading improves code readability and flexibility
by allowing the same method name to handle different inputs.
*/


using System;

class _17_FunctionOverloading
{
    // public static int Add(int a,int b)
    // {
    //     return a+b;
    // }

    // ONLY DIFFERENT PARAMETER LIST IS ALLOWED FOR OVERLOADING
    // DIFFERENT RETURN TYPE ALONE IS NOT ALLOWED

    public int Add(int a,int b)
    {
        Console.WriteLine("\nsimple int");
        return a + b;
    }

    // This is NOT allowed
    // error ::-- Type '_17_FunctionOverloading' already defines a member called 'Add' with the same parameter types CS0111
    // public void Add(int a,int b)
    // {
    //     Console.WriteLine("\nsimple int and sum is "+(a+b));
    // }

    // OVERLOADING BY DATA TYPE
    public double Add(double a,int b)
    {
        Console.WriteLine("\nsimple double");
        return a + b;
    }

    // OVERLOADING BY NUMBER OF PARAMETERS
    public int Add(int a,int b,int c)
    {
        Console.WriteLine("\nthree int");
        return a + b + c;
    }

    // OVERLOADING BY ORDER OF PARAMETERS
    public int Add(int a,double b)
    {
        Console.WriteLine("\nint then double");
        return a + (int)b;
    }

    public int Add(double a,int b,double c)
    {
        Console.WriteLine("\ndouble int double");
        return (int)a + b + (int)c;
    }

    // OVERLOADING WITH STRING
    public string Add(string a,string b)
    {
        Console.WriteLine("\nstring concat");
        return a + b;
    }

    // OVERLOADING USING params KEYWORD
    public int Add(params int[] a)
    {
        int sum = 0;
        for(int i = 0; i < a.Length; i++)
            sum += a[i];

        Console.WriteLine("\nparams array");
        return sum;
    }

    // OVERLOADING WITH OPTIONAL PARAMETER
    public int Add(int a,int b,int c,int d = 0)
    {
        Console.WriteLine("\noptional parameter");
        return a + b + c + d;
    }
}