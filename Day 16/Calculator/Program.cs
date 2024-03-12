// XML Documentation


class Program
{
    static void Main(){
        Calculator calc = new();
        int result = calc.Add(1, 2);
        System.Console.WriteLine(result);
    }
}
/// <summary>
/// The class  something
/// </summary>
public class Calculator
{
    /// <summary>
    /// Adding two integer values
    /// </summary>
    /// <param name="a">First integer</param>
    /// <param name="b">Second integer</param>
    /// <returns>an integer of result</returns>
    public int Add(int a, int b){
        return a + b;
    }
    public int Sub(int a, int b){
        
        return a - b;
    }
}