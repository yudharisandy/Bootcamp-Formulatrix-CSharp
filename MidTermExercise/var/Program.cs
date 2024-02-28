class Program
{
    static void Main(){
        var names = new List<string> {"yudha", "putra", "arisandy"};
        var names1 = new int[] {1, 2, 3};

        foreach(var name in names){
            System.Console.WriteLine(name);
        }
        for(var i = 0; i < names.Count; i++){
            System.Console.WriteLine(names[i]);
        }
        System.Console.WriteLine(names1.Length);
        for(var i = 0; i < names1.Length; i++){
            System.Console.WriteLine(names1[i]);
        }
        foreach(var number in names1){
            System.Console.WriteLine(number);
        }

    }
}
