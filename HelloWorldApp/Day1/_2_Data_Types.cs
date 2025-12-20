class Data_Types
{
    int NumInt;
    long NumLong;
    float NumFloat;
    double NumDouble;
    bool BoolInp;
    char CharInp;
    string StringInp;

    public Data_Types()
    {
        NumInt = 1000;
        NumLong = 1001L;
        NumFloat = 1002F;
        NumDouble = 1003.05D;
        BoolInp = false;
        CharInp = 'S';
        StringInp = "Sandeep";
    }

    public void Take_Input()
    {
        // Console.Write("Enter int data type ::>> ");
        // NumInt = int.Parse(Console.ReadLine()!);

        // Console.Write("Enter long data type ::>> ");
        // NumLong = long.Parse(Console.ReadLine()!);

        // Console.Write("Enter float data type ::>> ");
        // NumFloat = float.Parse(Console.ReadLine()!);

        // Console.Write("Enter double data type ::>> ");
        // NumDouble = double.Parse(Console.ReadLine()!);

        // Console.Write("Enter bool data type ::>> ");
        // BoolInp = bool.Parse(Console.ReadLine()!);

        // Console.Write("Enter char data type ::>> ");
        // CharInp = char.Parse(Console.ReadLine()!);

        // Console.Write("Enter string data type ::>> ");
        // StringInp = Console.ReadLine()!;


        Console.Write("Enter int data type ::>> ");
        NumInt = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter long data type ::>> ");
        NumLong = Convert.ToInt64(Console.ReadLine());

        Console.Write("Enter float data type ::>> ");
        NumFloat = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter double data type ::>> ");
        NumDouble = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter bool data type ::>> ");
        BoolInp = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Enter char data type ::>> ");
        CharInp = Convert.ToChar(Console.ReadLine()!);

        Console.Write("Enter string data type ::>> ");
        StringInp = Convert.ToString(Console.ReadLine()!);


    }


    public void PrintAll()
    {
        Console.WriteLine("int Data Type ::>> " + NumInt);
        Console.WriteLine("long Data Type ::>> " + NumLong);
        Console.WriteLine("float Data Type ::>> " + NumFloat);
        Console.WriteLine("double Data Type ::>> " + NumDouble);
        Console.WriteLine("bool Data Type ::>> " + BoolInp);
        Console.WriteLine("char Data Type ::>> " + CharInp);
        Console.WriteLine("string Data Type ::>> " + StringInp);
    }

}