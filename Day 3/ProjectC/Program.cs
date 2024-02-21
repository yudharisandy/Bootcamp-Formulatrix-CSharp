// Boxing & Unboxing
// Virtual override and object

class Program
{
    static void Main(){
        // int a = 3;
        // object obj = a; // Boxing
        // int result = (int) obj; // Unboxing
        // Console.WriteLine(a);
        // Console.WriteLine(obj);

        Calculator calc = new Calculator();
        int a = 2;
        int b = 3;
        int result = (int)calc.Add(a, b);
        Console.WriteLine(result);
    }
}

class Calculator
{
    public object Add(object obj1, object obj2){ // Boxing
        if(obj1 is int && obj2 is int){
            return (int)obj1 + (int)obj2; // Unboxing
        }
        if(obj1 is string && obj2 is string){
            return (string)obj1 + (string)obj2; // Unboxing
        }
        return null;
    }
}
