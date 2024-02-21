namespace MonopolyCards;

class FreeJailCard : Card
{
    private int _id;
    private string _name;
    private string _colour;
    public FreeJailCard(int id, string name, string colour) : base(id, name, colour){
        
    }
    public int GetId(){
        return _id;
    }
    public string GetName(){
        return _name;
    }
    public string GetColour(){
        return _colour;
    }
    public override void StartEffect()
    {
        Console.WriteLine("FreeJail Card effect is starting...");
    }
}
