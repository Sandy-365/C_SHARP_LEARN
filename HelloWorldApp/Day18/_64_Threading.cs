using System.Threading;
class _64_Threading
{
    public void Main()
    {
        // Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));
        // thread.Start();

        Thread worker = new Thread(Dowork);
        Thread worker1 = new Thread(Dowork1);
        worker.Start();
        worker1.Start();
        Console.WriteLine("Work of the worker is Done");
    }

    static void Dowork()
    {
        for(char i = 'a'; i < 'i'; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine(i);
        }
    }
    static void Dowork1()
    {
        for(char i = 'i'; i < 'z'; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine(i);
        }
    }

    static void PrintMessage(Object obj)
    {
        Console.WriteLine("Hello World");
        for(int i =0; i < 10; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine(i);
        }
    }
}