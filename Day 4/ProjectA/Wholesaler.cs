namespace Agriculture;

public interface IAgriculture : IMarket, IFarmer;
public class Wholesaler : IAgriculture
{
    public void Buy(){
        System.Console.WriteLine("Customer buy");
    }
    public void SendFeedback(){
        System.Console.WriteLine("Customer send feedback");
    }
    public void OrganicFarming(){
        System.Console.WriteLine("Farmer do organic farming");
    }
    public void HireLocalLabour(){
        System.Console.WriteLine("Farmer hire local labour");
    }
}
