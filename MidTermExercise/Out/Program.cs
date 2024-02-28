// Out : No need intial assigned variable

class Program
{
    static void Main(){
        Increament(out int a);
        Console.WriteLine(a);
    }
    static void Increament(out int a){
        a = 10;
        a += 100;
    }
}