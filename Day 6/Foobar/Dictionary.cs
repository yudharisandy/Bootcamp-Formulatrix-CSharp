namespace FoobarApp;

public class Data
{
    private Dictionary<int, string> _dict = new();
    // Constructor
    public Data(){
        // Automatically create dict when Data is created.
        Dictionary<int, string> _dict = new();
    }
    public void InputData(int key, string value){
        _dict.Add(key, value);
    }
    public Dictionary<int, string> GetData(){
        return _dict;
    }
    
}
