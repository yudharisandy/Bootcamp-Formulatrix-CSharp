class Program {
    static void Main() {
        Task<int> task = new Task<int>(ReturnNine);
        task.Start();
        Console.WriteLine(task.Result);

        var task2 = new Task<string>(ReturnHello);
        task2.Start();
        System.Console.WriteLine(task2.Result);

        var task3 = new Task<Dictionary<string, int>>(ReturnDict);
        task3.Start();
        // System.Console.WriteLine(task3.Result);
        foreach(var i in task3.Result){
            System.Console.WriteLine($"Key value pair: {i.Key} : {i.Value}");
        }
    }
    static int ReturnNine() {
        return 9;
    }
    static string ReturnHello(){
        return "Hello";
    }
    static Dictionary<string, int> ReturnDict(){
        Dictionary<string, int> dict = new();
        dict.Add("Yanto", 32);
        return dict;
    }
    // static int Add
}