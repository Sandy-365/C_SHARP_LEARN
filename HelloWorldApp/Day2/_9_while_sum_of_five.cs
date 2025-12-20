/*
NOTE:

This class demonstrates the use of the **while loop**
to calculate the sum of numbers.

---------------------------------------------------------
CLASS: SumOfNumberWhile
---------------------------------------------------------
Purpose:
Calculates the sum of numbers from 0 to 5
using a while loop.

---------------------------------------------------------
LOGIC EXPLANATION
---------------------------------------------------------
1. count is initialized to 0.
2. sum is initialized to 0.
3. while loop runs as long as count <= 5.
4. In each iteration:
   - Current value of count is added to sum.
   - count is incremented by 1.
5. Loop stops when count becomes 6.
6. Final sum is printed to the console.

---------------------------------------------------------
LOOP TRACE
---------------------------------------------------------
count : 0 1 2 3 4 5
sum   : 0 1 3 6 10 15

---------------------------------------------------------
KEY CONCEPTS USED
---------------------------------------------------------
- while loop
- Loop condition checking
- Increment operation
- Accumulator variable

---------------------------------------------------------
KEY LEARNING
---------------------------------------------------------
while loop is useful when the number of iterations
is known based on a condition.
*/


class SumOfNumberWhile
{
    public void sum()
    {
        int count = 0;
        int sum = 0;
        while(count <= 5)
        {
            sum += count;
            count++;
        }
        Console.WriteLine("Sum of numb 0 to num 5 is "+sum);

    }
}