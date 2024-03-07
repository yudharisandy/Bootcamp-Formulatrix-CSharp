using System.Security.Cryptography.X509Certificates;

public delegate void MyDelegate(int a, int b);
class Program
{
    static void Main(){
        MyDelegate del = Add;
        del += Mul;
        del += Sub;

        Thread t1 = new(() =>
            {
                del(10, 4));
            }
        // t1.Priority = ThreadPriority.Highest;
        t1.Start();
        t1.Join();


    }
    static void Add(int a, int b){
        System.Console.WriteLine(a + b);
    }
    static void Mul(int a, int b){
        System.Console.WriteLine(a * b);
    }
    static void Sub(int a, int b){
        System.Console.WriteLine(a - b);
    }
}