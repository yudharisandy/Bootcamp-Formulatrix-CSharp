// Generic
// Generic constraint (keyword: where T)
class Program
{
    static void Main(){
        var myCollection = new MyCollection<int>(20);
        myCollection.AddElement(12);
        myCollection.AddElement(100);
        myCollection.GetArray();
    }
}
class MyCollection<T>{
    private T[] myArray;
    private int index = 0;
    public MyCollection(int count){
        myArray = new T[count];
    }
    public bool AddElement(T data){
        if (index == myArray.Length -1 ){
            return false;
        }
        myArray[index] = data;
        index++;
        return true;
    }
    public void GetArray(){
        foreach (T val in myArray){
            System.Console.WriteLine(val);
        }
    }
}