/*
NOTE:

This class demonstrates the use of **nested for loops**
to generate multiplication tables.

---------------------------------------------------------
CLASS: TableUsingForLoop
---------------------------------------------------------
Purpose:
Prints multiplication tables from 20 to 30
using for loops.

---------------------------------------------------------
LOGIC EXPLANATION
---------------------------------------------------------
1. start is set to 20 and end is set to 30.
2. Outer for loop runs from start to end.
   - Each iteration represents one table number.
3. Before printing a table, a heading is displayed.
4. Inner for loop runs from 1 to 10.
   - Multiplies the outer loop value with inner loop value.
5. After completing one table, blank lines are printed
   for better readability.

---------------------------------------------------------
LOOP STRUCTURE
---------------------------------------------------------
Outer Loop:
- Controls which table is printed (20 to 30)

Inner Loop:
- Controls multiplication from 1 to 10

---------------------------------------------------------
KEY CONCEPTS USED
---------------------------------------------------------
- for loop
- Nested loops
- Loop counters
- Console output formatting

---------------------------------------------------------
KEY LEARNING
---------------------------------------------------------
Nested loops are useful when a task needs to be repeated
within another repeated task, such as table generation.
*/


class TableUsingForLoop
{
    public void table()
    {
        int start =20;
        int end = 30;
        for(int i = start; i <= end; i++)
        {
            Console.WriteLine($"--------- Table of {i} -----------");
            for(int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} X {j} = {i*j}");
            }
            Console.WriteLine("\n\n\n");
        }
    }
}