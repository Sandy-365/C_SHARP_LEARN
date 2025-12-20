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