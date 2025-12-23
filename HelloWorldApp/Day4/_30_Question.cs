/*
Problem Statement

You are designing a Student Profile System.

Each student has:

Name

Age

Marks

Rules (Business Logic)

Name cannot be empty

Age must be greater than 0

Marks must be between 0 and 100

You must:

Store data using private variables

Expose data using public properties

Apply validation inside set

Task Requirements
Step 1: Create a class Student

The class should contain:

Private fields:

name

age

marks

Step 2: Create Properties

Create the following properties:

1. Name Property

get → returns name

set → assigns name only if it is not empty

2. Age Property

get → returns age

set → allows age only if greater than 0

3. Marks Property

get → returns marks

set → allows marks only between 0 and 100

Step 3: Use the Properties

In Main():

Create a student object

Assign values using properties
*/


/*
EXTENDED TASK: Advanced Properties in C#
Task Title

Student Profile System – Advanced Property Types

Objective

To understand and implement:

Normal properties with validation

Auto-implemented properties

Read-only properties

Write-only properties

Base Scenario

You are developing a Student Profile System for a college application.

Each student has:

Name

Age

Marks

Student ID

Password

Different data requires different access rules.

PART A: Auto-Implemented Property
Requirement

Store the Student ID.

Rules:

No validation required

Direct get and set allowed

Task Instruction

Use an auto-implemented property.

Hint

Auto-implemented properties do not require a private backing field.

PART B: Read-Only Property
Requirement

Calculate Result Status based on marks.

Rules:

Marks ≥ 40 → “Pass”

Marks < 40 → “Fail”

Value should be readable

Value should NOT be set from outside

Task Instruction

Create a read-only property.

PART C: Write-Only Property
Requirement

Store Password securely.

Rules:

Password can be set

Password must NOT be readable

Password length must be at least 6 characters

Task Instruction

Create a write-only property.

PART D: Normal Property with Validation (Revision)
Requirement

Name cannot be empty

Age must be greater than 0

Marks must be between 0 and 100

*/


/*
PART 5: Property with Private Set
Requirement
Store the Registration Number.
Rules
Value should be readable from outside


Value should be modifiable only inside the class


Task Instruction
Use a property with public get and private set


Assign the value internally (constructor or method)



PART 6: Init-Only Property
Requirement
Store the Admission Year.
Rules
Value should be set only at the time of object creation


Value must not be modified later


Task Instruction
Use an init-only property


Set the value using object initializer syntax



PART 7: Expression-Bodied Property
Requirement
Create a property to calculate Percentage.
Rules
Percentage = (Marks / 100) × 100


Property should be read-only


Use shortest possible syntax


Task Instruction
Implement an expression-bodied property



PART 8: Usage Task
In the Main() method:
Create a Student object


Assign values using all allowed properties


Display all readable properties


Try accessing restricted properties and note compiler errors

*/


/*
TASK: Implement Indexer Overloading in C#
Objective
To understand and implement indexer overloading by allowing a class to be accessed using different parameter types.

Scenario
You are designing a Library Management System.
Each book in the library has:
A Book ID (integer)
A Book Title (string)
Users should be able to:
Access books using Book ID
Access books using Book Title
This must be achieved using indexer overloading, not methods.

Task Requirements
You must create a class named Library and implement the following.

PART 1: Internal Data Storage
Use a suitable collection to store book data
Book ID should be the key
Book Title should be the value
Data structure must be private

PART 2: Integer-Based Indexer
Requirement
Allow access to book title using Book ID
Support both reading and writing
Example Usage
library[101] = "C# Basics";
Console.WriteLine(library[101]);


PART 3: String-Based Indexer
Requirement
Allow access using Book Title
Return the first matching title
Read-only access only
Example Usage
Console.WriteLine(library["C# Basics"]);


PART 4: Constraints
Do not expose the internal collection directly
Do not use GetBook() or SetBook() methods
Use indexers only

PART 5: Usage Task
In Main():
Create a Library object
Add at least 3 books using integer indexer
Retrieve books using both indexers
Observe behavior when a title is not found
*/



/*
class Student
{
    // Normal private fields
    private string name;
    private int age;
    private int marks;
    private string password;

    // PART A: Auto-Implemented Property
    public int StudentId { get; set; }

    // PART D: Normal Property - Name
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
        }
    }

    // PART D: Normal Property - Age
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value > 0)
            {
                age = value;
            }
        }
    }

    // PART D: Normal Property - Marks
    public int Marks
    {
        get
        {
            return marks;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                marks = value;
            }
        }
    }

    // PART B: Read-Only Property
    public string Result
    {
        get
        {
            return marks >= 40 ? "Pass" : "Fail";
        }
    }

    // PART C: Write-Only Property
    public string Password
    {
        set
        {
            if (value.Length >= 6)
            {
                password = value;
            }
        }
    }
}


class Student
{
    // =========================
    // PART 1: Normal Properties
    // =========================

    private string name;
    private int age;
    private int marks;
    private string password;

    // ==============================
    // PART 5: Property with Private Set
    // ==============================

    public int RegistrationNumber { get; private set; }

    // =========================
    // PART 6: Init-Only Property
    // =========================

    public int AdmissionYear { get; init; }

    // =========================
    // PART 7: Expression-Bodied Property
    // =========================

    public double Percentage => (marks / 100.0) * 100;

    // Constructor (sets private-set property)
    public Student(int regNo)
    {
        RegistrationNumber = regNo;
    }
}


2. Using the Student Class (Main Method)
class Program
{
    static void Main()
    {
        Student s = new Student(5001)
        {
            AdmissionYear = 2023
        };

        s.StudentId = 101;
        s.Name = "Amit";
        s.Age = 20;
        s.Marks = 78;
        s.Password = "secure123";

        Console.WriteLine("Student ID: " + s.StudentId);
        Console.WriteLine("Name: " + s.Name);
        Console.WriteLine("Age: " + s.Age);
        Console.WriteLine("Marks: " + s.Marks);
        Console.WriteLine("Result: " + s.Result);
        Console.WriteLine("Percentage: " + s.Percentage);
        Console.WriteLine("Registration No: " + s.RegistrationNumber);
        Console.WriteLine("Admission Year: " + s.AdmissionYear);
    }
}

*/