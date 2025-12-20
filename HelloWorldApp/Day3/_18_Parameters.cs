/*
NOTE:

This class explains different types of **method parameters** in C#,
including default parameters, params keyword, and parameter rules.

---------------------------------------------------------
CLASS: _18_Parameters
---------------------------------------------------------
Purpose:
Demonstrates how methods accept values in different ways
and how C# handles flexible parameter passing.

---------------------------------------------------------
1. DEFAULT (OPTIONAL) PARAMETERS
---------------------------------------------------------
Method:
- person(string name, string city, int age, int rollNo,
         string college = "LPU", string ram = "Sandeep")

Explanation:
- Parameters with default values are optional.
- If caller does not pass them, default values are used.
- Optional parameters must appear after required parameters.

---------------------------------------------------------
2. params KEYWORD (VARIABLE ARGUMENTS)
---------------------------------------------------------
Method:
- Params(params int[] arr)

Explanation:
- Allows passing a variable number of integer arguments.
- All values are treated as an array inside the method.
- Commonly used when number of inputs is unknown.

Important Note:
- The variable 'sum' is an instance variable.
- Its value persists across multiple method calls.

---------------------------------------------------------
3. RULE OF params PARAMETER
---------------------------------------------------------
- Only ONE params parameter is allowed in a method.
- params parameter MUST be the LAST parameter.
- Violating this rule causes a compile-time error.

(Shown in commented invalid methods)

---------------------------------------------------------
4. COMBINATION OF NORMAL + OPTIONAL + params
---------------------------------------------------------
Method:
- Params3(int num, string name = "Sandeep", params string[] str)

Explanation:
- num is mandatory
- name is optional
- str accepts multiple string values

---------------------------------------------------------
Method:
- Params4(int num, string name = "Sandeep", params int[] arr)

Explanation:
- Demonstrates params with integer values
- Shows correct order of parameters:
  normal → optional → params

---------------------------------------------------------
KEY LEARNING
---------------------------------------------------------
1. Optional parameters simplify method calls.
2. params keyword provides flexibility.
3. params must always be last.
4. Parameter order rules are strictly enforced by C#.
*/


class _18_Parameters
{
    // static int sum;
    int sum;
    public void person(string name,string city,int age,int rollNo,string college = "LPU",string ram = "Sandeep")
    {
        Console.WriteLine($"Name is Student is {name}");
        Console.WriteLine($"City of the {name} is {city}");
        Console.WriteLine($"age of the {name} is {age}");
        Console.WriteLine($"rollNo of the {name} is {rollNo}");
        Console.WriteLine($"College of the {name} is {college}");
    }


    public void Params(params int[] arr)
    {
        // int sum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        Console.WriteLine($"Sum of all parameters is {sum}");
    }

    //Error : A params parameter must be the last parameter in a parameter listC
    //public void Params2(params int[] arr,params string[] str)
    //{
    //}

    public void Params3(int num,string name="Sandeep",params string[] str)
    {
        Console.WriteLine("num passed is "+ num);
        Console.WriteLine("name passed is "+name);
        for(int i =0; i < str.Length; i++)
        {
            Console.Write(str[i]+"  ");
        }
    }
    public void Params4(int num,string name="Sandeep",params int[] arr)
    {
        Console.WriteLine("\n\nInside param 4 (int num,string name,params int[] arr)");
        Console.WriteLine("passed -- (1,arr: new int[]{3,4,5,6})");
        Console.WriteLine("num passed is "+ num);
        Console.WriteLine("name passed is "+name);
        for(int i =0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+"  ");
        }
    }

    //Error :- A params parameter must be the last parameter in a parameter listComponent
    // public void Params4(int arr,params string[] str,string name = "Manish");
    // {
    // }


}