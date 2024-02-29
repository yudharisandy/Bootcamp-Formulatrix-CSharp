class Program
{
    static void Main(){
        var cal = new Calculator();
        int a = 3;
        int b = 5;
        object result = cal.Add(a, b);
        Console.WriteLine(result);
    }
}
class Calculator
{
    public object Add(object obj1, object obj2){
        if(obj1 is int a && obj2 is int b){
            return a + b;
        }
        if(obj1 is string c && obj2 is string d){
            return c + d;
        }
        return false;
    }
}