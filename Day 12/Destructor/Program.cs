// Destructor / Finalizer
using System.Diagnostics;
class Program
{
    static void Main(){
        int iteration = 1_000_000_000;
        Stopwatch sw = new();
        sw.Start();
        for (int i = 0; i < iteration; i++){
            InstanceCreator();
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
        // GC.Collect();

    }
    static void InstanceCreator(){
        Human human = new();
    }
}
public class Human
{
    // Constructor
    public Human(){
        // Console.WriteLine("Human created");
    }
    // Destructor
    ~Human(){
        // Console.WriteLine("Human eliminated"); 
        // 195ms (with destructor) vs 17ms (without destructor)
    }
}