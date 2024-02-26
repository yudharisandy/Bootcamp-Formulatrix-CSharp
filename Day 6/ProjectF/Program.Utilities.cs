namespace MainProgram;

public partial class Program
{
    // Common display method
    static void Print<T>(T a){
        Console.WriteLine(a);
    }
    static void DisplaySet(HashSet<int> collection)
    {
        Console.Write("{");
        foreach (int i in collection)
        {
            Console.Write(" {0}", i);
        }
        Console.WriteLine(" }");
    }
    private static void Display(LinkedList<string> collection)
    {
        foreach (string i in collection)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}