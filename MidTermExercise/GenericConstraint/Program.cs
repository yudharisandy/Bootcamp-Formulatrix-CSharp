﻿//Generic Constraint
//To limit the flexibility of Generic
// where T : .....

using System.Numerics;
class Program
{
    static void Main(){
        var cal = new Calculator<int, int>();
        int result = cal.Add(3, 5);
        Console.WriteLine(result);
    }
}
public class Device {}
public class Calculator<T, T2> : Device
    where T: INumber<T>
    where T2: INumber<T2>
    {
    public T Add(T a, T b){
        return a + b;
    }
}