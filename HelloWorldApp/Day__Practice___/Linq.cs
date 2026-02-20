class linq_pract
{
    static void main()
    {
        
       List<int> num = new List<int> { 10, 20, 30 };

        var deferred = num.Where(n => n > 15);
        num.Add(90);

        Console.WriteLine("Deferred Execution");
        foreach (var n in deferred)
        {
            Console.WriteLine(n);
        }


        var imed = num.Where(n => n > 25);
        num.Add(100);
        Console.WriteLine("\nImmediate Executin");
        foreach (var i in imed)
        {
            Console.WriteLine(i);
        }


        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int half = list.Count / 2;

        var listA = list.Take(half);
        var listB = list.Skip(half);

        foreach (var item in listA)
            Console.Write(item + " ");

        Console.WriteLine();

        foreach (var item in listB)
            Console.Write(item + " ");

    }
}
