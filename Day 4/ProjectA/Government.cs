using Agriculture;

namespace PublicPolicy;
public class Government
{
    public bool CheckPrice(int fruitPrice,
                            HighestRetailPrice fruitName,
                            int fruitHighestRetailPrice)
    {
        if (fruitPrice <= fruitHighestRetailPrice)
        {
            Console.WriteLine($"Government: {fruitName}'s price is allowed.");
            return true;
        }
        Console.WriteLine($"Government: {fruitName}'s Price exceed the maximum price, can't be proceeded!");
        return false;
        
    }
}
