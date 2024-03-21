// [Without Implementing Builder]

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car(697, "Gasoline", 6498);
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
    public Car(int engineHp, string fuelType, int engineVolume){
        EngineHp = engineHp;
        FuelType = fuelType;
        EngineVolume = engineVolume;
    }

    public void Display()
    {
        Console.WriteLine($"Engine HP: {EngineHp}");
        Console.WriteLine($"Fuel Type: {FuelType}");
        Console.WriteLine($"Engine Volume: {EngineVolume}");
    }
}
