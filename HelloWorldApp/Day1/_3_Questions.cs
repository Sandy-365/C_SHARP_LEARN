/*
NOTE:

This class contains **basic C# practice programs** that help understand
fundamental programming concepts such as input/output, arithmetic,
and decision-making.

==============================================================
CLASS: Questions
==============================================================
Purpose:
To implement multiple beginner-level C# programs inside
a single method for learning and practice.

==============================================================
PROGRAM LIST AND EXPLANATION
==============================================================

1. Welcome Message Program
--------------------------------------------------------------
- Prints a simple welcome message on the screen.
Concept Used:
- Console.WriteLine()

--------------------------------------------------------------

2. Read and Display an Integer
--------------------------------------------------------------
- Takes an integer input from the user.
- Displays the entered value.
Concepts Used:
- Console.ReadLine()
- Convert.ToInt32()

--------------------------------------------------------------

3. Read a Floating Point Number
--------------------------------------------------------------
- Takes a float value as input.
- Displays the value.
Concepts Used:
- float data type
- Convert.ToSingle()

--------------------------------------------------------------

4. Read and Display a String
--------------------------------------------------------------
- Takes a string (name) from user.
- Displays it on the screen.
Concepts Used:
- string data type
- Console input/output

--------------------------------------------------------------

5. Arithmetic Operations (Addition)
--------------------------------------------------------------
- Reads two integers.
- Performs addition.
Concepts Used:
- Arithmetic operator (+)
- Variable handling

--------------------------------------------------------------

6. Area of a Circle
--------------------------------------------------------------
- Takes radius as input.
- Calculates area using formula:
  Area = π × r × r
Concepts Used:
- Mathematical formula
- float calculation

--------------------------------------------------------------

7. Even or Odd Check
--------------------------------------------------------------
- Checks whether a number is even or odd.
Logic:
- Number % 2 == 0 → Even
Concepts Used:
- Modulus operator (%)
- if–else

--------------------------------------------------------------

8. Greatest of Two Numbers
--------------------------------------------------------------
- Compares two numbers.
- Prints the greater one.
Concepts Used:
- Relational operators
- if–else

--------------------------------------------------------------

9. Positive, Negative, or Zero
--------------------------------------------------------------
- Checks sign of a number.
Concepts Used:
- if–else-if ladder

--------------------------------------------------------------

10. Greatest of Three Numbers (Nested if)
--------------------------------------------------------------
- Compares three numbers using nested if statements.
Concepts Used:
- Nested decision making

--------------------------------------------------------------

11. Greatest of Three Numbers (Logical AND)
--------------------------------------------------------------
- Uses logical AND (&&) to find the greatest number.
Concepts Used:
- Logical operators
- if–else-if structure

==============================================================
CONCEPTS DEMONSTRATED
==============================================================
- Console input and output
- Data types (int, float, string)
- Arithmetic operations
- Conditional statements
- Nested if
- Logical operators

==============================================================
KEY LEARNING
==============================================================
This class provides hands-on practice for basic C# syntax
and logic building, which forms the foundation for
advanced programming concepts.
*/


class _3_Questions
{
    public void Ques()
    {
        // 1)Sample C# program to print a welcome message
        Console.WriteLine("\n\nQ1 Sample C# program to print a welcome message");
        Console.WriteLine("WELCOME TO THE DOTNET PROGRAMMING");





        // 2)Write C# program to read a number user and display it
        Console.WriteLine("\n\nQ2 Write C# program to read a number user and display it");
        int num = 0;

        Console.Write("Enter a Number ::>> ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("You have entered a number that is " + num);





        // Q3 Write C# program to read a floating point number from user
        Console.WriteLine("\n\nQ3 Write C# program to read a floating point number from user");
        float floatNum = 0.0f;

        Console.Write("Enter Floating Number ::>> ");
        floatNum = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Float number is " + floatNum);





        // Q4 Write C# program to read a string from user and display it on the screen
        Console.WriteLine("\n\nQ4 Write C# program to read a string from user and display it on the screen");
        string Name = string.Empty;

        Console.Write("Enter you Name ::>> ");
        Name = Console.ReadLine()!;

        Console.WriteLine("Name is " + Name);





        // Q5 Write C# program to perform all arthmetic operations
        Console.WriteLine("\n\nQ5 Write C# program to perform all arthmetic operations");
        int num1 = 0;
        int num2 = 0;
        int result = 0;

        Console.Write("Enter the first number for sum ::>> ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number for sum ::>> ");
        num2 = Convert.ToInt32(Console.ReadLine());

        result = num1 + num2;
        Console.WriteLine("Sum of both number is ::>> " + result);





        // Q6 Write C# program to find the area of circle
        Console.WriteLine("\n\nQ6 Write C# program to find the area of circle");
        float area = 0.0f;
        int r = 0;

        Console.Write("Enter radius of a circle ::>> ");
        r = Convert.ToInt32(Console.ReadLine());

        area = Convert.ToSingle(3.14 * r * r);
        Console.WriteLine("Area of the circle is ::>> " + area);





        // Q7 Program to find whether the given numer is EVEN or ODD
        Console.WriteLine("\n\nQ7 Program to find whether the given numer is EVEN or ODD");
        int evenOddNum = -1;

        Console.Write("Enter a number to check EVEN or ODD ::>> ");
        evenOddNum = Convert.ToInt32(Console.ReadLine());

        if (evenOddNum % 2 == 0)
        {
            Console.WriteLine("Entered number is EVEN");
        }
        else
        {
            Console.WriteLine("Entered number is ODD");
        }





        // Q8 Program to find greatest of 2 number
        Console.WriteLine("\n\nQ8 Program to find greatest of 2 number");
        float floatNum1 = 0.0f;
        float floatNum2 = 0.0f;

        Console.Write("Enter the first number ::>> ");
        floatNum1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter the second number ::>> ");
        floatNum2 = Convert.ToSingle(Console.ReadLine());

        if (floatNum1 > floatNum2)
        {
            Console.WriteLine("Number 1 is great that is " + floatNum1);
        }
        else
        {
            Console.WriteLine("Number 2 is great that is " + floatNum2);
        }





        // 9) program to find whether a given number is positive ,negative or zero
        Console.WriteLine("\n\nQ9 program to find whether a given number is positive ,negative or zero");
        int PosNegNum = 0;

        Console.Write("Enter the first number ::>> ");
        PosNegNum = Convert.ToInt32(Console.ReadLine());

        if (PosNegNum > 0)
        {
            Console.WriteLine("number is POSITIVE");
        }
        else if (PosNegNum < 0)
        {
            Console.WriteLine("number is NEGATIVE");
        }
        else
        {
            Console.WriteLine("number is ZERO");
        }





        // 10 program to find the greatest of three numbers using nested if*/
        Console.WriteLine("\n\n10 program to find the greatest of three numbers using nested if");
        int threeNum1 = 0;
        int threeNum2 = 0;
        int threeNum3 = 0;

        Console.Write("Enter the first number ::>> ");
        threeNum1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number ::>> ");
        threeNum2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the thord number ::>> ");
        threeNum3 = Convert.ToInt32(Console.ReadLine());

        if (threeNum1 > threeNum2)
        {
            if (threeNum1 > threeNum3)
            {
                Console.WriteLine("Number 1 is greater that is " + threeNum1);
            }
            else
            {
                Console.WriteLine("Number 3 is greater that is " + threeNum3);
            }
        }
        else
        {
            if (threeNum2 > threeNum3)
            {
                Console.WriteLine("Number 2 is greater that is " + threeNum2);
            }
            else
            {
                Console.WriteLine("Number 3 is greater that is " + threeNum3);
            }
        }





        // 11 program to find the greatest of three numbers using and
        Console.WriteLine("\n\n11 program to find the greatest of three numbers using and");
        int threeAndNum1 = 0;
        int threeAndNum2 = 0;
        int threeAndNum3 = 0;

        Console.Write("Enter the first number ::>> ");
        threeAndNum1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number ::>> ");
        threeAndNum2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the thord number ::>> ");
        threeAndNum3 = Convert.ToInt32(Console.ReadLine());

        if (threeAndNum1 > threeAndNum2 && threeAndNum1 > threeAndNum3)
        {
            Console.WriteLine("Number 1 is greate that is " + threeAndNum1);
        }
        else if (threeAndNum2 > threeAndNum3)
        {
            Console.WriteLine("Number 2 is greater that is " + threeAndNum2);
        }
        else
        {
            Console.WriteLine("Number 3 is greater that is " + threeAndNum3);
        }
    }

}


class _3_Questions_Program
{
    public void Main()
    {
        Console.WriteLine("\n--- DAY 1 : QUESTIONS PRACTICE (PROGRAM 3) ---\n");

        _3_Questions q = new _3_Questions();
        q.Ques();
    }
}
