/*
NOTE:

This class demonstrates the use of the **do-while loop**
in C#.

---------------------------------------------------------
CLASS: DoWhileExample
---------------------------------------------------------
Purpose:
Shows how a do-while loop works and how it differs
from a while loop.

---------------------------------------------------------
LOGIC EXPLANATION
---------------------------------------------------------
1. count is initialized to 0.
2. The do block executes FIRST without checking condition.
3. Inside the loop:
   - Current value of count is printed.
   - count is incremented.
4. Condition is checked after execution.
5. Loop continues while count <= 5.
6. When condition becomes false, loop stops.
7. "Done" is printed after loop completion.

---------------------------------------------------------
OUTPUT FLOW
---------------------------------------------------------
Count is 0
Count is 1
Count is 2
Count is 3
Count is 4
Count is 5
Done

---------------------------------------------------------
KEY CONCEPTS USED
---------------------------------------------------------
- do-while loop
- Post-condition checking
- Loop execution guarantee

---------------------------------------------------------
KEY LEARNING
---------------------------------------------------------
A do-while loop always executes at least once,
even if the condition is false initially.
*/


class DoWhileExample
{
    public void Example1()
    {
        int count = 0;
        do
        {
            Console.WriteLine("Count is "+count);
            count++;
        }while(count <= 5);
        Console.WriteLine("Done");
    }
}
