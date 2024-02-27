// Foobar program
// Input-Output example:
// input = 15: 0, 1, 2, foo, 4, bar, foo, 7, 8, foo, bar, 11, foo, 13, 14, foobar.
// input = 20: 0, 1, 2, foo, 4, bar, foo, 7, 8, foo, bar, 11, foo, 13, 14, foobar, 16, 17, foo, 19, bar.

using FoobarApp;
using ConsoleApps;

class Program
{
    static void Main(){
        // Create an instance of Foobar object
        Foobar foobar = new();
        ConsoleApp consoleApp = new();
        Data data = new(); // Input data to Dictionary
        
        // Need to be sorted by value from small to big
        data.InputData(3, "foo");
        data.InputData(5, "bar");
        data.InputData(7, "baz");
        // ... add your custom need here
        
        // Retreive and see the data
        Dictionary<int, string> dataBase = data.GetData();

        // Run the program until interrupted
        while (true){ 
            // Receive user's input
            int userInputInt = consoleApp.ReadUserInput();
            
            // Process the "foobar" algorithm
            string result = foobar.Process(userInputInt, dataBase);

            // Console App show the result
            consoleApp.ShowResult(result);
        }
    }
}


