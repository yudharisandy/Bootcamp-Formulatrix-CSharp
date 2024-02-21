namespace Animals;

public class Animal
{
    public string gender;
    public string colour;
    public string name;

    public void Walk(){
        Console.WriteLine("Walk");
    }
    public void Breath(){
        Console.WriteLine("Breath");
    }
    public virtual void Sound(){
        Console.WriteLine("Animal Make Sound");
    }
}