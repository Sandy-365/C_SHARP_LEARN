class _69_Program
{
    public void Main()
    {
        List<List<int>> all = new List<List<int>>()
        {
            new List<int>(),
            new List<int>(),
            new List<int>()
        };

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0) all[0].Add(i);
            if (i % 3 == 0) all[1].Add(i);
            if (i % 2 != 0 && i % 3 != 0) all[2].Add(i);
        }

        Console.WriteLine("Division by 2 List is \n" + string.Join("-", all[0]));
        Console.WriteLine("\n\nDivision by 3 List is \n" + string.Join("-", all[1]));
        Console.WriteLine("\n\nDivision by not 2 and 3 List is \n" + string.Join("-", all[2]));
    }
}
