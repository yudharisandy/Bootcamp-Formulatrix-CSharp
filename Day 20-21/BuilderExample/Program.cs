// [Implement Builder]
// Step-by-step:
// 1. Create an interface with methods that define the steps to create an object.
// 2. Create one or more classes that implement the interface.
// 3. Create a director class that uses the builder interface to create an object, but is unaware of the implementation details.
// 4. Use the director class to manage the construction process of the object.
// 5. Call the appropriate methods of the builder object in the director class to create the object.
// 6. When the object is fully constructed, call the appropriate method of the builder object to retrieve the object.


class Program
{
    static void Main(string[] args)
    {
        var gamingComputerBuilder = new GamingComputerBuilder();
        var manufacturer = new ComputerManufacturer(gamingComputerBuilder);
        manufacturer.AssembleComputer();
        var computer = gamingComputerBuilder.GetComputer();
        computer.Display();
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

// Builder interface
public interface IComputerBuilder
{
    void BuildCPU();
    void BuildGPU();
    void BuildRAM();
    void BuildStorage();
    Computer GetComputer();
}

// Concrete builder
public class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void BuildCPU()
    {
        _computer.CPU = "Intel Core i9";
    }

    public void BuildGPU()
    {
        _computer.GPU = "NVIDIA GeForce RTX 3080";
    }

    public void BuildRAM()
    {
        _computer.RAM = "32GB DDR4";
    }

    public void BuildStorage()
    {
        _computer.Storage = "1TB NVMe SSD";
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}

// Director class
public class ComputerManufacturer
{
    private readonly IComputerBuilder _builder;

    public ComputerManufacturer(IComputerBuilder builder)
    {
        _builder = builder;
    }

    public void AssembleComputer()
    {
        _builder.BuildCPU();
        _builder.BuildGPU();
        _builder.BuildRAM();
        _builder.BuildStorage();
    }
}