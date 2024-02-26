namespace FoobarApp;

public class Foobar
{
    private Func<int, string> _checkFooBarNum;
    private int _foo;
    private int _bar;
    private string _status;
    public Foobar(int foo, int bar){
        _foo = foo;
        _bar = bar;
        // Assign methods to Delegate (_checkFooBarNum)
        _checkFooBarNum += CheckFoo;
        _checkFooBarNum += CheckBar;
        _checkFooBarNum += CheckNum;
    }
    public void Calculate(int userInputInt){
        for(int i = 0; i <= userInputInt; i++){            
            _status = ""; // Reset _status in each iteration
            
            // Iterate over each method in _checkFooBarNum Delegate (CheckFoo -> CheckBar -> CheckNum)
            foreach (Func<int, string> myDel in _checkFooBarNum.GetInvocationList()){
                _status += myDel.Invoke(i);
            }

            _status += AddCommaPeriod(i, userInputInt); // Add comma and period.

            // Print all result
            Console.Write(_status);
        }
    }
    private string CheckFoo(int i){
        if (i % _foo == 0 && i != 0){
            return "foo";
        }
        return "";
    }
    private string CheckBar(int i){
        if (i % _bar == 0 && i != 0){
            return "bar";
        }
        return "";
    }
    private string CheckNum(int i){
        if((i % _foo != 0 && i % _bar != 0) || i == 0){
            string number = i.ToString();
            return number;
        }
        return "";
    }
    private string AddCommaPeriod(int i, int userInputInt){
            if (i < userInputInt){
                return ", ";
            }
            return ".\n"; // Indicate the end of sentence
    }
}
