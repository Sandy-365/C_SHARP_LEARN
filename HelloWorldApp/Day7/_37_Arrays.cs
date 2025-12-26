/*
NOTE:

This program demonstrates **ARRAYS in C#** step by step.

============================================================
TOPICS COVERED
============================================================
1. One-Dimensional Arrays
2. for loop vs foreach loop
3. Total & Average calculation
4. Multi-Dimensional Arrays (2D arrays)
5. Jagged Arrays
6. Array utility methods
7. Resizing arrays
8. Searching in arrays

============================================================
KEY LEARNING
============================================================
- Arrays have fixed size
- 2D arrays use GetLength(dimension)
- Jagged arrays use Length per row
- Array methods are STATIC (Array.Sort, Array.Copy, etc.)
============================================================
*/

class _37_Program
{
    public void Main()
    {
        // --------------------------------------------------
        //  ONE-DIMENSIONAL ARRAY DECLARATIONS
        // --------------------------------------------------

        int[] numbers1;                     // declaration only
        int[] numbers2 = new int[9];         // size defined, default values = 0
        int[] numbers3 = { 10, 20, 30, 40, 50 };

        int[] marks = { 85, 90, 78 };

        // Using for loop
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine($"Marks of student {i + 1} is {marks[i]}");
        }

        Console.WriteLine("\nNow using foreach");

        // Using foreach loop
        foreach (int m in marks)
        {
            Console.WriteLine($"Marks of student is {m}");
        }

        // --------------------------------------------------
        //  TOTAL & AVERAGE OF MARKS
        // --------------------------------------------------

        int total = 0;

        foreach (int m in marks)
        {
            total += m;
        }

        double average = total / (double)marks.Length;

        Console.WriteLine("\nTotal Marks ::>> " + total);
        Console.WriteLine("Average Marks ::>> " + average);

        // --------------------------------------------------
        //  MULTI-DIMENSIONAL ARRAYS (2D)
        // --------------------------------------------------

        int[,] matrix =
        {
            {1, 2, 3},
            {4, 5, 6}
        };

        // Accessing specific element
        Console.WriteLine($"\nNumber 4 is at [1,0] ::>> {matrix[1, 0]}");

        // Printing full 2D array
        for (int i = 0; i < matrix.GetLength(0); i++)     // rows
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // columns
            {
                Console.Write(matrix[i, j] + "  ");
            }
            Console.WriteLine();
        }

        // --------------------------------------------------
        //  JAGGED ARRAYS
        // --------------------------------------------------

        Console.WriteLine("\nJagged Arrays");

        int[][] jagged = new int[2][];
        jagged[0] = new int[] { 1, 2, 3 };
        jagged[1] = new int[] { 5, 6, 7 };

        // Correct way to print jagged array
        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                Console.Write(jagged[i][j] + "  ");
            }
            Console.WriteLine();
        }

        // --------------------------------------------------
        //  ARRAY METHODS
        // --------------------------------------------------

        int[] arr = { 24, 56, 32, 89, 2, 6, 4, 1 };
        Console.WriteLine("\nOriginal Array");
        Console.WriteLine(string.Join(" ", arr));

        // Sorting
        Array.Sort(arr);
        Console.WriteLine("Sorted Array");
        Console.WriteLine(string.Join(" ", arr));

        // Clearing specific elements
        Array.Clear(arr, 1, 2);
        Console.WriteLine("After Clear(1,2)");
        Console.WriteLine(string.Join(" ", arr));

        // Clearing almost entire array
        Array.Clear(arr, 1, arr.Length - 1);
        Console.WriteLine("After Clear from index 1");
        Console.WriteLine(string.Join(" ", arr));

        // --------------------------------------------------
        //  ARRAY COPY
        // --------------------------------------------------

        arr = new int[] { 1, 2, 53, 86, 43, 86, 34, 77, 32 };
        int[] arr2 = new int[arr.Length];

        Array.Copy(arr, arr2, 2);
        Console.WriteLine("\nCopy first 2 elements");
        Console.WriteLine(string.Join(" ", arr2));

        Array.Copy(arr, arr2, 5);
        Console.WriteLine("Copy first 5 elements");
        Console.WriteLine(string.Join(" ", arr2));

        Array.Copy(arr, arr2, arr.Length);
        Console.WriteLine("Copy full array");
        Console.WriteLine(string.Join(" ", arr2));

        // --------------------------------------------------
        //  ARRAY RESIZE
        // --------------------------------------------------

        int[] nums1 = { 21, 532, 543 };
        Console.WriteLine("\nBefore Resize");
        Console.WriteLine(string.Join(" ", nums1));

        Array.Resize(ref nums1, 4);   // new element = 0
        Console.WriteLine("After Resize to 4");
        Console.WriteLine(string.Join(" ", nums1));

        int[] nums2 = { 1, 2, 3 };
        Array.Resize(ref nums2, 1);
        Console.WriteLine("After Resize to 1");
        Console.WriteLine(string.Join(" ", nums2));

        // --------------------------------------------------
        //  SEARCHING IN ARRAYS
        // --------------------------------------------------

        int[] arrI = { 10, 20, 20 };

        Console.WriteLine("\nIndex of 20 ::>> " + Array.IndexOf(arrI, 20));

        bool found = Array.Exists(arrI, x => x > 25);
        Console.WriteLine("Any element > 25 ::>> " + found);

        // --------------------------------------------------
        //  EXTRA: MIN, MAX, REVERSE
        // --------------------------------------------------

        Console.WriteLine("\nMin ::>> " + arrI.Min());
        Console.WriteLine("Max ::>> " + arrI.Max());

        Array.Reverse(arrI);
        Console.WriteLine("Reversed Array");
        Console.WriteLine(string.Join(" ", arrI));
    }
}
