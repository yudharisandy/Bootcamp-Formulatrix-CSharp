class Program
{
    static void Main(){
        InstanceCreator();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine("Wait for the next order");
    }
    static void InstanceCreator(){
        Child child = new();
    }
}
public class GrandParent
{
    // Destructor
    ~GrandParent(){
        Console.WriteLine("GrandParent eliminated");
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
}
public class Parent : GrandParent
{
    // Destructor
    ~Parent(){
        Console.WriteLine("Parent eliminated");
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
}
public class Child : Parent
{
    // Destructor
    ~Child(){
        Console.WriteLine("Child eliminated");
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
}