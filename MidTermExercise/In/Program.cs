// In : change a variable to be "readonly" can't modify the value

class Program
{
    static void Main(){
        int a = 10;
        int newNumber = Increament(in a);
        Console.WriteLine(newNumber);
    }
    static int Increament(in int a){
        // value a can't be modified
        // only can be copied
        // a++; // Error
        Console.WriteLine(a);
        int newNumber = a + 2;
        return newNumber;
    }
}