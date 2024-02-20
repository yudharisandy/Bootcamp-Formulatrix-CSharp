// Topic: Constructor and Overloading
class Program
{
    static void Main()
    {
        // Create instance 1
        Employee emp = new Employee("Asep", 80, "asep@gmail.com", 100.0f);
        // Console.WriteLine(emp.name);
        // Console.WriteLine(emp.id);
        Console.WriteLine("Before Work");
        emp.PrintAttribute(emp.name, emp.id, emp.email, emp.energy);
        Console.WriteLine("After Work");
        emp.Work();
        emp.PrintAttribute(emp.name, emp.id, emp.email, emp.energy);

        // Create instance 2
        Employee emp2 = new Employee("Brian");
        emp.PrintAttribute(emp2.name);
    }
}

class Employee
{
    public string name;
    public int id;
    public string email;
    public float energy;

    // Constructor
    public Employee(string name, int id, string email, float energy){
        this.name = name;
        this.id = id;
        this.email = email;
        this.energy = energy;
    }

    // Overloading: same name but different parameter(s)
    public Employee(){} // Overloading for 0 parameter of Employee() object
    // Overloading for 1 parameter of Employee() object
    public Employee(string name){
        this.name = name; // 'this' refers to public variable of this object
    }

    public float Work(){
        Console.WriteLine("Work");
        energy -= 10.2f;
        return energy;
    }
    public void Rest(){
        Console.WriteLine("Rest");
    }
    public void PrintAttribute(string name, int id, string email, float energy){
        Console.WriteLine(name);
        Console.WriteLine(id);
        Console.WriteLine(email);
        Console.WriteLine(energy);
    }
    // Overloading for PrintAttribute() method
    public void PrintAttribute(string name){
        Console.WriteLine(name);
    }
}