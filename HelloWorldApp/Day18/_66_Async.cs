using System;
using System.Threading.Tasks;

class _66_Async
{
    static async Task<int> GetDataAsync()
    {
        await Task.Delay(1000);
        return 42;
    }

    public async Task Main()
    {
        int data = await GetDataAsync();
        Console.WriteLine(data);
    }
}
