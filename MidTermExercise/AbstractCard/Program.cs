// Abstract: 
    // An abstract class is a class that cannot be instantiated. 
    // Instead, it serves as a base class for other classes to inherit from.
    // The abstract modifier can be used with classes, methods, properties, indexers, and events.
    // Use the abstract modifier in a method or property declaration to indicate 
    // that the method or property does not contain implementation.
    // Reference: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract

// Implementation
class Program
{
    static void Main(){
        Car car = new();
        car.Go();
        car.Walk();
        Console.WriteLine(car.Capacity);
        Console.WriteLine(car.Fuel);

        // Vehicle veh = new(); // Error
    }
}
public abstract class Vehicle // Can't be instanciated
{
    protected int _capacity = 1;
    protected string _fuel = "gasoline";
    public abstract void Go(); // Abstract method have no implementation

    public abstract int Capacity { get; }
    public abstract string Fuel { get; }
}

public class Car : Vehicle
{
    public override void Go(){ // Mandatory to add "override"
        Console.WriteLine("Go");
    }
    public void Walk(){
        Console.WriteLine("Walk");
    }
    public override int Capacity {
        get{
            return _capacity;
        }
    }
    public override string Fuel{
        get{
            return _fuel;
        }
    }
}
