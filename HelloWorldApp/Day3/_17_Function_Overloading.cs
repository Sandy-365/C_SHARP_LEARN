using System;

class _17_FunctionOverloading
{
    // public static int Add(int a,int b)
    // {
    //     return a+b;
    // }

    // ONLY DIFFERENT PARAMETER LIST IS ALLOWED FOR OVERLOADING
    // DIFFERENT RETURN TYPE ALONE IS NOT ALLOWED

    public int Add(int a,int b)
    {
        Console.WriteLine("\nsimple int");
        return a + b;
    }

    // This is NOT allowed
    // error ::-- Type '_17_FunctionOverloading' already defines a member called 'Add' with the same parameter types CS0111
    // public void Add(int a,int b)
    // {
    //     Console.WriteLine("\nsimple int and sum is "+(a+b));
    // }

    // OVERLOADING BY DATA TYPE
    public double Add(double a,int b)
    {
        Console.WriteLine("\nsimple double");
        return a + b;
    }

    // OVERLOADING BY NUMBER OF PARAMETERS
    public int Add(int a,int b,int c)
    {
        Console.WriteLine("\nthree int");
        return a + b + c;
    }

    // OVERLOADING BY ORDER OF PARAMETERS
    public int Add(int a,double b)
    {
        Console.WriteLine("\nint then double");
        return a + (int)b;
    }

    public int Add(double a,int b,double c)
    {
        Console.WriteLine("\ndouble int double");
        return (int)a + b + (int)c;
    }

    // OVERLOADING WITH STRING
    public string Add(string a,string b)
    {
        Console.WriteLine("\nstring concat");
        return a + b;
    }

    // OVERLOADING USING params KEYWORD
    public int Add(params int[] a)
    {
        int sum = 0;
        for(int i = 0; i < a.Length; i++)
            sum += a[i];

        Console.WriteLine("\nparams array");
        return sum;
    }

    // OVERLOADING WITH OPTIONAL PARAMETER
    public int Add(int a,int b,int c,int d = 0)
    {
        Console.WriteLine("\noptional parameter");
        return a + b + c + d;
    }
}