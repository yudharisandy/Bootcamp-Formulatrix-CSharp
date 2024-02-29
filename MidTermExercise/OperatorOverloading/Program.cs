// Operator overloading
class Program
{
    static void Main(){
        Car carA = new(1000);
        Car carB = new(2000);
        Car carC = carA + carB;
        Console.WriteLine(carC.price);
        Car carD = carA + 10000;
        Console.WriteLine(carD.price);
    }
}
class Car
{
    public int price;
    public Car(int price){
        this.price = price;
    }
    // Operator overloading
    public static Car operator +(Car a, Car b){
        int newPrice = a.price + b.price;
        return new Car(newPrice);
    }
    public static Car operator -(Car a, Car b){
        int newPrice = a.price - b.price;
        return new Car(newPrice);
    }
    public static Car operator +(Car a, int b){
        int newPrice = a.price + b;
        return new Car(newPrice);
    }
}