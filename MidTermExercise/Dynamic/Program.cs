﻿// Dynamic (CPU USage higher, Not safe)

class Program
{
    static void Main(){
        dynamic a = 3;
        Console.WriteLine(a);
        a = true;
        Console.WriteLine(a);
        a = new Car();
        Console.WriteLine(a);
        a.EngineRun();
        Console.WriteLine(a);
        a.StartEngine(); // This will be compiled successfully, but error later.
        Console.WriteLine(a);
    }
}

class Car
{
    public void EngineRun(){
    }
}