// Generic + Tuple

class Program
{
    static void Main(){
        var collection = new MyCollection<int, string>(10);
        collection.AddElement(10, "Ten");
        collection.AddElement(11, "Eleven");
        (int, string) myTuple = collection.GetElement();
        Console.WriteLine(myTuple.Item1); // 11
        Console.WriteLine(myTuple.Item2); // "Eleven"
    }
}
public class MyCollection<T, T2>
{
    private T[] _myArray;
    private T2[] _myArray2;
    private int _index = 0;
    // COnstructor
    public MyCollection(int count){
        _myArray = new T[count];
        _myArray2 = new T2[count];
    }
    public bool AddElement(T data, T2 data2){
        if(_index == _myArray.Length - 1){
            return false;
        }
        _myArray[_index] = data;
        _myArray2[_index] = data2;
        _index++;
        return true;
    }
    // Return tuple
    public (T, T2) GetElement(){
        return (_myArray[_index - 1], _myArray2[_index - 1]);
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