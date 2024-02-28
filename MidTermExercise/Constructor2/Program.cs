// Overloading
// Same Method/Constructor, but different parameters

class Program
{
    static void Main(){
        var employee = new Employee();
        var employee2 = new Employee(80, "dimas");
        var employee3 = new Employee(50, "gilang", "gilang@gmail.com");

        Console.WriteLine(employee.id); // 0
        Console.WriteLine(employee.name); // null
        Console.WriteLine(employee.email); // null

        Console.WriteLine(employee3.email);
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
    // Constructor overloading
    public Employee(int id, string name, string email){
        this.id = id;
        this.name = name;
        this.email = email;
    }
    // Constructor overloading
    // Parameterless constructor
    public Employee(){ 

    }
}