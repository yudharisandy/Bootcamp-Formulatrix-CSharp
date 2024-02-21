// Args in command line when running the code
class Program
{
    static void Main(string[] args){
        // dotnet run "test" "train"
        Console.WriteLine(args[0]);
        Console.WriteLine(args[1]);
    }
}
