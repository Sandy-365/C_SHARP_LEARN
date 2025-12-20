/*
NOTE:

This class demonstrates the concept of **Employee data handling**
using Object-Oriented Programming (OOP) in C#.

==============================================================
CLASS: Employee
==============================================================
Purpose:
Represents an employee entity with basic details such as
ID, Name, Department, Salary, and Gender.

==============================================================
DATA MEMBERS
==============================================================
Id          → Stores employee ID  
Name        → Stores employee name  
Department  → Stores employee department  
Salary      → Stores employee salary  
Gender      → Stores employee gender  

All data members are instance variables, meaning
each object has its own copy.

==============================================================
CONSTRUCTOR: Employee(...)
==============================================================
Purpose:
- Initializes employee object at the time of creation.
- Uses `this` keyword to differentiate instance variables
  from constructor parameters.

Concepts Used:
- Parameterized constructor
- this keyword
- Object initialization

==============================================================
METHOD: AcceptDetails()
==============================================================
Purpose:
- Takes employee details from the user at runtime.
- Updates existing object values.

Input Handling:
- int      → Convert.ToInt32
- float    → Convert.ToSingle
- char     → Convert.ToChar
- string   → Console.ReadLine()

Concepts Used:
- Console input
- Type conversion
- Runtime data assignment

==============================================================
METHOD: DisplayDetails()
==============================================================
Purpose:
- Displays all employee details in a readable format.
- Uses string interpolation for clean output.

Concepts Used:
- Console output
- String interpolation ($"")

==============================================================
CONCEPTS DEMONSTRATED
==============================================================
- Class and object
- Instance variables
- Constructor usage
- this keyword
- User input handling
- Encapsulation of data and behavior

==============================================================
KEY LEARNING
==============================================================
This class shows how real-world entities like employees
can be modeled in C# using classes, constructors, and methods
to store and display structured data.
*/


using System;

class Employee
{
    int Id;
    string Name;
    string Department;
    float Salary;
    char Gender;

    public Employee(int Id,string Name,string Department,float Salary,char Gender)
    {
        this.Id = Id;
        this.Name = Name;
        this.Department = Department;
        this.Salary = Salary;
        this.Gender = Gender;

    }
    public void AcceptDetails()
    {
        Console.WriteLine("-----------------Enter Employees Details---------------------");
        Console.Write("Enter Employee Id ::>> ");
        Id = Convert.ToInt32(Console.ReadLine());
        // Id = int.Parse(Console.ReadLine());


        Console.Write("Enter Employee Name ::>> ");
        Name = Console.ReadLine()!;


        Console.Write("Enter Employee Department ::>> ");
        Department = Console.ReadLine()!;


        Console.Write("Enter Employee Salary ::>> ");
        Salary = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter Employee Gender ::>> ");
        Gender = Convert.ToChar(Console.ReadLine()!);

    }
    public void DisplayDetails()
    {
        // Console.WriteLine("===============EMPLOYEE DETAILS ARE==============");
        // Console.WriteLine("ID is ::>> "+Id);
        // Console.WriteLine("Name is ::>> "+Name);
        // Console.WriteLine("Department is ::>> "+Department);
        // Console.WriteLine("Salary is ::>> "+Salary);
        // Console.WriteLine("Gender is ::>> "+Gender);


        Console.WriteLine("===============EMPLOYEE DETAILS ARE==============");
        Console.WriteLine($"ID is ::>> {Id}");
        Console.WriteLine($"Name is ::>> {Name}");
        Console.WriteLine($"Department is ::>> {Department}");
        Console.WriteLine($"Salary is ::>> {Salary}");
        Console.WriteLine($"Gender is ::>> {Gender}");
    }
}