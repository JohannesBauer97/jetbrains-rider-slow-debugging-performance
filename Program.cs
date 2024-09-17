using System.Diagnostics;

namespace Rider.Mac.Debug.Perf.Example;

public abstract class Program
{
    private static void Main()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        const int numberOfTasks = 10;
        var tasks = new List<Task>();

        for (var i = 0; i < numberOfTasks; i++)
        {
            tasks.Add(Task.Run(() =>
            {
                for (var n = 1; n <= 40; n++)
                {
                    var result = Fibonacci(n);
                    // Console.WriteLine($"Task {Task.CurrentId}: Fibonacci({n}) = {result}");
                }
            }));
        }

        Task.WaitAll(tasks.ToArray());
        stopwatch.Stop();
        Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");
    }

    private static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
