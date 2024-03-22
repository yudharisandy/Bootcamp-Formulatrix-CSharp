// We have two concrete builder classes, GamingComputerBuilder and OfficeComputerBuilder, 
// each implementing the IComputerBuilder interface to construct different variations of 
// the Computer object.

// The ComputerManufacturer class serves as the director, managing the construction process
// for both gaming and office computers.

// In the Main method, we demonstrate constructing both a gaming computer and 
// an office computer using their respective builders.

// This approach provides a standardized pattern for managing the construction logic of 
// different variations of the Computer object, making it easier to add new variations 
// in the future and ensuring clear separation of concerns between the construction process 
// and the object itself.

class Program
{
    static void Main(string[] args)
    {
        // Build a gaming computer
        var gamingComputerBuilder = new GamingComputerBuilder();
        var gamingManufacturer = new ComputerManufacturer(gamingComputerBuilder);
        gamingManufacturer.AssembleComputer();
        var gamingComputer = gamingComputerBuilder.GetComputer();
        Console.WriteLine("Gaming Computer:");
        gamingComputer.Display();

        Console.WriteLine();

        // Build an office computer
        var officeComputerBuilder = new OfficeComputerBuilder();
        var officeManufacturer = new ComputerManufacturer(officeComputerBuilder);
        officeManufacturer.AssembleComputer();
        var officeComputer = officeComputerBuilder.GetComputer();
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

// Builder interface
public interface IComputerBuilder
{
    void BuildCPU();
    void BuildGPU();
    void BuildRAM();
    void BuildStorage();
    Computer GetComputer();
}

// Concrete builders
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

public class OfficeComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void BuildCPU()
    {
        _computer.CPU = "Intel Core i5";
    }

    public void BuildGPU()
    {
        _computer.GPU = "Integrated Intel Graphics";
    }

    public void BuildRAM()
    {
        _computer.RAM = "16GB DDR4";
    }

    public void BuildStorage()
    {
        _computer.Storage = "500GB SSD";
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