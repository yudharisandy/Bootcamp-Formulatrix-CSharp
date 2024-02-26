// Foobar program
// Input-Output example:
// input = 15: 0, 1, 2, foo, 4, bar, foo, 7, 8, foo, bar, 11, foo, 13, 14, foobar.
// input = 20: 0, 1, 2, foo, 4, bar, foo, 7, 8, foo, bar, 11, foo, 13, 14, foobar, 16, 17, foo, 19, bar.

using FoobarApp;

class Program
{
    static void Main(){
        // Create an instance of Foobar object
        Foobar foobar = new(3, 5); // Foo, bar

        // Run the program until interrupted
        while (true){ 
            // Receive user's input
            Console.Write("Input number: ");
            string userInput = Console.ReadLine();
            // Convert input string to int
            Int32.TryParse(userInput, out int userInputInt);
            
            // Calculate and show
            foobar.Calculate(userInputInt);
        }
    }
}


