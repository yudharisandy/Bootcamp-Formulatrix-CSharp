// GetInvocationList() use case

public delegate int MyDelegate(int a, int b);
class Program
{
    static void Main() {
        Calculator calc = new();

        // Add methods to a delegate 
        MyDelegate delegates = calc.Add;
        delegates += calc.Div;
        delegates += calc.Mul;

        // In case of adding an already existing method to a delegate (like twice added)
        // We can validate the adding delegate step:
        Print(delegates.GetInvocationList().Contains(calc.Add));

        // This will call only the last method added to the delegate
        int result = delegates.Invoke(10, 5);
        Print(result);

        // Take each result from each method in our delegate:
        Delegate[] delegatesArray = delegates.GetInvocationList();
        int[] resultEachMethod = new int[delegatesArray.Length];
        int index = 0;
        foreach (MyDelegate methodInDelegate in delegatesArray){
            resultEachMethod[index] = methodInDelegate.Invoke(10, 5);
            index++;
        }
        // Retreive each resul in an array resulEachMethod
        foreach(int calculationResult in resultEachMethod){
            Print(calculationResult);
        }
    }
    static void Print<T>(T x){
        Console.WriteLine(x);
    }
}
public class Calculator
{
    public int Add(int a, int b){
        return a + b;
    }
    public int Div(int a, int b){
        return a / b;
    }
    public int Mul(int a, int b){
        return a * b;
    }
    public int Sub(int a, int b){
        return a - b;
    }
}
