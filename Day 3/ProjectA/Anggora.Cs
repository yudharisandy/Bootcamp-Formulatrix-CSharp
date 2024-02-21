namespace Animals;

public class Anggora : Cat
{
    public new void Sound(){ // method hiding -> as Anggora(Anggora Sound) | an Animal(Meow)
        Console.WriteLine("Anggora Sound");
    }
}
