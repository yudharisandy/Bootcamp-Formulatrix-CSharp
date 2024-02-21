namespace MonopolyCards;

abstract class Card 
{
    private int _id;
    private string _name;
    private string _colour;
    public Card(int id, string name, string colour){
        _id = id;
        _name = name;
        _colour = colour;
    }
    public abstract void StartEffect();
}