class Program
{
    static void Main(){
        int foo = 3;
        int bar = 5;

        Console.Write("Input number: ");
        string userInput = Console.ReadLine();
        int userInputInt;
        bool boolConvert = Int32.TryParse(userInput, out userInputInt);
        
        for(int i = 0; i <= userInputInt; i++){
            string status = "";
            if (i % foo == 0 && i != 0){
                status += "foo";
            }
            if (i % bar == 0 && i != 0){
                status += "bar";
            }
            if((i % foo != 0 && i % bar != 0) || i == 0) 
            {
                Console.Write(i);
            }
            Console.Write(status);
            Console.Write(", ");
        }
    }
}

// n=15: 0, 1, 2, foo, 4, bar, foo, 7, 8, foo, bar, 11, foo, 13, 14, foobar

