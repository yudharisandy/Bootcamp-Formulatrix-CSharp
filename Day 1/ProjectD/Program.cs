
class Program
{ 
    static void Main()
    {
        Calculator cal = new Calculator();
        int angka1 = 10;
        int angka2 = 5;
        int add = cal.Additional(angka1, angka2);
        int mul = cal.Multiply(angka1, angka2);
        Console.WriteLine($"Additional result: {add}");
        Console.WriteLine($"Multiplication result: {mul}");

        cal.PrintResult(add);
    }
}

class Calculator
{
    public int Additional(int angka1, int angka2)
    {
        return angka1 + angka2; 
    }

    public int Multiply(int angka1, int angka2)
    {
        return angka1*angka2;
    }

    public void PrintResult(int result)
    {
        Console.WriteLine(result);
    }
}
