using System.Diagnostics;
using System.Net.WebSockets;

class Program {
    static async Task Main() {
        Stopwatch stopwatch = new();
        
        stopwatch.Start();
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 1
        ThreadExecution();
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 1
        stopwatch.Stop();
        Console.WriteLine("Thread : " + stopwatch.ElapsedTicks);

        stopwatch.Reset();
        stopwatch.Start();
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 1
        TaskExecution();
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 1
        stopwatch.Stop();
        Console.WriteLine("TASK : " + stopwatch.ElapsedTicks);

        stopwatch.Reset();
        stopwatch.Start();
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 1
        await TaskAsyncAwait();
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // Random ( != 1)
        stopwatch.Stop();
        Console.WriteLine("Async : " + stopwatch.ElapsedTicks);

    }
    static void ThreadExecution() {
        Thread[] threads = new Thread[100];
        for(int i = 0; i < threads.Length; i++) {
            threads[i] = new Thread(() => Execution());
            threads[i].Start();
        }
        foreach(var i in threads) {
            i.Join();
        }
    }
    static void TaskExecution() {
        Task[] allTasks = new Task[100];
        for(int i = 0; i < allTasks.Length; i++) {
            allTasks[i] = new Task(() => Execution());
            allTasks[i].Start();
        }
        Task.WaitAll(allTasks);
    }
    static async Task TaskAsyncAwait() {
        Task[] allTasks = new Task[100];
        for(int i = 0; i < allTasks.Length; i++) {
            allTasks[i] = new Task(() => Execution());
            allTasks[i].Start();
        }
        await Task.WhenAll(allTasks);
    }
    static void Execution() {
        int iteration = 1000;
        for(int i = 0; i<iteration;i++) {

        }
    }
}