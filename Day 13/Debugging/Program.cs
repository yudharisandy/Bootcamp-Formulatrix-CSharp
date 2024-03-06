class Program
{
    static void Main(){
        int a = 2;
        int b = 3;
        Calculator calc = new();
        int result = calc.AddFactorial(a, b);
        Console.WriteLine(result);
    }
}
public class Calculator
{
    public int AddFactorial(int a, int b){
        Additional add = new();
        int valueA = 1;
        for (int i = 1; i<= a; i++){
            valueA *= i;
        }
        int valueB = 1;
        for (int i = 1; i <= b; i++){
            valueB *= i;
        }
        int result = add.Add(valueA, valueB);
        return result;
    }
}
public class Additional
{
    public int Add(int a, int b){
        return a + b;
    }
}