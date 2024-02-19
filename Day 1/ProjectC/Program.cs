
class Program
{
    static void Main()
    {
        Cat blacky = new Cat();
        blacky.colour = "Black";
        blacky.name = "Blacky";
        blacky.length = 180;
        blacky.isAlive = false;
        // call methods
        Console.WriteLine("--- " + blacky.name + " ---");
        Console.WriteLine(blacky.length);
        Console.WriteLine(blacky.isAlive);
        blacky.Walk();
        blacky.Sleep();
        blacky.healCat();
        Console.WriteLine(blacky.isAlive);

        Cat cattie = new Cat();
        cattie.colour = "White";
        cattie.name = "Cattie";
        cattie.length = 25;
        cattie.isAlive = true;
        // Call methods
        Console.WriteLine("--- " + cattie.name + " ---");
        Console.WriteLine(cattie.length);
        Console.WriteLine(cattie.colour);
        Console.WriteLine(cattie.isAlive);
        cattie.Run();
        cattie.Meow();
        cattie.addLength();
        
    }
}

class Cat
{
    public string name;
    public string colour;
    public int length;
    public bool isAlive;

    public void Run()
    {
        Console.WriteLine("Run");
    }
    public void Walk()
    {
        Console.WriteLine("Walk");
    }
    public void Meow()
    {
        Console.WriteLine("Meow");
    }
    public void Sleep()
    {
        Console.WriteLine("Sleep");
    }
    public void addLength()
    {
        length += 10;
        Console.WriteLine(length);
    }
    public void healCat()
    {
        isAlive = true;
        // Console.WriteLine(isAlive)
    }
}