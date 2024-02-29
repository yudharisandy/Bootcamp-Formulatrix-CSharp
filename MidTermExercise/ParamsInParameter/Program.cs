// Params

class Program
{
    static void Main(){
        int[] myArray = {1, 2, 3};
        int result = Calculator.Add(3, 4, 5); // No need to make instance, since it is a extension method
        result.Dump();
    }
}
// Extension method
public static class Calculator
{
    public static int Add(params int[] numbers){
        int result = 0;
        foreach(var number in numbers){
            result += number;
        }
        return result;
    }
}
public static class Extension
{
    public static void Dump(this object a){
        Console.WriteLine(a);
    }
}
