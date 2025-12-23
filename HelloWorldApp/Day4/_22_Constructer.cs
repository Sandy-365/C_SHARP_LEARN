/*
========================================
TOP NOTES – CONSTRUCTOR CONCEPT
========================================

1. A constructor is a special member of a class.
2. Constructor name MUST be same as class name.
3. Constructor does NOT have a return type (not even void).
4. Constructor is automatically called when an object is created.
5. Used to initialize data members of a class.
6. If no constructor is written, compiler provides a default constructor.
7. "this" keyword refers to current object of the class.
8. Methods and constructors are different.
9. A constructor cannot be called like a normal method.
10. Constructor executes only once per object creation.
*/

class _22_Constructor
{
    String name;
    int rollNo;
    static String collegeName;

    /*
   ----------------------------------------
   STATIC CONSTRUCTOR
   ----------------------------------------
   - Called only once
   - Executes before any object is created
   - Used to initialize static data
   */
    static _22_Constructor()
    {
        collegeName = "LPU";
        Console.WriteLine("Static Constructor Called");
    }

    /*
    ----------------------------------------
    DEFAULT CONSTRUCTOR
    ----------------------------------------
    */
    public _22_Constructor()
    {
        this.name = "Manish";
        this.rollNo = 35;
        Console.WriteLine("Default Constructor Called");
    }

    /*
    ----------------------------------------
    PARAMETERIZED CONSTRUCTOR
    ----------------------------------------
    Used to pass values during object creation
    */
    public _22_Constructor(String name, int rollNo)
    {
        this.name = name;
        this.rollNo = rollNo;
        Console.WriteLine("Parameterized Constructor Called");
    }

    /*
    ----------------------------------------
    NORMAL METHOD (NOT CONSTRUCTOR)
    ----------------------------------------
    */
    public void Constructor()
    {
        this.name = "Sandeep";
        this.rollNo = 23;
        Console.WriteLine("Normal Method Called");
    }

    /*
    ----------------------------------------
    DISPLAY METHOD
    ----------------------------------------
    */
    public void DisplayDetails()
    {
        Console.WriteLine("--------------DATA--------------");
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"Roll : {rollNo}");
        Console.WriteLine($"College : {collegeName}");
    }

}

/*
========================================
BOTTOM NOTES – IMPORTANT CONCEPTS
========================================

1. When object is created:
   _22_Constructor obj = new _22_Constructor();
   → Constructor is automatically executed.

2. The method "Constructor()" is NOT a constructor.
   It behaves like a normal method and must be called:
   obj.Constructor();

3. Order of execution:
   - Constructor runs first
   - Then methods are called manually

4. "this" keyword:
   - Differentiates between instance variables
     and local variables.
   - Refers to current object.

5. If you remove the constructor:
   - name will be null
   - rollNo will be 0 (default values)

6. You can have:
   - Default constructor
   - Parameterized constructor
   - Constructor overloading

7. Constructors improve:
   - Object initialization
   - Code readability
   - Data safety

8. Common mistake:
   - Writing return type in constructor
   - Thinking normal method is constructor

========================================
END OF NOTES
========================================
*/