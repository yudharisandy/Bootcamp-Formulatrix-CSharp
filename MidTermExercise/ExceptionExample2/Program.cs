class Program
{
    static void Main(){
        Console.WriteLine("program starts");
        try{ // Method to run (has exception possibility)
            ExceptionMaker();
        }
        catch(FormatException e){
            Console.WriteLine("Format exception");
        }
        catch(IndexOutOfRangeException e){
            Console.WriteLine("Out of range");
        }
        catch (Exception e){
            Console.WriteLine(e);
        }
    }
    static void ExceptionMaker(){
        Console.WriteLine("Exception maker starts");
        string data = "39";
        bool status = int.TryParse(data, out int dataInt);
        Console.WriteLine(dataInt);

        int[] myArray = {1, 2, 3};
        Console.WriteLine(myArray[5]);
    }
}