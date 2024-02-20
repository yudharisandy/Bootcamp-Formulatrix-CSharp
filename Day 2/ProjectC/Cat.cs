namespace Animal;

public class Cat : Animal
{
    public string name;
    public Cat(string colour, string gender, string name): base(colour, gender) {
        Console.WriteLine("Cat was created!");
        this.name = name;
    }

    public void Meow(){
        Console.WriteLine("Cat Meow");
    }
}
