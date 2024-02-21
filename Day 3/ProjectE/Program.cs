// Static = not owned by instance/object
// Static method can't access private variable
// Static variable can be accessed by both static and non-static method

class Program
{
    static void Main(){
        // int result1 = Calculator.Add(1, 2);
        // int result2 = Calculator.Add(3, 4);
        // Console.WriteLine(result1);
        // Console.WriteLine(result2);
        
        Calculator calc1 = new Calculator(1000);
        Calculator calc2 = new Calculator(2000);
        Calculator calc3 = new Calculator(3000);
        int count = Calculator.GetCount();
        Console.WriteLine(count);
        int battery2 = calc2.GetBattery();
        Console.WriteLine(battery2);
    }
}

class Calculator // can be changed to static class -> all method and variables must be static-type
{
    public static int count; // Can be accessed by both static and non-static method
    private int _battery; // Can be accessed only by Non-static method
    public Calculator(int power){
        count++;
        _battery = power;
    }
    // Static method
    public static int GetCount(){ 
        return count;
    }
    // Non-static method
    public int GetBattery(){ 
        return _battery;
    }
    public static int Add(int a, int b){ // Static method
        return a + b;
    }
}

