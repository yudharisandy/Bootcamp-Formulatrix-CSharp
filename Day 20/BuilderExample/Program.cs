// [Implement Builder]
// Step-by-step:
// 1. Create an interface with methods that define the steps to create an object.
// 2. Create one or more classes that implement the interface.
// 3. Create a director class that uses the builder interface to create an object, but is unaware of the implementation details.
// 4. Use the director class to manage the construction process of the object.
// 5. Call the appropriate methods of the builder object in the director class to create the object.
// 6. When the object is fully constructed, call the appropriate method of the builder object to retrieve the object.

class Program
{
    static void Main(string[] args)
    {
        var sportCarBuilder = new SportCarBuilder();
        var carMaker = new CarMaker(sportCarBuilder);
        carMaker.MakeCar();
        var car = sportCarBuilder.GetCar();
        car.Display();

    }
}

// Product class
public class Car
{
    public int EngineHp { get; set; }
    public string FuelType { get; set; }
    public int EngineVolume { get; set; }

    // public List<string> Toppings { get; set; } = new List<string>();

    public void Display()
    {
        Console.WriteLine($"Engine HP: {EngineHp}");
        Console.WriteLine($"Fuel Type: {FuelType}");
        Console.WriteLine($"Engine Volume: {EngineVolume}");
    }
}

// Builder interface
public interface ICarBuilder
{
    void AddEngineHP(int engineHp);
    void AddFuelType(string fuelType);
    void AddEngineVolume(int engineVolume);
    Car GetCar();
}

// Concrete builder
public class SportCarBuilder : ICarBuilder
{
    private Car _car = new Car();

    public void AddEngineHP(int engineHp)
    {
        _car.EngineHp = engineHp;
    }

    public void AddFuelType(string fuelType)
    {
        _car.FuelType = fuelType;
    }

    public void AddEngineVolume(int engineVolume)
    {
        _car.EngineVolume = engineVolume;
    }

    public Car GetCar()
    {
        return _car;
    }
}

// Director class
public class CarMaker
{
    private readonly ICarBuilder _builder;

    public CarMaker(ICarBuilder builder)
    {
        _builder = builder;
    }

    public void MakeCar()
    {
        _builder.AddEngineHP(769);
        _builder.AddFuelType("Gasoline");
        _builder.AddEngineVolume(6498);
    }
}