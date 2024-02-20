class Program
{
    static void Main(){
        Calculator calculator = new Calculator();
        int addition = calculator.Add(2, 4);
        int multiplication = calculator.Mul(5, 6);
        int division = calculator.Div(8, 2);
        int substraction = calculator.Sub(10, 5);

        // calculator.PrintResult(addition);
    }
}
