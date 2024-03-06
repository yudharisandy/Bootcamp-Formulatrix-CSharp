// Watch Run
class Program{
    static void Main(){
        Printer();
        System.Console.WriteLine("somethng");
    }
    static async void Printer(){
        while(true){
            string something = "ab";
            System.Console.WriteLine(something);
            await Task.Delay(1);
            System.Console.WriteLine("cd"); // Will never be executed
            
        }
    }
}