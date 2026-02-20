using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class _2_List
{
    public void main()
    {
        ArrayList list = new ArrayList { 1, 'M', "Man", "MCA", 2000 };

        IEnumerable<int> intResult =
            list.Cast<object>()
                .Where(x => x is int)
                .Select(x => (int)x);
        foreach (var i in intResult)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();


        // Names that start with 'A'
        string[] names1 = { "Aman", "Rahul", "Ankit", "Suresh", "Ajay", "Neha", "Arjun" };
        IEnumerable<string> startWithA =
            names1.Where(n => n.StartsWith("A", StringComparison.OrdinalIgnoreCase));
        foreach (var name in startWithA)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();


        // Names that end with 'v' and add "Mr "
        string[] names2 = { "Aarav", "Raghav", "Amit", "Saurav", "Neha", "Rajiv", "Kunal" };
        IEnumerable<string> endWithV =
            names2
                .Where(n => n.EndsWith("v", StringComparison.OrdinalIgnoreCase))
                .Select(n => $"Mr {n}");
        foreach (var name in endWithV)
        {
            Console.WriteLine(name);
        }
    }
}
