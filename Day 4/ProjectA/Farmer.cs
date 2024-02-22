namespace Agriculture;

public interface IFarmer
{
    void OrganicFarming();
    void HireLocalLabour();
}

class Farmer : IFarmer
{
    public int price = 1000;
    private int _profitMargin = 500;
    private int _minimumSellPrice = 1400;
    public int Price {
        get {
            return price + _profitMargin;
        }
        private set{
            price = value;
        }
    }
    public void OrganicFarming(){
        System.Console.WriteLine("Farmer: Do organic farming");
    }
    public void HireLocalLabour(){
        System.Console.WriteLine("Farmer: Hire local labour");
    }
    public int PriceNegotiate(int customerProposePrice){
        // bool satisfiedStatus = true;
        if (customerProposePrice >= _minimumSellPrice){
            // Customer proposal accepted
            Price = customerProposePrice - _profitMargin; // subtract with _margin since customer price includes the _margin already
            Console.WriteLine("Farmer: Negotiation approved!");
            Console.WriteLine($"Farmer: Agree a new price of {Price}");
            // satisfiedStatus = true;
            return customerProposePrice;
        }
        else{
            // Customer proposal rejected
            Console.WriteLine("Farmer: Negotiation rejected!");
            Console.WriteLine($"Farmer: Set the previous price of {Price}");
            // satisfiedStatus = false;
            return Price;
        }
    }
     
}
