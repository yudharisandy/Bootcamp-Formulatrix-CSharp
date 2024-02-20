namespace Animal;

public class Ant : Animal
{
    public Ant(string colour, string gender) : base(colour, gender) {
        Console.WriteLine("Ant was created!");
    }
}
