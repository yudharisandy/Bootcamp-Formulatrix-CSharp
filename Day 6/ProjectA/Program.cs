// Default delegate tanpa return type (void): Action -> sudah disediakan microsoft
    // public delegate void Action<T, T1>(T param1, T1 param2)
// Default delegate dengan return type -> bukan void -> Func
    // public delegate T2 Func<T, T1, T2>(T param1, T1 param2); 
    // T2 will be return type
// action?.Inove();

// Anonymous method -> lambda function -> used fot simple method
    // Func<int, int, float> func = (int a, int b) => (a + b);
    // Action<string> action = (string a) => Console.WriteLine(a);
    // Action action1 = () => Console.WriteLine("Testing");

using Translation;

class Program
{
    static void Main(){
        // Action example
        Translator translator = new();
        Action<string> action = translator.CheckTranslation;
        action += translator.GradeTranslation;
        action?.Invoke("Chicken");

        // Func example
        Grader grader = new();
        Func<string, string> func = grader.CheckTranslation;
        func += grader.Suggestion;
        func?.Invoke("Chiken");

        // Get value of each function
        Delegate[] delegateFunc = func.GetInvocationList();
        string[] stringResult = new string[delegateFunc.Length];
        int index = 0;
        foreach (Func<string, string> del in delegateFunc){
            stringResult[index] = del.Invoke("Chiken");
            // Console.WriteLine(stringResult[index]);
            index++;
        }
        // Print all results of each function in delegate func
        foreach (string data in stringResult){
            Console.WriteLine(data);
        }

        // Anonymous method (Lambda expression) example
        // Action with 2 input params
        Action<string, int> action2 = (string a, int b) => Console.WriteLine($"Answer: {a} | Score: {b}");
        action2 += grader.ShowResult;
        action2?.Invoke("Cheese", 8);
        // Action with 0 input param
        Action action3 = () => Console.WriteLine("Program is starting...");
        action3?.Invoke();
        // Func with 2 input param -> return float-type
        Func<int, float, float> func2 = (int a, float b) => (a + b);
        float result = func2.Invoke(6, 3.8f);
        Console.WriteLine(result);
        // Func with 1 input param -> return bool type
        Func<int, bool> func3 = (int a) => {
            if (a >= 8){
                return true;
            }
            return false;
        };
        bool result3 = func3.Invoke(7);
        Console.WriteLine(result3);
    }
}