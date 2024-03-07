class Program
{
    static void Main(){
        Task t1 = new Task(() => {
            System.Console.WriteLine("T1");
            Thread.Sleep(6000);
            System.Console.WriteLine("T1 completed");
            });
        Task t2 = new Task(() => {
            System.Console.WriteLine("T2");
            Thread.Sleep(12000);
            System.Console.WriteLine("T2 completed");
            });
        t1.Start();
        t2.Start();

        System.Console.WriteLine("Running1");
        System.Console.WriteLine("Running2");

        t1.Wait(); // wait until this task completed to continue to the next lines of code
        System.Console.WriteLine("t1 done");
        t2.Wait(); // wait until this task completed to continue to the next lines of code
        
        System.Console.WriteLine("Test");
        // or we can run Task with this:
        Task.Run(() => System.Console.WriteLine("Task Run"));
    }
}