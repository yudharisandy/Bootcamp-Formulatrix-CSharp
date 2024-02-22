// Generic contraint
using System.Numerics;
class Program {
	static void Main() {
		var calc = new Calculator<int>();
		int result = calc.Add(3,4);
        Print(result);
	}
    static void Print<T>(T x){
        Console.WriteLine(x);
    }
}
class Calculator<T> where T : INumber<T>
	{
	public T Add(T data1, T data2) {
		return data1 + data2;
	}
}
