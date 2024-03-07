class Program {
    static void Main() {

        //Thread is foreground by default
        Console.WriteLine("Program started");
        Console.WriteLine($"Main thread: {Thread.CurrentThread.ManagedThreadId}");

        Task task1 = new Task(Printer1); // Printer1
        task1.Start();

        Task task3 = Task.Run(() => Printer3());
        Task task4 = Task.Run(() => Printer4());
        Task task2 = Task.Run(() => Printer2()); // Printer2

        Task[] tasks = {task1, task2, task3, task4};
        Task.WhenAll(tasks);
        
        Console.WriteLine("Program finished");
    }
    static void Printer1() {
        Console.WriteLine($"Printer1 thread: {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine("Printer 1");
        // for(int i = 0; i < 100; i++) {
        //     Console.Write("+");
        // }
    }
    static void Printer2() {
        Console.WriteLine($"Printer2 thread: {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine("Printer2");
        // for(int i = 0; i < 100; i++) {
        //     Console.Write("-");
        // }
    }
    static void Printer3() {
        Console.WriteLine($"Printer3 thread: {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine("Printer3");
        // for(int i = 0; i < 100; i++) {
        //     Console.Write("/");
        // }
    }
    static void Printer4() {
        Console.WriteLine($"Printer4 thread: {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine("Printer4");
        // for(int i = 0; i < 100; i++) {
        //     Console.Write("?");
        // }
    }
}