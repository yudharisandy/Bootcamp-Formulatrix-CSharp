// Garbage collection
using System.Text;
using System.Diagnostics;
class Program
{
    static void Main(){
        StringBuilder myString = new();
        int iteration = 10_000_000;
        Stopwatch sw = new();
        sw.Start();
        for (int i = 0; i < iteration; i++){
            myString.Append("a");
            myString.Append("b");
            myString.Append("c");
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
        Console.ReadLine();
    }
}