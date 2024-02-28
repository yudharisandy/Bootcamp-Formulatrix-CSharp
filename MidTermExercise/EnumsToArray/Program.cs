class Program
{
    static void Main(){
        // Access int (constant) from enum
        int num = (int) StatusCode.NotFound;
        Console.WriteLine(num);

        // Access string (variable) from enum
        short code = 200;
        StatusCode statusCode = (StatusCode) code;
        Console.WriteLine(statusCode);

        // Enum to Array
        Array arrayEnum = Enum.GetValues(typeof(StatusCode));
        foreach(var i in arrayEnum){
            Console.WriteLine(i);
        }

    }
}
public enum StatusCode
{
    NotFound = 404,
    Redirect = 300,
    Unauthorized = 401,
    InternalServerError = 500,
    Ok = 200,
} 