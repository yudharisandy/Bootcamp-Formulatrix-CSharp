//Composition and Class Folder Separating

using Vehicle;
using Kitchen;
using Automotive;

class Program
{
    static void Main(){
        // Composition
        Engine engine = new Engine(100, "Diesel", 2000, "Ferrari");
        Vehicle.Tire tire = new Vehicle.Tire("Type1", 19, "Good Wheel");
        Speed speed = new(100.0f);
        Car car = new Car("Ferrari", 2, "Red", 2, engine, tire, speed);

        //Print attributes
        tire.PrintAttribute(tire.tireType, tire.tireDiameter, tire.tireBrand);
        Console.WriteLine("------");
        car.PrintAttribute(car.brand, car.capacity, car.colour, car.numDoor);
        Console.WriteLine("------");
        engine.PrintAttribute(engine.engineHp, engine.engineType, engine.engineVolume, engine.engineBrand);

        Cake cake = new("Tepung");
    }
}