// Default delegate: Func -> with return type

// Manual delegate
public delegate int MyDelegate(int a, int b);

class Program
{
    static void Main(){
        var sub = new Subscriber();

        MyDelegate del = sub.Add;
        del += sub.Mul;
        del.Invoke(3, 4).Dump();

        // Default delegate: public delegate T2 Func<T, T1, T2>(T param1, T1 param2);
        Func<int, int, int> delFunc = sub.Add;
        var action = sub.Add; // Automatically be type of Func<int, int, int>
        delFunc?.Invoke(3, 4).Dump(); // ? avoid null condition, if null -> don't run the code
        action?.Invoke(3, 4).Dump();
    }
}
public class Subscriber
{
    public int Add(int a, int b){
        return a + b;
    }
    public int Mul(int a, int b){
        return a * b;
    }
}
public static class Extension
{
    public static void Dump(this object x){
        Console.WriteLine(x);
    }
}