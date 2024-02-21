// Extension method

class Program
{
    static void Main(){
        3.Cetak();
        6.Bandingkan(4).Cetak();
        "String".Dump();
    }
}

static class Apapun 
{
    // Extension method
    public static void Cetak(this object a){
        Console.WriteLine(a);
    }
    // Extension method
    public static int Bandingkan(this int x, int y){
        if(x > y){
            return 1;
        }
        if(x < y){
            return -1;
        }
        return 0;
    }
    // Extension method
    public static void Dump(this object a){
        Console.WriteLine(a);
    }

}