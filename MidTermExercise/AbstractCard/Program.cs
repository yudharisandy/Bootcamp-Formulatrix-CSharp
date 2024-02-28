// Abstract: 
    // An abstract class is a class that cannot be instantiated. 
    // Instead, it serves as a base class for other classes to inherit from.
    // The abstract modifier can be used with classes, methods, properties, indexers, and events.
    // Use the abstract modifier in a method or property declaration to indicate 
    // that the method or property does not contain implementation.
    // Use "override" keyword.
    // All properties and methods (exclude the abstract one) will be inherited to the derived class.
    // Reference: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract

// Implementation
class Program
{
    static void Main(){
        // Car car = new();
        // car.Go();
        // car.Walk();
        // Console.WriteLine(car.Capacity);
        // Console.WriteLine(car.Fuel);
        // Vehicle veh = new(); // Error

        // Card card = new(1, "card", "yelow"); // Error (abstract class can't be instanciated)
        BirthdayCard birthdayCard = new(1, "Birthday Card", "Black");
        JailCard jailCard = new(2, "Jail Card", "yellow");
        Console.WriteLine(jailCard.GetId());
        Console.WriteLine(birthdayCard.GetColour());

        MonopolyGameController monopoly = new(10); // Create 10 cards (maximum)
        monopoly.AddCard(jailCard);
        monopoly.AddCard(new BirthdayCard(3, "Birthday 2", "Red"));
        foreach (var card in monopoly.GetAllCards()){
            Console.WriteLine(card);
        }
    }
}

class MonopolyGameController
{
    private Card[] cards = null;
    private int _count = 0;
    public MonopolyGameController(int numCard){
        cards = new Card[numCard];
    }
    public bool AddCard(Card card){
        if(_count == cards.Length -1){
            return false;
        }
        cards[_count] = card;
        _count++;
        return true;
    }
    public IEnumerable<Card> GetAllCards(){ // A method to iterate a custom collection
        if (cards == null){
            return Enumerable.Empty<Card>();
        }
        return cards;
    }
}

public abstract class Card // Abstract class can't be instanciated
{
    private int _id;
    private string _name;
    private string _colour;
    // Constructor
    public Card(int id, string name, string colour){
        _id = id;
        _name = name;
        _colour = colour;
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
    public abstract void StartEffect(); // Abstract method has no implementation
}

public class BirthdayCard : Card
{
    // Constructor
    public BirthdayCard(int id, string name, string colour) : base(id, name, colour){

    }
    public override void StartEffect(){
        Console.WriteLine("BirthdayCard start effect");
    }
}

public class JailCard : Card
{
    // Constructor
    public JailCard(int id, string name, string colour) : base(id, name, colour){

    }
    public override void StartEffect()
    {
        Console.WriteLine("Jail Card starts effect");
    }
}

public abstract class Vehicle // Can't be instanciated
{
    protected int _capacity = 1;
    protected string _fuel = "gasoline";
    public abstract void Go(); // Abstract method have no implementation

    public abstract int Capacity { get; }
    public abstract string Fuel { get; }
}

public class Car : Vehicle
{
    public override void Go(){ // Mandatory to add "override"
        Console.WriteLine("Go");
    }
    public void Walk(){
        Console.WriteLine("Walk");
    }
    public override int Capacity {
        get{
            return _capacity;
        }
    }
    public override string Fuel{
        get{
            return _fuel;
        }
    }
}
