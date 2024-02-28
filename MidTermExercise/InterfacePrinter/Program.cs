class Program
{
    static void Main(){
        PrinterEpson printerEpson = new();
        IPrinter printer = printerEpson;
        IBluetooth bluetooth = printerEpson;
        IWireless wireless = printerEpson;

        printer.Print();
        printerEpson.Print();
    }
}
public interface IPrinter
{
    void Print(); // No implementation, no access modifier
    void Scan();
    void Fax();
}
public interface IBluetooth
{
    void BTConnect();
    void BTDisconnect();
}
public interface IWireless
{
    void Connect();
    void Disconnect();
}

public interface IPrinterEpson : IPrinter, IBluetooth, IWireless;
public class PrinterEpson600Juta : IPrinterEpson
{
    public void Print(){
        Console.WriteLine("Printer print");
    }
    public void Scan(){
        Console.WriteLine("Printer scan");
    }
    public void Fax(){
        Console.WriteLine("Printer fax");
    }
    public void BTConnect(){
        Console.WriteLine("Bluetooth connect");
    }
    public void BTDisconnect(){
        Console.WriteLine("Bluetooth disconnect");
    }
    public void Connect(){
        Console.WriteLine("Wireless connect");
    }
    public void Disconnect(){
        Console.WriteLine("Wireless disconnect");
    }    
}
public class PrinterEpson : IPrinterEpson
{
    public void Print(){
        Console.WriteLine("Printer print");
    }
    public void Scan(){
        Console.WriteLine("Printer scan");
    }
    public void Fax(){
        Console.WriteLine("Printer fax");
    }
    public void BTConnect(){
        Console.WriteLine("Bluetooth connect");
    }
    public void BTDisconnect(){
        Console.WriteLine("Bluetooth disconnect");
    }
    public void Connect(){
        Console.WriteLine("Wireless connect");
    }
    public void Disconnect(){
        Console.WriteLine("Wireless disconnect");
    }
}

public class Speaker : IBluetooth
{
    public void BTConnect(){

    }
    public void BTDisconnect(){

    }
}

public class EpsonDeviceWarehouse
{
    private IPrinterEpson[] _printer;
    public void AddPrinter(IPrinterEpson printer){

    }
}
public class BluetoothDeviceWarehouse
{
    private IBluetooth _bluetooth;
    public void AddBluetooth(IBluetooth bluetooth){

    }
}
public class WirelessDeviceWarehouse
{
    private IWireless[] _wireless;
    public void AddWireless(IWireless wireless){
        
    }

}