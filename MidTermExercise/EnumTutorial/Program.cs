// Enum

class Program
{
    static void Main(){
        FridayToCheck(Days.Friday);
        FridayToCheck(Days.Monday);

        // Access int in enum
        int result = (int)Days.Friday;
        Console.WriteLine(result);

        // Access "string" in enum
        Days dayToCheck = (Days)4;
        Console.WriteLine(dayToCheck);
    }
    static void FridayToCheck(Days day){
        if (day == Days.Friday){
            Console.WriteLine("Thanks god it is friday");
        }
        else{
            Console.WriteLine("other days");
        }
    }
}
public enum Days
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}