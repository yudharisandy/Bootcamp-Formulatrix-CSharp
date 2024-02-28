// Array readonly

// Array can't be changed with other array
// But, the element in the array could be changed.

class Program
{
    static void Main()
    {
        var car = new Car();
        car.price[0].Dump();
        car.price[0] = 100; // We can change the element value 
        car.price[0].Dump();

        for(var i = 0; i < car.price.Length; i++){
            car.price[i].Dump();
        }

        int[] newPrice = { 5, 6, 7, 8};
        // car.price = newPrice; // Error since our array is readonly-type
    }
}
class Car
{
    public readonly int[] price = {1, 2, 3, 4};
}

public static class Extension
{
    public static void Dump(this object x){
        System.Console.WriteLine(x);
    }
}