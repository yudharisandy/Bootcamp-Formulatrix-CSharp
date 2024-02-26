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
            // Reset _status in each iteration
            _status = ""; 
            
            // Iterate over each method in _checkFooBarNum Delegate (CheckFoo -> CheckBar -> CheckNum)
            foreach (Func<int, string> myDel in _checkFooBarNum.GetInvocationList()){
                _status += myDel.Invoke(i);
            }

            // Add comma or period.
            _status += AddCommaPeriod(i, userInputInt); 

            // Print all result
            Console.Write(_status);
        }
    }
    private string CheckFoo(int i){
        // If i is the multiplication of _foo = 3 and Non-zero
        if (i % _foo == 0 && i != 0){
            return "foo";
        }
        return "";
    }
    private string CheckBar(int i){
        // If i is the multiplication of _bar = 5 and Non-zero
        if (i % _bar == 0 && i != 0){
            return "bar";
        }
        return "";
    }
    private string CheckNum(int i){
        // If i is neither the multiplication of _foo = 3 nor _bar = 5 (or zero-value: just to print out the initial 0)
        if((i % _foo != 0 && i % _bar != 0) || i == 0){
            string number = i.ToString();
            return number;
        }
        return "";
    }
    private string AddCommaPeriod(int i, int userInputInt){
        // Add comma if it isn't the end of sentence
        if (i < userInputInt){
            return ", ";
        }
        return ".\n"; // Add period if it is the end of sentence
    }
}
