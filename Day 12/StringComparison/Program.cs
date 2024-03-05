// Garbage collection
using System.Diagnostics;
class Program{
    static void Main(){
        string myString = "";
        int iteration = 100_000;
        Stopwatch sw = new();
        sw.Start();
        for (int i = 0; i < iteration; i++){
            myString += "a";
            myString += "b";
            myString += "c";
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
        Console.ReadLine();
    }
}