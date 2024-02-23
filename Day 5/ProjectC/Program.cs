// Error: Compile, Runtime (exception), Logic
    // Exception example:
        // FormatException : Wrong format.
        // IndexOutOfRange Exception : array access more than the elemen number
        // StackOverFlow Exception: recursive error
        // NullReference Exception: null variable is later called 
    // try-catch: A method to still run the whole code eventhough there is exception
        // Can define specific exception
        // Can create more than 1 catch method with specific exception errors.
        // Can add the general "Exception", but make sure it puts in the last catch
        // In production: don't use trt-catch too often, it consumes much memories.
    // Exception handling: Can add validation step before the Exception possibility can happen (if-else)

class Program
{
    static void Main(string[] args)
    {

        // Example: FormatException error
        string userInput = "20000"; // Set a default value in case there is no args[0] -> No error
        try
        {
            userInput = args[0];
        }
        catch { }
        // string userInput = "20.000"; // Will raise a FormatException Error
        int userInputInt = int.Parse(userInput);
        Print(userInputInt);

        // Example: IndexOutOfRangeException Error
        int[] myArray = { 10, 20, 30, 40 };
        Print(myArray[3]); // No error
        // Print(myArray[4]); // Will raise an IndexOutOfRangeException Error

        // Example: StackOverflowException Error
        // RecursiceMethod(); // Will raise a StackOverflowException error, since it is recursived.

        // Example: NullReferenceException
        string[] nullVariable = { "I", "You", "We" }; // No error
        // string[] nullVariable = null; // Will raise a NullReferenceException Error
        Print(nullVariable.Length);

        //-------------Exception Handling-------------
        // Try-catch
        try
        {
            // FormatExceptionMethod();
            int result = IndexOutOfRangeExceptionMethod(10);
        }
        catch (FormatException exception)
        { // Specify the type of exception -> FormatException
            Print($"FormatException Error happens: {exception.Message}");
        }
        catch (IndexOutOfRangeException exception)
        { // Specify the type of exception -> IndexOutOfRangeException
            Print($"IndexOutOfRangeException Error happens: {exception.Message}");
        }
        catch (Exception exception)
        { // Generalize all types of exception
            Print($"Exception error happens: {exception.Message}");
        }

        Print("Program is completed!");

    }
    static void RecursiceMethod()
    {
        RecursiceMethod();
    }
    static void FormatExceptionMethod()
    {
        // string userInput = "20000"; // No error
        string userInput = "20.000"; // Will raise a FormatException Error
        int userInputInt = int.Parse(userInput);
        Print(userInputInt);
    }
    static int IndexOutOfRangeExceptionMethod(int index)
    {
        int[] myArray = { 10, 20, 30, 40 };
        // Print(myArray[3]); // No error
        // Exception handling: Add a validation step:
        if (index > myArray.Length - 1)
        {
            Print($"Index not found: Exceed the number of array's elements!");
            return 0;
        }
        Print(myArray[index]); // Will raise an IndexOutOfRangeException Error
        return myArray[index];
    }
    static void Print<T>(T x)
    {
        Console.WriteLine(x);
    }
}