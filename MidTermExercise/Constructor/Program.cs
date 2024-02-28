class Program
{
    static void Main(){
        var employee = new Employee(90, "Asep");
        employee.email = "asep@fmltrx.com";

        Console.WriteLine(employee.id);
        Console.WriteLine(employee.name);
        Console.WriteLine(employee.email);
    }
}
public class Employee
{
    public int id;
    public string name;
    public string email;
    // Constructor
    public Employee(int id, string name){
        this.id = id;
        this.name = name;
    }
}