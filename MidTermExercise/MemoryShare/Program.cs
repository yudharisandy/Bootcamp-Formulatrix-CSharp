﻿// Memory share (Stack: value type-struct) (Heap: reference type-class)
// String tipe data (heap tapi immutable)
class Program
{
    static void Main(){
        // Int is an example of Stack (Value type)
        int a = 2;
        int b = a;
        b += 5;
        Console.WriteLine(a); // 2
        Console.WriteLine(b); // 7

        // String is an example of Heap (reference type) but it is immutable
        string string1 = "a";
        string string2 = string1;
        string2 += string1;
        Console.WriteLine(string1); // a
        Console.WriteLine(string2); // aa

        // Class is an example of Heap (reference type) - share the same memory
        Car car1 = new Car(10);
        Car car2 = car1; // Copy the address
        car2.price += 5;
        Console.WriteLine(car1.price); // 15
        Console.WriteLine(car2.price); // 15
    }
}

class Car
{
    public int price;
    public Car(int price){
        this.price = price;
    }
}