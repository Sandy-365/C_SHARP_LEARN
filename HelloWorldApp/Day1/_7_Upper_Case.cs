/*
NOTE:

This program demonstrates **string manipulation** in C#
by converting a string to uppercase and finding its length.

==============================================================
CLASS: ConvUpPrint
==============================================================
Purpose:
To read a string from the user, calculate the length of the
original string, convert it to uppercase, and display both
results.

==============================================================
INPUT DETAILS
==============================================================
- User enters a single line string.
- The string can contain alphabets or characters.

Example Input:
Demo

==============================================================
METHOD: ConvertUpperPrint()
==============================================================
Purpose:
- Accepts a string input from the user.
- Calculates the length of the original string.
- Converts the string to uppercase.
- Prints the length and converted string.

==============================================================
LOGIC USED
==============================================================
1. Read string using Console.ReadLine().
2. Find length using:
   str.Length
3. Convert string to uppercase using:
   str.ToUpper()
4. Display results using Console.WriteLine().

==============================================================
EXPECTED OUTPUT FORMAT
==============================================================
Original string length: 4
Uppercase string: DEMO

(Current implementation prints both values in one line.)

==============================================================
CONCEPTS DEMONSTRATED
==============================================================
- String input handling
- String properties (Length)
- String methods (ToUpper)
- Console output formatting

==============================================================
KEY LEARNING
==============================================================
This program shows how built-in string methods in C#
can be used to manipulate and analyze text data easily.
*/


class ConvUpPrint
{
    public void ConvertUpperPrint()
    {
        string str = string.Empty;
        int length = 0;
        Console.Write("Enter a String ::>> ");
        str = Console.ReadLine()!;

        length = str.Length;
        str = str.ToUpper();

        Console.WriteLine($"The length of the String is {length} and Converted to upper case is {str}");

    }
}