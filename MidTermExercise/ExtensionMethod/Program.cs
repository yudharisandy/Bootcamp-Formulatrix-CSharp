class Program
{
    static void Main(){
        int a = 3;
        a.Cetak(); // 3

        a.Bandingkan(10).Cetak(); // -1

        int b = a + 3;
        b.Dump(); // 6 
    }
}
// Extension class
public static class RandomName
{
    // Extention method
    public static void Cetak(this object a){
        Console.WriteLine(a);
    }
    public static int Bandingkan(this int a, int b){
        if (a > b){
            return 1;
        }
        if (a < b){
            return -1;
        }
        return 0;
    }
    public static void Dump(this object a){
        Console.WriteLine(a);
    }
}