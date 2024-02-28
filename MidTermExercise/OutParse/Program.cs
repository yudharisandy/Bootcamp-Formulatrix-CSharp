class Program
{
    static void Main(){
        string a = "30";
        bool status = int.TryParse(a, out int result);
        Console.WriteLine(status);
        Console.WriteLine(result);
    }
}