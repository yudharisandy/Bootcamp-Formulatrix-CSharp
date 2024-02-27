namespace ConsoleApps;

public class ConsoleApp
{
    public int ReadUserInput(){
        // Receive user's input
        Console.Write("Input number: ");
        string userInput = Console.ReadLine();
        
        // Convert input string to int
        Int32.TryParse(userInput, out int userInputInt);

        return userInputInt;
    }
    public void ShowResult(string result){
        Console.WriteLine(result);
    }
    

}
