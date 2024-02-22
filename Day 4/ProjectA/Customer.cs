namespace Agriculture;

public interface IMarket
{
    void Buy();
    void SendFeedback();
}

public class Customer : IMarket
{
    private const int _negotiationNum = 50;
    public void Buy(){
        System.Console.WriteLine("Customer: Buy the fruit");
    }
    public void SendFeedback(){
        System.Console.WriteLine("Customer: Send feedback");
    }
    public int PriceNegotiate(int price){
        int newPrice = price - _negotiationNum;
        Console.WriteLine($"Customer: Propose a new price of {newPrice}");
        return newPrice;
    }
    
}

