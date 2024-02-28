// Delegate
// Example:
    // Method: return type = void
    // Param: string

public delegate void MyDelegate(string s);

class Program
{
    static void Main(){
        Subscriber sub = new();
        
        // Assign methods to delegate
        MyDelegate delegates = sub.Notification;
        delegates += sub.Inform;

        // Run the delegates
        delegates.Invoke("Message");
        // delegates("Message");

        // .NET already have default implementation of delegate
        // public delegate void Action<T>(T Parameter)
        // public delegate void Action<T, T1>(T parameter1, T1 parameter2)
        Action<string> del2 = sub.Notification;
        del2 += sub.Inform;
        del2.Invoke("Anything");

        Action<int, int> del3 = sub.Add;
        del3.Invoke(2, 3);

        int a = 3;
        int b = a;
        int c = b + 2;
        System.Console.WriteLine(c);


    }
}
public class Subscriber
{
    public void Notification(string s){
        System.Console.WriteLine(s);
    }
    public void Inform(string s){
        System.Console.WriteLine(s + "inform");
    }
    public void Add(int a, int b){
        System.Console.WriteLine(a + b);
    }
}