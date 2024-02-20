namespace Animal;

public class Animal
{
    public string colour;
    public string gender;

    public Animal(string colour, string gender){
        Console.WriteLine("Animal was created!");
    }

    public void Walk(){
        Console.WriteLine("Animal walks");
    }
    public void Breath(){
        Console.WriteLine("Animal breaths");
    }
}
