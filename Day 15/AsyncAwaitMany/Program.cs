class Program
{
    static async Task Main(){
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 1

        Class1 class1 = new();
        await class1.Method1(); // Cannot await void
        // class1.Method1(); // this line will run at the same time taxi.Method1 (almost at same time)
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 5
        
        Taxi taxi = new();
        await taxi.Method1();
        // taxi.Method1(); // this line will run at the same time class1.Method1 (almost at same time)
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 5

        // Thread.Sleep(6000);
    }
}
class Class1{
    public async Task Method1(){
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 1
        Class2 class2 = new();
        // If not awaited, the execution will continue before the call is completed
        await class2.Method2(); // Cannot await void
        System.Console.WriteLine("Class1.Method1() completed");
    }
}
class Class2{
    public async Task Method2(){
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 1
        Class3 class3 = new();
        await class3.Method3(); // If not awaited, the execution will continue before the call is completed
        System.Console.WriteLine("Class2.Method2() completed");
    }
}
class Class3
{
    public async Task Method3(){
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 1
        await Task.Delay(5000);
        System.Console.WriteLine("Class3.Method3() completed"); // Cannot await 'void'
    }
}

class Taxi{
    public async Task Method1(){
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 5
        Bus bus2 = new();
        // If not awaited, the execution will continue before the call is completed
        await bus2.Method2(); // Cannot await void
        System.Console.WriteLine("Taxi.Method1() completed");
    }
}
class Bus{
    public async Task Method2(){
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 5
        Car car = new();
        await car.Method3(); // If not awaited, the execution will continue before the call is completed
        System.Console.WriteLine("Bus.Method2() completed");
    }
}
class Car
{
    public async Task Method3(){
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 5
        await Task.Delay(5000);
        System.Console.WriteLine("Car.Method3() completed"); // Cannot await 'void'
    }
}