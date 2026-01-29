using System;
using System.IO;
using System.Threading.Tasks;

class _67_Async_Task
{
    public async Task Main()
    {
        Console.WriteLine("Start reading file...");

        string content = await File.ReadAllTextAsync("Day18/data.txt");

        Console.WriteLine("File content:");
        Console.WriteLine(content);

        Console.WriteLine("End of program");
    }
}
