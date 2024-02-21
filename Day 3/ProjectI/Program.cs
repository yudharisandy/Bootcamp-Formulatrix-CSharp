// Abstraction
// Child take the parent method = Compulsory (using "abstract")
// asbtract: ada keinginan yang belum terpenuhi

class Program
{
    static void Main()
    {
        Cat cat = new Cat();
        cat.Sound();
    }
}
abstract class Animal
{
    public string name;
    public string gender;
    // non abstract
    public void Walk(){
        Console.WriteLine("Walk");
    }
    // abstract <> override
    public abstract void Sound();
}

class Cat : Animal 
{
    public override void Sound()
    {
        Console.WriteLine("Meow");
    }
}