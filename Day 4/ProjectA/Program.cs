// Property, Interface, Enum, Generic

using Agriculture;
using PublicPolicy;
using DataManagement;

class Program
{
    static void Main(string[] args)
    {
        // Print(args[0]);

        // Create instances
        Farmer farmer = new();
        Customer customer = new();
        Wholesaler wholesaler = new();
        var dataSystem = new Data<int, string>();

        Print($"Price from farmer: {farmer.Price}");
        
        // Enum example
        Government government = new();
        bool applePrice = government.CheckPrice(farmer.Price,
                                                HighestRetailPrice.Apple,
                                                (int)HighestRetailPrice.Apple);
        Print("---------------\n");

        if (applePrice == true)
        {
            // Apple's price negotiation between farmer and customer
            int customerProposePrice;
            int farmerNegotiatedPrice;
            int numNegotiation = 2;
            for (int i = 0; i < numNegotiation; i++)
            {
                customerProposePrice = customer.PriceNegotiate(farmer.Price);
                farmerNegotiatedPrice = farmer.PriceNegotiate(customerProposePrice);
                Print("---------------\n");
                if (i == (numNegotiation - 1))
                {
                    dataSystem.StoreData(farmerNegotiatedPrice, "Customer satisfied!");
                }
            }

        }
    }

    static void Print<T>(T x)
    {
        Console.WriteLine(x);
    }
}
