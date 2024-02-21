// Params: A way to parsing multiple parameters to a method

class Program
{
    static void Main(){
        Calculator.Add(2, 3, 5, 10).Dump();
    }
}

public static class Calculator
{
    public static int Add(params int[] numbers){
        int result = 0;
        // for(int i = 0; i < numbers.Length; i++){
        //     result += numbers[i];
        // }
        
        // Another option
        foreach(var i in numbers){
             result += i;
        }

        return result;
    }
    public static void Dump(this int a){
        Console.WriteLine(a);
    }
}