// Anonymous method (lambda expression)

// Default delegate: Action delegate -> return type: void
// Default delegate: Func delegate -> return type: other

class Program
{
    static void Main(){
        // Ex: Method -> return type: float
        // Param: int, int
        // Collab with lambda expression (anonymous method)
        Func<int, int, float> myFunc = (int a, int b) => { return a * b; };
        myFunc.Invoke(3, 4).Dump();

        Action<string, bool> myAction = (string a, bool b) => { System.Console.WriteLine(a); };
        myAction += (string a, bool b) => { System.Console.WriteLine("invoked"); };
        myAction("abc", true);

        
    }
}
public static class Extension
{
    public static void Dump(this object x){
        System.Console.WriteLine(x);
    }
}
