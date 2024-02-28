// Abstract
    // Abstract <> override
    // Abstract class can't be instanciated
    
class Program
{
    static void Main(){
        // Animal animal = new(); // Error
        var dog = new Dog();
        dog.Walk();
        dog.Sound();
    }
}
abstract class Animal
{
    public string name;
    public string gender;
    public void Walk(){
        System.Console.WriteLine("walk");
    }
    public abstract void Sound(); // No implementation
}
class Dog : Animal
{
    public override void Sound(){
        System.Console.WriteLine("Dog Sound");
    }
}

public static class Extension
{
    public static void Dump(this object x){
        System.Console.WriteLine(x);
    }
}