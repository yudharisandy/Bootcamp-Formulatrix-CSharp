// Encapsulation
// Access modifier (public, private, protected, internal)

class Program
{
    static void Main(){
        Animal animal = new("Yellow", "male");
        Console.WriteLine(animal.GetColour());
        Console.WriteLine(animal.GetGender());

        Cat cat = new Cat("Black", "female");
        Console.WriteLine(cat.GetColour());
        Console.WriteLine(cat.GetGender());

        // Console.WriteLine()

    }
}

class Animal
{
    private string colour;
    private string gender;

    // Constructor
    public Animal(string colour, string gender){
        this.colour = colour;
        this.gender = gender;
    }

    // Return colour (a private parameter)
    public string GetColour(){
        return colour;
    }
    public string GetGender(){
        return gender;
    }
}

class Cat : Animal
{
    public Cat(string colour, string gender) : base(colour, gender){
    }
}
