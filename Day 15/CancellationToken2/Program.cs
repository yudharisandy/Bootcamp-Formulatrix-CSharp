class Program
{
    static void Main(){
        CancellationTokenSource cts = new();
        CancellationToken token = cts.Token;

        Task task1 = Task.Run(() => DoPrintJob(token));
        Task task2 = Task.Run(() => UserInputCheck(cts));

        Task.WaitAll(task1, task2);

        System.Console.WriteLine("Program completed!");

    }
    static async Task DoPrintJob(CancellationToken token){
        for(int i = 0; i < 100; i++){
            System.Console.WriteLine(i);
            await Task.Delay(100);
            if (token.IsCancellationRequested){
                return;
            }
        }
    }
    static void UserInputCheck(CancellationTokenSource cts){
        var result = Console.ReadKey();
        if (result.KeyChar == ' '){
            cts.Cancel();
            System.Console.WriteLine("Print cancelled!");
        }
    }
}