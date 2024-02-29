class Program
{
    static void Main(){
        Human human = new();
        // human.balance = 100; // Raise error
        human.SetBalance(100); 
        Console.WriteLine(human.balance);

        human.AddBalance(20);
        human.GetBalance();
    }
}
class Human
{
    public int Balance { get; private set; } // Property use PascalCase
    private int _balance; // Variable use camelCase
    public void SetBalance(int balance){ // Method use PascalCase
        this.balance = balance;
    }
    public void AddBalance(int balance){
        _balance = balance;
    }
    public void GetBalance(){
        Console.WriteLine(_balance);
    }


}