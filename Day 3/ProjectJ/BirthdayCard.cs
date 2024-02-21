namespace MonopolyCards;

class BirthdayCard : Card
{
    private int _id;
    private string _name;
    private string _colour;
    public BirthdayCard(int id, string name, string colour) : base(id, name, colour){

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
        Console.WriteLine("Birthday card effect is starting...");
    }
}
