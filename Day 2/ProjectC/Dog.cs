namespace Animal;

public class Dog : Animal
{
    public string name;
    public Dog(string colour, string gender) : base(colour, gender) {
        Console.WriteLine("Dog was created");
    }
    public void Bark(){
        Console.WriteLine("Dog bark");
    }
}
