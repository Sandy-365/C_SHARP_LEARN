/*
NOTE:

This class explains **Lambda Expressions** and **Static Members**
in C# with clear examples.

---------------------------------------------------------
CLASS: _21_Lamda_Static
---------------------------------------------------------
Purpose:
Demonstrates:
1. Difference between normal methods and lambda expressions
2. Use of static variables and static local functions
3. Access rules for static and non-static members

---------------------------------------------------------
1. LAMBDA EXPRESSION
---------------------------------------------------------
Method:
- ExampleLamda()

Explanation:
- Square(int x) is a normal local function.
- squareLambda is a lambda expression using Func delegate.
- Lambda expressions provide a short and concise way
  to write functions.

Key Point:
- Lambda syntax: x => x * x
- Useful for simple operations and functional programming.

---------------------------------------------------------
2. STATIC VARIABLE
---------------------------------------------------------
Variable:
- static int number = 5;

Explanation:
- Static variables belong to the class, not to an object.
- Shared across all instances of the class.

---------------------------------------------------------
3. STATIC LOCAL FUNCTION IN NON-STATIC METHOD
---------------------------------------------------------
Method:
- ExampleStatic()

Explanation:
- Static local function can be declared inside a method.
- It can access only static variables of the class.
- Non-static method can access both static and non-static members.

---------------------------------------------------------
4. STATIC METHOD WITH STATIC LOCAL FUNCTION
---------------------------------------------------------
Method:
- ExampleStatic2()

Explanation:
- Static method cannot access non-static members.
- It can access only static variables and methods.
- Static local function follows the same rule.

---------------------------------------------------------
ACCESS RULE SUMMARY
---------------------------------------------------------
Non-static method:
- Can access static and non-static members

Static method:
- Can access only static members

---------------------------------------------------------
KEY LEARNING
---------------------------------------------------------
Lambda expressions simplify code,
static members are shared at class level,
and access rules are strictly enforced in C#.
*/


class _21_Lamda_Static
{
    public void ExampleLamda()
    {
        int Square(int x)
        {
            return x * x;
        }
        Func<int, int> squareLambda = x => x * x;
        Console.WriteLine("Square os 4 using simple function ::>> "+Square(4));
        Console.WriteLine("Square of 4 using lamda ::>> "+squareLambda(4));
    }

    static int number = 5;
    public void ExampleStatic()
    {
        static int Square(int x)
        {
            return x * x;
        }
        Console.WriteLine(Square(number)+"  non-static function can acces static and non-static variables");
    }

    public static void ExampleStatic2()
    {
        static int Square(int x)
        {
            return x * x;
        }
        Console.WriteLine(Square(number)+" static fucntion can not acces non static variable but can access on ly static variables");
    }
}