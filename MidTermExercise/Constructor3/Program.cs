class Program
{
    static void Main(){
        var cat = new Cat();
        cat.Eat();
        cat.Eat("Whiskas");
    }
}
public class Cat
{
    public string name;
    public string colour;
    public string gender;
    public void Eat(){
        Console.WriteLine("Cat eat");
    }
    // Method overloading : Same name but different paramater (for constructor or method)
    public void Eat(string food){
        Console.WriteLine($"Car eat {food}");
    }
}