using System;

class Question_Number_14
{
    public static void main()
    {
        int n = 3;
        int upto = 5;

        int[] row = new int[upto];

        for (int i = 1; i <= upto; i++)
        {
            row[i - 1] = n * i;
        }

        foreach (int value in row)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}
