

// Manual delegate
public delegate int MyDelegate(int a, int b);
class Progaram
{
    static void Main(){
        var cal = new Calculator();

        MyDelegate delManual = cal.Add;
        delManual += cal.Mul;
        delManual += cal.Div;

        // Default delegate: Func<int, int, int>
        var delDefault = cal.Add;
        delDefault += cal.Mul;
        delDefault += cal.Div;

        // Invoke
        delManual.Invoke(10, 5).Dump();
        delDefault.Invoke(10, 5).Dump();

        // Get each result in delegate
        Delegate[] delegates = delManual.GetInvocationList();
        var results = new int[3];
        int index = 0;
        foreach(MyDelegate dlgt in delegates){
            results[index] = dlgt.Invoke(10, 5);
            index++;
        }
        foreach(int result in results){
            result.Dump();
        }

        // Create new delegate based on existing delegate
        MyDelegate newDelegate;
        newDelegate = (MyDelegate) delegates[0];
        for(var i = 1; i < delegates.Length; i++){
            newDelegate += (MyDelegate) delegates[i];
        }
        int[] result2 = new int[3];
        int index2 = 0;
        foreach(MyDelegate delgt in newDelegate.GetInvocationList()){
            result2[index2] = delgt.Invoke(100, 20);
            index2++;
        }
        foreach(int res in result2){
            Console.WriteLine(res);
        }
        
    }
}
public class Calculator
{
    public int Add(int a, int b){
        return a + b;
    }
    public int Mul(int a, int b){
        return a * b;
    }
    public int Div(int a, int b){
        return a / b;
    }
}

public static class Extension{
    public static void Dump(this object x){
        Console.WriteLine(x);
    }
}

