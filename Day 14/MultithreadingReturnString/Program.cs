class Program{


    static void Main()
    {   
        // Definition of a variable used to store the output of Method3
        string resultThread = string.Empty;

        // Using a lambda expression for the definition of a new Thread
        Thread thirdThread = new Thread(() => { resultThread = Method3(); });
    
        thirdThread.Start();

        // We need to use Join in order to take the parameter in output
        thirdThread.Join();
    
        Console.WriteLine($"The result of Method3 is: {resultThread}");
    }         
    static string Method3(){
        int result = 0;
        for (int i = 1; i < 5; i++){
            result += i;
            Thread.Sleep(400);
        }
        return $"The total is: {result}";
    }
}