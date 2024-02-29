// Custom properties

class Program
{
    static void Main(){
        Human human = new();
        human.Balance = 70;
        Console.WriteLine(human.Balance);
    }
}
class Human
{
    // Variable
    private int _balance;
    // Property
    public int Balance{
        get{
            return _balance;
        }
        set{
            _balance = value * 1000;
        }
    }
}