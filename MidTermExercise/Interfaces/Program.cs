// Interface
    // An interface defines a contract.
    // Any class, record or struct that implements 
    // that contract must provide an implementation of the members defined in the interface.
    // Interface isn't a class  -> can only be assigned to another class.
    // Methods in interface have no implementation.
    // in methods declaration, no need to add access modifiers.
    // Implementation: First create an instance of implementation class -> each interface class can be created based on that.
    // References: 
        // https://github.com/kinarajv/Batch-9/blob/main/Interfaces/Program.cs
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface

class Program
{
    static void Main(){
        // IBluetooth bl = new(); // Error
        Device device = new();
        IBluetooth bluetooth = device;
        IWireless wireless = device;

        bluetooth.Connect();
        wireless.Connect();
    }
}


public interface IBluetooth
{
    void Connect();
    void Disconnect(); 
}
public interface IWireless
{
    void Connect();
    void Disconnect();
}
// Implement interface to a single class
public class Device : IBluetooth, IWireless
{
    void IBluetooth.Connect(){
        System.Console.WriteLine("Bluetooth connect");
    }
    void IBluetooth.Disconnect(){

    }
    void IWireless.Connect(){
        System.Console.WriteLine("Wireless disconnect");
    }
    void IWireless.Disconnect(){

    }
}