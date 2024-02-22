namespace DataManagement;

public class Data<T1, T2>
{
    public T1 price;
    public T2 feedback; 
     
    public void StoreData(T1 price, T2 feedback){
        Console.WriteLine($"System save: {price} and {feedback}");
    }
}
