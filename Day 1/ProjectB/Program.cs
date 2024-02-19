
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Dog kukil = new Dog();
        Dog botol = new Dog();
        Dog sisi= new Dog();

        kukil.name = "kukil";
        kukil.length = 12.5;
        kukil.isColorful = true;

        botol.name = "botol";
        botol.length = 15.9f;
        botol.isColorful = false;

        sisi.name = "sisi";
        sisi.length = 10.7;
        sisi.isColorful = true;

        kukil.PrintAttributes();
        botol.PrintAttributes();
        sisi.PrintAttributes();

        // kukil.AddLength(10);
        
    }
}


class Dog
{
    public string name;
    public double length;
    public bool isColorful;

    // Methods
    public void Walk()
    {
        Console.WriteLine("Walk");
    }
    public void Eat()
    {
        Console.WriteLine("Eat");
    }

    public void PrintAttributes()
    {
        Console.WriteLine(name);
        Console.WriteLine(length);
        Console.WriteLine(isColorful);
    }
}
