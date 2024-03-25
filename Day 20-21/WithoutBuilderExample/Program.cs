// [Without Implementing Builder]

class Program
{
    static void Main(string[] args)
    {
        // Without builder pattern, we directly instantiate the Computer object
        Computer computer = new Computer();

        // Set the properties manually
        computer.CPU = "Intel Core i9";
        computer.GPU = "NVIDIA GeForce RTX 3080";
        computer.RAM = "32GB DDR4";
        computer.Storage = "1TB NVMe SSD";

        // Display the computer details
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

