using System;

/*
==================================================
C# ACCESS MODIFIERS
==================================================

Access modifiers define the SCOPE (visibility) of
classes, variables, methods, and constructors.

WHY ACCESS MODIFIERS?
- Data hiding
- Security
- Controlled access
- Proper OOP design

--------------------------------------------------
1. public
--------------------------------------------------
- Accessible from anywhere
- Same class
- Child class
- Same project
- Different project

Use case:
When data or method must be globally accessible.

Example:
public int balance;

--------------------------------------------------
2. private
--------------------------------------------------
- Accessible ONLY inside the same class
- NOT accessible in child class
- NOT accessible using object
- DEFAULT for class members

Use case:
For data hiding and security.

Example:
private int pin;

--------------------------------------------------
3. protected
--------------------------------------------------
- Accessible in same class
- Accessible in child (derived) classes
- NOT accessible using object reference

Use case:
Used in inheritance where child needs access.

Example:
protected double ROI;

--------------------------------------------------
4. internal
--------------------------------------------------
- Accessible only within the same project / assembly
- Same project: YES
- Different project: NO

Use case:
When access is required only inside project.

Example:
internal string bankName;

--------------------------------------------------
5. protected internal
--------------------------------------------------
- Accessible in same project
- OR accessible in child class (any project)
- UNION of protected + internal

Use case:
Library development with inheritance support.

Example:
protected internal int accountId;

--------------------------------------------------
6. private protected
--------------------------------------------------
- Accessible in same class
- Accessible in child class BUT only in same project
- INTERSECTION of private + protected

Use case:
High level restriction with inheritance.

Example:
private protected double interest;

--------------------------------------------------
DEFAULT ACCESS LEVELS
--------------------------------------------------
Class members     : private
Top-level class   : internal

--------------------------------------------------
IMPORTANT EXAM POINT
--------------------------------------------------
Top-level classes CANNOT be private or protected





--------------------------------------------------
DEFAULT ACCESS LEVELS
--------------------------------------------------
Class members     : private
Top-level class   : internal

--------------------------------------------------
QUICK COMPARISON
--------------------------------------------------

public               -> Everywhere
private              -> Same class only
protected            -> Same class + child
internal             -> Same project
protected internal   -> Same project OR child
private protected    -> Same project + child



==================================================
*/


class _23_BankAccount
{
    // protected allows access in derived class
    // but NOT using object reference
    protected int TimePeriod;
    protected float Principal;
    protected float ROI;

    // Parent class constructor
    // Constructor executes automatically during object creation
    public _23_BankAccount(int TimePeriod, double Principal, double ROI)
    {
        // Parent constructor executes first in inheritance
        Console.WriteLine("PARENT BankAccount Constructor is Called");

        // Assigning values
        // Using this keyword refers to current class variables
        this.TimePeriod = 23;
        this.Principal = 2450.0f;
        this.ROI = 3.0f;
    }
}


class _23_FixedDeposit : _23_BankAccount
{
    // private by default
    // accessible only inside this class
    string name;

    // base() explicitly calls parent constructor
    // If parent has parameterized constructor, base() is mandatory
    public _23_FixedDeposit(string name) : base(10, 200000, 2)
    {
        Console.WriteLine("BASE BankAccount Constructor is Called");
        this.name = name;
    }

    // Method accessing protected members
    public void DisplayDetails()
    {
        Console.WriteLine($"TimePeriod is ::>> {TimePeriod}");
        Console.WriteLine($"Principal is ::>> {Principal}");
        Console.WriteLine($"ROI is ::>> {ROI}");
    }
}


/*
==================================================
SINGLE INHERITANCE
==================================================

Definition:
One child class inherits from one parent class.

Relationship:
Car IS-A Vehicle
Means---
    A Car is a type of Vehicle
    Whatever a Vehicle can do, a Car can also do
    Car inherits properties and methods of Vehicle

Advantage:
- Code reusability
- Easy maintenance
*/

class _23_Vehicle
{
    /*
    Base class constructor:
    - Called automatically
    - Called before child constructor
    */
    public _23_Vehicle()
    {
        Console.WriteLine("Vehicle Base Call");
    }

    /*
    Parent class method
    - Inherited by child class
    */
    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}

class _23_Car : _23_Vehicle
{
    /*
    Child-specific behavior
    - Not present in parent
    */
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}


/*
==================================================
CONSTRUCTOR CHAINING
==================================================

Rule:
If parent has parameterized constructor,
child MUST call it using base().

If base() is not used → compile-time error
*/

class _23_Person
{
    public string Name;

    public _23_Person(string name)
    {
        Name = name;
    }
}

class _23_Student : _23_Person
{
    public int RollNo;

    /*
    base(name):
    - Passes value to parent constructor
    - Ensures proper initialization
    */
    public _23_Student(string name, int roll) : base(name)
    {
        RollNo = roll;
    }
}


/*
==================================================
MULTILEVEL INHERITANCE
==================================================

Inheritance chain:
Employee → Human → LivingBeing

Each level adds its own behavior
*/

class _23_LivingBeing
{
    public void Breathe()
    {
        Console.WriteLine("Breathing");
    }
}

class _23_Human : _23_LivingBeing
{
    public void Think()
    {
        Console.WriteLine("Thinking");
    }
}

class _23_Employee : _23_Human
{
    public void Work()
    {
        Console.WriteLine("Working");
    }
}


/*
==================================================
HIERARCHICAL INHERITANCE
==================================================

Definition:
One parent class with multiple child classes

Shape → Circle
Shape → Rectangle
*/

class _23_Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing shape");
    }
}

class _23_Circle : _23_Shape
{
    // Inherits Draw() from Shape
}

class _23_Rectangle : _23_Shape
{
    // Inherits Draw() from Shape
}


/*
==================================================
MULTIPLE INHERITANCE USING INTERFACES
==================================================

Important:
- C# does NOT support multiple inheritance using classes
- Interfaces are used instead to avoid ambiguity
*/

interface _23_IPrintable
{
    void Print();
}

interface _23_IScannable
{
    /*
    Interfaces can have same method names
    No ambiguity because class provides implementation
    */
    void Print();
    void Scan();
}

class _23_Machine : _23_IPrintable, _23_IScannable
{
    /*
    Single Print() implementation satisfies both interfaces
    */
    public void Print()
    {
        Console.WriteLine("Printing");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning");
    }
}


/*
==================================================
METHOD OVERRIDING
==================================================

- Requires virtual (parent) + override (child)
- Runtime polymorphism
- Decision based on OBJECT type
*/

class _23_Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}

class _23_Dog : _23_Animal
{
    /*
    override:
    - Replaces parent method behavior
    */
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}


/*
==================================================
base KEYWORD WITH METHOD OVERRIDING
==================================================

base.method():
- Calls parent version of overridden method
- Used to EXTEND behavior, not replace fully
*/

class _23_AnimalBase
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class _23_DogDerived : _23_AnimalBase
{
    public override void Speak()
    {
        base.Speak();     // Parent behavior
        Console.WriteLine("Dog speaks");
    }
}


/*
==================================================
METHOD HIDING
==================================================
Method hiding occurs when a child class hides a parent class method using the new keyword, 
and method calls are resolved at compile time based on reference type.

- Uses new keyword
- Compile-time binding
- Depends on REFERENCE type
- Does NOT support polymorphism
-----Method call depends on the REFERENCE TYPE, not the OBJECT TYPE.
*/

class _23_ParentHide
{
    public void Show()
    {
        Console.WriteLine("Parent Show");
    }
}

class _23_ChildHide : _23_ParentHide
{
    public new void Show()
    {
        Console.WriteLine("Child Show");
    }
}


/*
==================================================
STATIC METHOD HIDING
==================================================

Rule:
Static methods CANNOT be overridden
They can ONLY be hidden using new
*/

class _23_StaticA
{
    public static void Display()
    {
        Console.WriteLine("Static A");
    }
}

class _23_StaticB : _23_StaticA
{
    public new static void Display()
    {
        Console.WriteLine("Static B");
    }
}


/*
==================================================
SEALED CLASSES AND METHODS
==================================================

sealed class:
- Cannot be inherited

sealed method:
- Cannot be overridden further
*/

sealed class _23_Security
{
    public void Access()
    {
        Console.WriteLine("Secure Access");
    }
}


class _23_Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent Show");
    }
}

class _23_Child : _23_Parent
{
    /*
    sealed override:
    - Override allowed here
    - Further overriding NOT allowed
    */
    public sealed override void Show()
    {
        Console.WriteLine("Child Show");
    }
}


/*
==================================================
COMPOSITION (HAS-A RELATIONSHIP)
==================================================

Car HAS-A Engine

Why composition is preferred:
- Loose coupling
- Better flexibility
- Safer than inheritance
*/

class _23_Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started");
    }
}

class _23_CarComposition
{
    /*
    Car USES Engine
    Car does NOT inherit Engine
    */
    _23_Engine engine = new _23_Engine();

    public void Drive()
    {
        engine.Start();
        Console.WriteLine("Car driving");
    }
}