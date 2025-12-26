/*
NOTE:

This class demonstrates the use of **basic data types** in C#
along with **input handling** and **type conversion**.

==============================================================
CLASS: Data_Types
==============================================================
Purpose:
To show how different built-in data types are declared,
initialized, assigned through user input, and displayed.

==============================================================
DATA MEMBERS USED
==============================================================
int     NumInt     → Stores integer values  
long    NumLong    → Stores large integer values  
float   NumFloat   → Stores decimal values (single precision)  
double  NumDouble  → Stores decimal values (double precision)  
bool    BoolInp    → Stores true or false  
char    CharInp    → Stores a single character  
string  StringInp  → Stores text data  

==============================================================
CONSTRUCTOR: Data_Types()
==============================================================
Purpose:
- Initializes all data members with default values.
- Executes automatically when object is created.

Example Initial Values:
- int     → 1000
- long    → 1001
- float   → 1002
- double  → 1003.05
- bool    → false
- char    → 'S'
- string  → "Sandeep"

==============================================================
METHOD: Take_Input()
==============================================================
Purpose:
- Takes user input for all data types.
- Converts input from string to required data type.

Conversion Method Used:
- Convert.ToInt32
- Convert.ToInt64
- Convert.ToSingle
- Convert.ToDouble
- Convert.ToBoolean
- Convert.ToChar
- Convert.ToString

Note:
- Convert class is safer than Parse because it handles null values better.

==============================================================
METHOD: PrintAll()
==============================================================
Purpose:
- Displays all stored values on the console.
- Confirms correct input and data storage.

==============================================================
CONCEPTS DEMONSTRATED
==============================================================
- Primitive data types
- Constructor usage
- User input handling
- Type conversion
- Console output

==============================================================
KEY LEARNING
==============================================================
This class helps understand how different data types
work in C# and how user input is converted and stored
properly in variables.
*/


class _2_Data_Types
{
    int NumInt;
    long NumLong;
    float NumFloat;
    double NumDouble;
    bool BoolInp;
    char CharInp;
    string StringInp;

    public _2_Data_Types()
    {
        NumInt = 1000;
        NumLong = 1001L;
        NumFloat = 1002F;
        NumDouble = 1003.05D;
        BoolInp = false;
        CharInp = 'S';
        StringInp = "Sandeep";
    }

    public void Take_Input()
    {
        // Console.Write("Enter int data type ::>> ");
        // NumInt = int.Parse(Console.ReadLine()!);

        // Console.Write("Enter long data type ::>> ");
        // NumLong = long.Parse(Console.ReadLine()!);

        // Console.Write("Enter float data type ::>> ");
        // NumFloat = float.Parse(Console.ReadLine()!);

        // Console.Write("Enter double data type ::>> ");
        // NumDouble = double.Parse(Console.ReadLine()!);

        // Console.Write("Enter bool data type ::>> ");
        // BoolInp = bool.Parse(Console.ReadLine()!);

        // Console.Write("Enter char data type ::>> ");
        // CharInp = char.Parse(Console.ReadLine()!);

        // Console.Write("Enter string data type ::>> ");
        // StringInp = Console.ReadLine()!;


        Console.Write("Enter int data type ::>> ");
        NumInt = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter long data type ::>> ");
        NumLong = Convert.ToInt64(Console.ReadLine());

        Console.Write("Enter float data type ::>> ");
        NumFloat = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter double data type ::>> ");
        NumDouble = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter bool data type ::>> ");
        BoolInp = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Enter char data type ::>> ");
        CharInp = Convert.ToChar(Console.ReadLine()!);

        Console.Write("Enter string data type ::>> ");
        StringInp = Convert.ToString(Console.ReadLine()!);


    }


    public void PrintAll()
    {
        Console.WriteLine("int Data Type ::>> " + NumInt);
        Console.WriteLine("long Data Type ::>> " + NumLong);
        Console.WriteLine("float Data Type ::>> " + NumFloat);
        Console.WriteLine("double Data Type ::>> " + NumDouble);
        Console.WriteLine("bool Data Type ::>> " + BoolInp);
        Console.WriteLine("char Data Type ::>> " + CharInp);
        Console.WriteLine("string Data Type ::>> " + StringInp);
    }

}

// ------------------------------------------------------------
// RUNNER CLASS (called from Program.cs)
// ------------------------------------------------------------
class _2_Program
{
    public void Main()
    {
        Console.WriteLine("\n--- DAY 1 : DATA TYPES PROGRAM ---\n");

        _2_Data_Types obj = new _2_Data_Types();

        Console.WriteLine("Default Values:");
        obj.PrintAll();

        Console.WriteLine("\nEnter New Values:");
        obj.Take_Input();

        Console.WriteLine("\nUpdated Values:");
        obj.PrintAll();
    }
}

