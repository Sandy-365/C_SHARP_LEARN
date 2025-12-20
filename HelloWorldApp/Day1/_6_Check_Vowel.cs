/*
NOTE:

This program checks whether a given character is a **vowel or not**
using a **switch statement** in C#.

==============================================================
CLASS: Vowel
==============================================================
Purpose:
To read a single character from the user and determine
whether it is a vowel or not a vowel.

==============================================================
INPUT DETAILS
==============================================================
- User enters one character.
- Character can be lowercase or uppercase.

Examples of vowels checked:
a, e, i, o, u
A, E, I, O, U

==============================================================
METHOD: Check()
==============================================================
Purpose:
- Reads a character from the user.
- Uses switch-case to compare the character.
- Prints appropriate message based on result.

==============================================================
LOGIC USED
==============================================================
- switch statement is used to handle multiple cases.
- Each vowel (both lowercase and uppercase) has its own case.
- If character matches any vowel → vowel message is printed.
- If character does not match → default case executes.

==============================================================
EXPECTED OUTPUT FORMAT
==============================================================
If vowel:
"The character 'a' is a vowel."

If not vowel:
"The character 'G' is not a vowel."

(Current output logic prints:
"a is a Vowel"
"G is Not Vowel")

==============================================================
CONCEPTS DEMONSTRATED
==============================================================
- switch-case statement
- Character input handling
- Conditional branching
- Console input and output

==============================================================
KEY LEARNING
==============================================================
Using switch-case is an effective way to handle
multiple fixed comparisons such as vowel checking.
*/


class Vowel
{
    public void Check()
    {
        char c;
        Console.WriteLine("\n\n--------------------PROGRAM TO CHECK GIVEN CHARACTER IS VOWEL OR NOT-----------------------------");
        Console.Write("Enter a Character ::>> ");
        c = Convert.ToChar(Console.ReadLine()!);

        switch (c)
        {
            case 'a':
                Console.WriteLine(c + " is a Vowel");
                break;
            case 'e':
                Console.WriteLine(c + " is a Vowel");
                break;
            case 'i':
                Console.WriteLine(c + " is a Vowel");
                break;
            case 'o':
                Console.WriteLine(c + " is a Vowel");
                break;
            case 'u':
                Console.WriteLine(c + " is a Vowel");
                break;
            case 'A':
                Console.WriteLine(c + " is a Vowel");
                break;
            case 'E':
                Console.WriteLine(c + " is a Vowel");
                break;
            case 'I':
                Console.WriteLine(c + " is a Vowel");
                break;
            case 'O':
                Console.WriteLine(c + " is a Vowel");
                break;
            case 'U':
                Console.WriteLine(c + " is a Vowel");
                break;
            default:
                Console.WriteLine(c + " is Not Vowel");
                break;
        }
    }
}