/*
NOTE:

This class demonstrates the use of **break** and **continue**
statements in loop control.

---------------------------------------------------------
CLASS: BreakContinueExample
---------------------------------------------------------
Purpose:
Explains how break and continue affect loop execution flow.

---------------------------------------------------------
1. break STATEMENT
---------------------------------------------------------
Method:
- BreakExample()

Explanation:
- Loop runs from 0 to 10.
- When i becomes 5, break statement executes.
- Loop terminates immediately.
- Control moves outside the loop.

Output Flow:
0 1 2 3 4
Loop stops at 5

---------------------------------------------------------
2. continue STATEMENT
---------------------------------------------------------
Method:
- ContinueExample()

Explanation:
- Loop runs from 1 to 10.
- When i becomes 4:
  - continue statement skips remaining code in loop body.
  - Next iteration starts immediately.
- Statements written after continue are never executed.

Game Logic Explanation:
- Enemy 4 is invincible, so it is skipped.
- All other enemies are processed normally.

---------------------------------------------------------
IMPORTANT NOTE
---------------------------------------------------------
Any statement written after continue in the same block
will never execute.

---------------------------------------------------------
KEY CONCEPTS USED
---------------------------------------------------------
- for loop
- break statement
- continue statement
- Loop flow control

---------------------------------------------------------
KEY LEARNING
---------------------------------------------------------
Use break to exit a loop completely.
Use continue to skip the current iteration only.
*/


class BreakContinueExample
{
    public void BreakExample()
    {
        for(int i = 0; i <= 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine($"Breaking out of loop after {i}");
                break;
            }
            Console.WriteLine($"Count is {i}");
        }
    }

    public void ContinueExample()
    {
        Console.WriteLine("\n\n----------GAME BEGINS-------------");
        for(int i = 1; i <= 10; i++){
            if (i == 4)
            {
                Console.WriteLine($"E{i} is invinsible skipping e{4}");
                continue;
                Console.WriteLine("now this will not run");
                Console.WriteLine("Hello i am below E4");
            }

            Console.WriteLine($"Player killed e{i}");
        }
    }
}