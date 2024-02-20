namespace Vehicle;
class Tire
{
    //Tire
    public string tireType;
    public int tireDiameter;
    public string tireBrand; 

    //Constructor
    public Tire(
                string tireType,
                int tireDiameter,
                string tireBrand)
    {
        this.tireType = tireType;
        this.tireDiameter = tireDiameter;
        this.tireBrand = tireBrand; 
    }

    public void PrintAttribute(string tireType, int tireDiameter, string tireBrand){
        Console.WriteLine($"Tire type: {tireType}");
        Console.WriteLine($"Tire diameter: {tireDiameter}");
        Console.WriteLine($"Tire brand: {tireBrand}");
    }
}
