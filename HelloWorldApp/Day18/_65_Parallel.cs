using System;
using System.Threading;
using System.Threading.Tasks;

class _65_Parallel
{
    public void Main()
    {
        int n = 1000;
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
            numbers[i] = i + 1;

        Console.WriteLine("Started " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffff"));

        long normalSum = 0;
        for (int i = 0; i < n; i++)
            normalSum += numbers[i];

        Console.WriteLine("Normal Sum: " + normalSum);
        Console.WriteLine("Normal done " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffff"));

        long parallelSum = 0;

        Parallel.For(0, n,
            () => 0L,
            (i, loopState, localSum) =>
            {
                localSum += numbers[i];
                return localSum;
            },
            localSum =>
            {
                Interlocked.Add(ref parallelSum, localSum);
            });

        Console.WriteLine("Parallel Sum: " + parallelSum);
        Console.WriteLine("Ended " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffff"));
    }
}
