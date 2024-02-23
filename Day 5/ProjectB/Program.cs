// Ref: Copy the address of value type variable -> then, it works as a reference type variable.
// Out: Assigned the value of a variable, without need an initial assign variable.
// In : create a "readonly" variable. A method can assign new value into that variable. Literally only for performance.

using Variables;

class Program
{
    static void Main(){
        // Ref implementation
        int dataRef = 100;
        AddWithTen(ref dataRef);
        Print(dataRef);

        // Out implementation
        // No need to be initially assigned.
        AddWithTwenty(out int dataOut);
        Print(dataOut);

        // In implementation
        int dataIn = 10;
        int newDataIn = GetValueOnly(dataIn);
        Print(dataIn);
        Print(newDataIn);

        //----------------------------------

        // Inter class implementation for Ref, Out, and In
        // Variable varriable = new();
        // varriable.

    }
    static void AddWithTen(ref int number){
        number += 10;
    }
    static void AddWithTwenty(out int number){
        // Initially assigned
        number = 1000;
        // Modify the value
        number += 20;
        // 1020 will be returned as the value of "number"
    }
    static int GetValueOnly(in int number){
        // "number" can only be read, can't be modified -> readonly variable.
        // We can still copy the value by implementing:
        int newNumber = number + 1;
        return newNumber;
    }
    static void Print<T>(T value){
        Console.WriteLine(value);
    }
    
}



