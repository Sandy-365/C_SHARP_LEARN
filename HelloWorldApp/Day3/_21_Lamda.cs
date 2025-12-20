class _21_Lamda_Static
{
    public void ExampleLamda()
    {
        int Square(int x)
        {
            return x * x;
        }
        Func<int, int> squareLambda = x => x * x;
        Console.WriteLine("Square os 4 using simple function ::>> "+Square(4));
        Console.WriteLine("Square of 4 using lamda ::>> "+squareLambda(4));
    }

    static int number = 5;
    public void ExampleStatic()
    {
        static int Square(int x)
        {
            return x * x;
        }
        Console.WriteLine(Square(number)+"  non-static function can acces static and non-static variables");
    }

    public static void ExampleStatic2()
    {
        static int Square(int x)
        {
            return x * x;
        }
        Console.WriteLine(Square(number)+" static fucntion can not acces non static variable but can access on ly static variables");
    }
}