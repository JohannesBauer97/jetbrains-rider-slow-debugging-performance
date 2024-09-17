using System.Diagnostics;

namespace Rider.Mac.Debug.Perf.Example;

public abstract class Program
{
    private static async Task Main()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        await RunParallelFibonacciTasks();
        Console.WriteLine($"RunParallelFibonacciTasks time elapsed: {stopwatch.Elapsed}");
        stopwatch.Restart();
        await RunParallelHttpRequests();
        Console.WriteLine($"RunParallelHttpRequests time elapsed: {stopwatch.Elapsed}");
        stopwatch.Stop();
    }

    /// <summary>
    /// Run multiple Fibonacci tasks in parallel.
    /// </summary>
    private static async Task RunParallelFibonacciTasks()
    {
        int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        const int numberOfTasks = 10;
        var tasks = new List<Task>();

        for (var i = 0; i < numberOfTasks; i++)
        {
            tasks.Add(Task.Run(() =>
            {
                for (var n = 1; n <= 40; n++)
                {
                    Fibonacci(n);
                    // Console.WriteLine($"Task {Task.CurrentId}: Fibonacci({n}) = {result}");
                }
            }));
        }

        await Task.WhenAll(tasks.ToArray());
    }

    /// <summary>
    /// Run multiple HTTP requests in parallel.
    /// </summary>
    private static async Task RunParallelHttpRequests()
    {
        var client = new HttpClient();
        var tasks = new List<Task>();

        for (var i = 0; i < 10; i++)
        {
            tasks.Add(Task.Run(async () =>
            {
                var response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/1");
                var content = await response.Content.ReadAsStringAsync();
                // Console.WriteLine($"Task {Task.CurrentId}: {content}");
            }));
        }

        await Task.WhenAll(tasks.ToArray());
    }
}
