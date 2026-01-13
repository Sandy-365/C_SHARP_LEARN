using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name;
    public int Marks;
}


class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
}



class _linq_Main
{
    public void Main()
    {
        // List<Student> students = new List<Student>
        // {
        //     new Student { Name = "A", Marks = 75 },
        //     new Student { Name = "B", Marks = 55 },
        //     new Student { Name = "C", Marks = 65 }
        // };

        // var result = students.Select(s => new
        // {
        //     s.Name,
        //     Grade = s.Marks > 60 ? "Pass" : "Fail"
        // });

        // Console.WriteLine(result.GetType());
        // foreach (var r in result)
        // {
        //     Console.WriteLine(r.Name + " " + r.Grade);
        // }

        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Amit", Salary = 50000 },
            new Employee { Name = "Neha", Salary = 70000 },
            new Employee { Name = "Meha", Salary = 70000 },
            new Employee { Name = "Neza", Salary = 70000 },
            new Employee { Name = "Ravi", Salary = 60000 }
        };

        var sortedBySalary = employees.OrderBy(e => e.Salary).ThenBy(e => e.Name);
        // var sortedByName = employees.OrderBy(e => e.Name);

        foreach (var e in sortedBySalary)
            Console.WriteLine(e.Name + " " + e.Salary);

        Console.WriteLine(sortedBySalary.GetType());

        List<int> numbers = new List<int> { 10, 20, 30 };
        int first = numbers.First();
        Console.WriteLine(first);

        int last = numbers.Last();
        Console.WriteLine(last);


        List<int> numbers1 = new List<int> { 3, 45, 67 };
        int value = numbers1.Single(n => n>2);
        Console.WriteLine(value);
    }
}
