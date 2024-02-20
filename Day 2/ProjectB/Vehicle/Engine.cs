namespace Vehicle;
class Engine
{
    //Engine
    public int engineHp;
    public string engineType;
    public int engineVolume;
    public string engineBrand; 

    //Constructor (all parameters are mandatory)
    public Engine(
                    int engineHp,
                    string engineType,
                    int engineVolume,
                    string engineBrand)
    {
        this.engineHp = engineHp;
        this.engineType = engineType;
        this.engineVolume = engineVolume;
        this.engineBrand = engineBrand;
    }

    public void PrintAttribute(int engineHp, string engineType, int engineVolume, string engineBrand){
        Console.WriteLine($"Engine HP: {engineHp}");
        Console.WriteLine($"Engine type: {engineType}");
        Console.WriteLine($"Engine volume: {engineVolume}");
        Console.WriteLine($"Engine brand: {engineBrand} ");
    }
}