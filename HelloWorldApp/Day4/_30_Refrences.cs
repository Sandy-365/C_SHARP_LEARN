/*
==================================================
C# ACCESS MODIFIERS
==================================================

1. public
--------------------------------------------------
- Accessible from anywhere
- Same class
- Child class
- Same project
- Different project

Example:
public int balance;


2. private
--------------------------------------------------
- Accessible only inside the same class
- NOT accessible in child class
- Default for class members

Example:
private int pin;


3. protected
--------------------------------------------------
- Accessible in same class
- Accessible in child (derived) classes
- NOT accessible using object reference

Example:
protected double ROI;


4. internal
--------------------------------------------------
- Accessible only within the same project / assembly
- Same project: YES
- Different project: NO

Example:
internal string bankName;


5. protected internal
--------------------------------------------------
- Accessible in same project
- OR accessible in child class (even in different project)
- Union of protected + internal

Example:
protected internal int accountId;


6. private protected
--------------------------------------------------
- Accessible in same class
- Accessible in child class BUT only in same project
- Intersection of private + protected

Example:
private protected double interest;


--------------------------------------------------
DEFAULT ACCESS LEVELS
--------------------------------------------------
- Class members: private
- Top-level class: internal


--------------------------------------------------
PROJECT REFERENCE (VERY IMPORTANT)
--------------------------------------------------
- To use a class from ANOTHER project:
  1) The class MUST be public
  2) Project reference MUST be added
  3) Correct namespace MUST be used

Command:
dotnet add reference <PathToOtherProject>.csproj

Example:
BankApp  --->  HelloWorldApp

In code:
using HelloWorldApp.Day3;

--------------------------------------------------
QUICK COMPARISON
--------------------------------------------------

Modifier             Access
--------------------------------------------------
public               Everywhere
private              Same class only
protected            Same class + child
internal             Same project
protected internal   Same project OR child
private protected    Same project + child

==================================================
*/

/*
==================================================
USE CASE OF NAMESPACE IN C#
==================================================

1) AVOID NAME CONFLICT
--------------------------------------------------
- Two classes can have the SAME name
- Namespace separates them logically

Example:
namespace BankApp
{
    class Account { }
}

namespace SchoolApp
{
    class Account { }
}

Without namespace → compiler error
With namespace → both coexist safely


2) ORGANIZE LARGE PROJECTS
--------------------------------------------------
- Groups related classes together
- Makes code readable and maintainable

Example:
HelloWorldApp.Day1
HelloWorldApp.Day2
HelloWorldApp.Day3


3) CONTROL VISIBILITY ACROSS FILES
--------------------------------------------------
- Classes in different namespaces need `using`
- Prevents accidental access

Example:
using HelloWorldApp.Day3;


4) WORK WITH MULTIPLE PROJECTS
--------------------------------------------------
- Namespaces identify where a class belongs
- Required when using class from another project

Example:
using HelloWorldApp.Day3;
_23_FixedDeposit fd = new _23_FixedDeposit();


5) AVOID GLOBAL NAMESPACE POLLUTION
--------------------------------------------------
- Too many classes in global namespace is bad practice
- Namespace keeps global space clean


6) SUPPORT SCALABLE APPLICATION DESIGN
--------------------------------------------------
- Industry-level projects rely heavily on namespaces
- Helps in layering (UI, Service, Data, Models)

Example:
MyApp.UI
MyApp.Services
MyApp.Data


--------------------------------------------------
IMPORTANT RULES (MEMORIZE)
--------------------------------------------------
- Namespace ≠ Folder
- Same namespace → no `using` needed
- Different namespace → `using` required
- Same project still needs `using` if namespace differs
- Namespace does NOT affect runtime performance

==================================================
*/



namespace HelloWorldApp.Day3
{
    public class _23_BankAccount
    {
        public int TimePeriod;
        double Principal;
        double ROI;

        public _23_BankAccount(int TimePeriod, double Principal, double ROI)
        {
            Console.WriteLine("PARENT BankAccount Constructors is Called");
            this.TimePeriod = 23;
            this.Principal = 2450.0f;
            this.ROI = 3.0f;
        }
    }


    public class _23_FixedDeposit : _23_BankAccount
    {
        string name;
        public _23_FixedDeposit(string name) : base(10, 200000, 2)
        {
            Console.WriteLine("BASE BankAccount Constructors is Called");
            this.name = name;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"TimePeriod is ::>> {TimePeriod}");
        }
    }
}