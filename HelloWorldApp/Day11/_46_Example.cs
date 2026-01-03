class _46_Example_Garbage
{
    public void Main()
    {
        Console.WriteLine($"Total Memory Before GC: {GC.GetTotalMemory(false)} bytes");

        for (long i = 0; i < 1000000000000000;i++)
        {
            object obj = new object(); // Gen 0 allocation
        }

        Console.WriteLine($"Total Memory After Object Creation: {GC.GetTotalMemory(false)} bytes");

        GC.Collect(); 
        GC.WaitForPendingFinalizers();

        Console.WriteLine($"Total Memory After GC: {GC.GetTotalMemory(false)} bytes");
        Console.WriteLine($"Generation of a new object: {GC.GetGeneration(new object())}");
    }
}

// leetcode, dotnetfiddle.net, hackerrank.com