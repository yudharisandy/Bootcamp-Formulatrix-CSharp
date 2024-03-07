class Program {
    static void Main() {
        Task task = Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("+");
                Thread.Sleep(5);
            }
            System.Console.WriteLine();
        });
        Console.WriteLine(task.IsCompleted); // false
        Console.WriteLine(task.IsCanceled); // false
        Console.WriteLine(task.IsFaulted); // false
        
        Task.WaitAll(task);

        Console.WriteLine(task.IsCompleted); // ture
        Console.WriteLine(task.IsCanceled); // false
        Console.WriteLine(task.IsFaulted); // false

    }
}