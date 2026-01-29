using System;
using System.Collections.Generic;

class _T_1_Student : IComparable<_T_1_Student>
{
    public string Name;
    public int Age;
    public float Marks; 

    public _T_1_Student(string name, int age, float marks)
    {
        Name = name;
        Age = age;
        Marks = marks;
    }

    public int CompareTo(_T_1_Student other)
    {
        return this.Marks.CompareTo(other.Marks);
    }
}

class _T_1_CustomSorting
{
    public void Main()
    {
        List<_T_1_Student> lis = new List<_T_1_Student>();

        lis.Add(new _T_1_Student("Sandeep", 21, 34.5f));
        lis.Add(new _T_1_Student("Manish", 25, 34.5f));
        lis.Add(new _T_1_Student("Happy", 20, 78.09f));
        lis.Add(new _T_1_Student("Ramjee", 9, 58.5f));

        Console.WriteLine("Before Sorting");
        foreach (var i in lis)
        {
            Console.WriteLine($"Name ::>> {i.Name,-10}  Age ::>> {i.Age,-3}  Marks ::>> {i.Marks,6}");
        }

        lis.Sort();

        Console.WriteLine("\nAfter Sorting");
        foreach (var i in lis)
        {
            Console.WriteLine($"Name ::>> {i.Name,-10}  Age ::>> {i.Age,-3}  Marks ::>> {i.Marks,6}");
        }
    }
}
