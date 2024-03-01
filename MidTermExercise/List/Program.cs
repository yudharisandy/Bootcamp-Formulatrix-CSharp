class Program
{
    static void Main(){
        List<int> numbers = new List<int>();

        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        List<Car> cars = new List<Car>();
        
        Car car1 = new(10);
        Car car2 = new(20);

        cars.Add(car1);
        cars.Add(car2);

        foreach (var car in cars)
        {
            Console.WriteLine(car.hp);
        }

        int[] attribute = {1, 2, 3, 4};
        Console.WriteLine(attribute);

    }
}
class Car
{
    public int hp;
    public Car(int hp){
        this.hp = hp;
    }
}