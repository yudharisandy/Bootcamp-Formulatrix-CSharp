// Event : secure method when declare a delegate 
    // public event Action myDelegate;
    // If not, other can do this: delegate.del = null (reset the delegate)
    // Or delegares.del = database.Notify;
    // Need to be considered: the method to Invoke the delaget.

class Program
{
    static void Main(){
        // Create instance
        Creator creator = new();
        Subscriber1 sub1 = new();
        Subscriber2 sub2 = new();

        creator.myDelegate += sub1.Notify;
        creator.myDelegate += sub2.Notify;
        // creator.myDelegate.Invoke();
        // Can't be invoked except in the Creator class.
        // creator.Notify();
        creator.UpdateInfo();
    }
}
class Creator
{
    public event Action myDelegate;
    public void UpdateInfo(){
        Console.WriteLine("Updating");
        Notify();
    }
    public void Notify(){
        myDelegate?.Invoke();
    }
}
class Subscriber1 
{
    public void Notify(){
        Console.WriteLine("Sub1 got notified.");
    }
}
class Subscriber2
{
    public void Notify(){
        Console.WriteLine("Sub2 got notified.");
    }
}

