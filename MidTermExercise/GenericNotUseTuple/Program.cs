// Generic
class Program
{
    static void Main(){
        MyCollection<int, string> collection = new(10);
        collection.AddElement(3, "three");
        collection.AddElement(4, "four");

        var newData = collection.GetElement();
        Console.WriteLine(newData.data);
        Console.WriteLine(newData.data2);
    }
}
public class MyCollection<T, T2> // Generic
{
    private T[] _myArray;
    private T2[] _myArray2;
    private int _index = 0;
    public MyCollection(int count){
        _myArray = new T[count];
        _myArray2 = new T2[count];
    }
    public bool AddElement(T data, T2 data2){
        if(_index == _myArray2.Length - 1){
            return false;
        }
        _myArray[_index] = data;
        _myArray2[_index] = data2;
        _index++;
        return true;
    }
    public Data<T, T2> GetElement(){
        return new Data<T, T2>(_myArray[_index - 1], _myArray2[_index - 1]);
    }
}
public class Data<T, T2>
{
    public T data;
    public T2 data2;
    public Data(T data, T2 data2){
        this.data = data;
        this.data2 = data2;
    }
}