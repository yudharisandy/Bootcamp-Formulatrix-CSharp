// Command Line Argument (CLA)

class Program
{
    static void Main(string[] args){
        Console.WriteLine(args[0]);

        if(args[0] == "DuoMode"){
            Console.WriteLine("DuoMode");
        }
        else{
            Console.WriteLine("No argument");
        }

        foreach(var arg in args){
            Console.WriteLine(arg);
        }
    }
}

