using System.Diagnostics;

class _68_Thread_Diag
{
    static int counter = 0;
    static object lockObj = new object();
    public void Main()
    {
        // Process currentProcess = Process.GetCurrentProcess();
        // Console.WriteLine("Current Process ID : " + currentProcess.Id);
        // Console.WriteLine("Process Name : " + currentProcess.ProcessName);
        // Console.WriteLine("Process Time : " + currentProcess.StartTime);
        // Console.WriteLine("Process Threads : " + string.Join(" ", currentProcess.Threads));
        // Console.WriteLine("Process Memory Usage : " + currentProcess.WorkingSet64);
        // Console.WriteLine("Process CPU usage : " + currentProcess.TotalProcessorTime);


        // // Create a new thread
        // Thread worker = new Thread(DoWork);

        // // Start the thread
        // worker.Start();

        // Console.WriteLine("Main thread continues...");

        // // Optional: Wait for worker thread to finish
        // worker.Join();
        // Console.WriteLine("Main thread finished");


        // // Process.Start("C:\\Users\\sagar\\Desktop\\TestFiles\\SkyDrive.exe");


        // Thread t1 = new Thread(Increment);
        // Thread t2 = new Thread(Increment);

        // t1.Start();
        // t2.Start();

        // t1.Join();
        // t2.Join();

        // Console.WriteLine("Counter value is ::>> " + counter);

        Task t1 = Task.Run(() => Console.WriteLine("Task 1"));
        Task t2 = Task.Run(() => Console.WriteLine("Task 2"));

        Task.WhenAll(t1, t2).ContinueWith(t => Console.WriteLine("All tasks completed")).Wait();
    
    }

    static void Increment()
    {
        for (int i = 0; i < 10000; i++)
        {
            lock (lockObj)
            {
                counter++;
            }
        }
    }

    static void DoWork()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Worker thread: " + i);
            Thread.Sleep(500); // Simulate work
        }
    }
}


