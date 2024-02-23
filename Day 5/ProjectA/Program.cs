// Value and reference type
class Program
{
    static void Main(){
        // Value type
        int data = 10;
        Add(data); // When parse the data into Add(), only value will be copied.
        Print(data);

        // Referene type
        Car car = new Car();
        car.gasoline = 100;
        car.AddFuel(car); // When parse the data into .AddFuel, the address will be copied.
        Print(car.gasoline);
    }
    static void Add(int data){
        data++;
    }
    static void Print<T>(T data){
        Console.WriteLine(data);
    }
}

class Car
{
    public int gasoline;
    public void AddFuel(Car car){
        car.gasoline += 20;
    }
}
