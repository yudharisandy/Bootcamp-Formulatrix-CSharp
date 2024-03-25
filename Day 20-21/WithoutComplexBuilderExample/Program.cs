// Drawbacks:
// 1. Code Duplication: Configuration logic for creating different variations of 
//      the Computer object is repeated for each instance, leading to potential code duplication 
//      and maintenance overhead.
// 2. Limited Flexibility: Adding new variations or modifying existing ones can become cumbersome, 
//      as each change requires modifications to the creation logic within the Main method.
// 3. Lack of Separation of Concerns: Construction logic and object instantiation are 
//      tightly coupled within the Main method, potentially violating the principle of 
//      separation of concerns.

// Overall, while the builder pattern introduces additional classes and interfaces, 
// it offers a more structured and flexible approach to managing the construction of 
// complex objects with multiple variations.

class Program
{
    static void Main(string[] args)
    {
        // Create a gaming computer
        Computer gamingComputer = new Computer();
        gamingComputer.CPU = "Intel Core i9";
        gamingComputer.GPU = "NVIDIA GeForce RTX 3080";
        gamingComputer.RAM = "32GB DDR4";
        gamingComputer.Storage = "1TB NVMe SSD";

        Console.WriteLine("Gaming Computer:");
        gamingComputer.Display();

        Console.WriteLine();

        // Create an office computer
        Computer officeComputer = new Computer();
        officeComputer.CPU = "Intel Core i5";
        officeComputer.GPU = "Integrated Intel Graphics";
        officeComputer.RAM = "16GB DDR4";
        officeComputer.Storage = "500GB SSD";

        Console.WriteLine("Office Computer:");
        officeComputer.Display();
    }
}


// Product class
public class Computer
{
    public string CPU { get; set; }
    public string GPU { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }

    public void Display()
    {
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"GPU: {GPU}");
        Console.WriteLine($"RAM: {RAM}");
        Console.WriteLine($"Storage: {Storage}");
    }
}