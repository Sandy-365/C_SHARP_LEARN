using System;
using System.Collections.Generic;

class _52_Program
{
    public void Main()
    {
        Comparison<int> sortDescending = (a, b) => b.CompareTo(a);

        Console.WriteLine(sortDescending(5, 10));
        Console.WriteLine(sortDescending(10, 5));
        Console.WriteLine(sortDescending(5, 5));

        List<int> list = new List<int> { 5, 10, 3, 8, 1 };
        list.Sort(sortDescending);

        foreach (int n in list)
            Console.Write(n + " ");


        Comparison<string> sortDescending2 = (a, b) => b.CompareTo(a);

        Console.WriteLine(sortDescending2("5", "10"));
        Console.WriteLine(sortDescending2("10", "5"));
        Console.WriteLine(sortDescending2("5", "5"));

        List<string> list2 = new List<string> { "5", "10", "3", "8", "1" };
        list2.Sort(sortDescending2);

        foreach (string n in list2)
            Console.Write(n + " ");
    }
}
