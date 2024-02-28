// Ref: Copy the address of a value-type variable -> can be a reference type

class Program
{
    static void Main(){
        int a = 1; // Originally a value-type
        Increament(ref a); // by adding "ref" -> convert to reference-type
        Console.WriteLine(a);

    }
    static void Increament(ref int x){
        x++;
    }
}