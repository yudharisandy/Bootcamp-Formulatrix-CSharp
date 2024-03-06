﻿// finally
class Program{
    static void Main(){
        try{
            string a = "3a";
            int b = int.Parse(a);
        }
        catch(FormatException e){
            Console.WriteLine("Format exception");
        }
        finally{ // this will be run either there is exception or no
            Console.WriteLine("Program closed");
        }
    }
}