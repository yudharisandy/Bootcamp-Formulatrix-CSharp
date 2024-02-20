// Inheritance

using Animal;

class Program
{
    static void Main(){
        // Create instance for Cat()
        Cat cat = new Cat("red", "female", "kitten");
        cat.colour = "black";
        cat.gender = "female";
        // cat.name = "kitten";
        cat.Meow();
        Console.WriteLine(cat.name + '\n');

        // Create instance for Dog()
        Dog dog = new("red", "female");
        dog.colour = "orange";
        dog.gender = "male";
        dog.name = "the rock";
        dog.Bark();
        Console.WriteLine(dog.gender + '\n');

        // Create instance for Ant()
        Ant ant = new("red", "female");
        ant.colour = "black";
        ant.gender = "female";
        Console.WriteLine(ant.colour + '\n');

        // Change the attribute of instance
        Console.Write("before: " + cat.colour + ' ');
        cat.colour = "white";
        Console.Write("| after: " + cat.colour);
    }
} 