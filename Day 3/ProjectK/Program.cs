// Abstraction

class Program
{
    static void Main(){
        Child child = new Child();
        child.Sing();
    }
}

public class GrandParent
{
    public virtual void Sing(){
        Console.WriteLine("Jazz");
    }
}

public class Parent : GrandParent
{
    public override void Sing(){
        // base.Sing();
        Console.WriteLine("Rock");
    }
}
public class Child : Parent
{
    public override void Sing(){
        // base.Sing();
        Console.WriteLine("Pop");
    }
}
