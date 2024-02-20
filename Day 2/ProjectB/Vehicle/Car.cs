using Automotive;

namespace Vehicle;
class Car
{
    //Car
    public string brand;
    public int capacity;
    public string colour;
    public int numDoor;
    public Engine engine;
    public Tire tire;
    public Speed speed;
    //Constructor (all parameters are compulsory)
    public Car(
                string brand,
                int capacity,
                string colour,
                int numDoor,
                Engine engine,
                Tire tire,
                Speed speed)
    {
        this.brand = brand;
        this.capacity = capacity;
        this.colour = colour;
        this.numDoor = numDoor;
        this.engine = engine;
        this.tire = tire;
        this.speed = speed;
    }

    public void PrintAttribute(string brand, int capacity, string colour, int numDoor){
        Console.WriteLine($"Car brand       : {brand}");
        Console.WriteLine($"Car capacity    : {capacity}");
        Console.WriteLine($"Car colour      : {colour}");
        Console.WriteLine($"Car door number : {numDoor}");
    }
}