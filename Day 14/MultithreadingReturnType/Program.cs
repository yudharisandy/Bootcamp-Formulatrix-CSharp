class Program{


    static void Main()
    {   
        // Definition of a variable used to store the output of Method3
        string resultThread = string.Empty;
        Console.WriteLine($"The initial resultThread: {resultThread}");

        // Using a lambda expression for the definition of a new Thread
        Thread thirdThread = new Thread(() => { resultThread = Add(2, 3); });
    
        thirdThread.Start();

        // We need to use Join in order to take the parameter in output
        thirdThread.Join();
        
        // Convert string to int
        int number;
        bool status = int.TryParse(resultThread, out number);
        System.Console.WriteLine(number);
        
        Console.WriteLine($"The result of Method3 is: {resultThread}");
    }         
    static string Add(int a, int b){
        int result = a + b;
        return $"{result}";
    }
}