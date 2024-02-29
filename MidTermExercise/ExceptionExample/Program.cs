class Program
{
    static void Main(){
        // Format exception
        // string a = "39a";
        // int aInt = int.Parse(a);

        // IndexOutOfRangeException
        // int[] myArray = {1, 2, 3};
        // Console.WriteLine(myArray[3]);

        // StackOverFlowException
        // Run();

        // NullReferenceException
        string[] myString = null;
        Console.WriteLine(myString.Length);
    }
    static void Run(){
        Run();
    }
}