/*
NOTE:

This class demonstrates the concept of **Local Functions**
inside a method in C#.

---------------------------------------------------------
CLASS: _20_Calculator
---------------------------------------------------------
Purpose:
Shows how functions can be defined and used
inside another method.

---------------------------------------------------------
MAIN METHOD
---------------------------------------------------------
Method:
- calculate(int a, int b)

Explanation:
- This method receives two integers.
- Inside this method, two local functions are defined.
- Local functions can access parameters and variables
  of the enclosing method directly.

---------------------------------------------------------
LOCAL FUNCTIONS
---------------------------------------------------------

1. add()
- Computes and prints the sum of a and b.
- Uses outer method parameters without passing them again.

2. sub()
- Computes and prints the difference of a and b.
- Demonstrates reuse of the same input values.

---------------------------------------------------------
IMPORTANT POINTS
---------------------------------------------------------
1. Local functions are accessible only inside the method
   where they are declared.
2. They improve code readability by grouping logic together.
3. They help avoid duplication and keep helper logic private.
4. They can access local variables and parameters directly.

---------------------------------------------------------
KEY LEARNING
---------------------------------------------------------
Local functions are useful for organizing small helper logic
that is only relevant to a single method.
*/


class _20_Calculator
{
    public void calculate(int a,int b)
    {
        void add()
        {
            Console.WriteLine($"Sum of two number is ::>> {a+b}");
        }

        void sub()
        {
            Console.WriteLine($"diff of two number is ::>> {a-b}");
        }

        add();
        sub();
    }
}