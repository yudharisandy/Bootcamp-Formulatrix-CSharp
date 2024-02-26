namespace FoobarApp;

public class Foobar
{
    private Func<int, string> _checkFooBarNum;
    private string _status;
    private int[] _keyArray; // Unwrap the dictionary key
    private string[] _valueArray; // Unwrap the dictionary value
    public string Process(int userInputInt, Dictionary<int, string> dataBase){
        _status = "";
        UnwrapKeyValue(dataBase); // Output: _keyArray && _valueArray
        for(int i = 0; i <= userInputInt; i++){                        
            CheckPattern(i); 
            CheckNum(i);
            AddCommaPeriod(i, userInputInt); 
        }
        return _status;
    }
    private void CheckPattern(int i){
        for(int j = 0; j < _keyArray.Length; j++){
            if (i % _keyArray[j] == 0 && i != 0){
                _status += _valueArray[j];
            }
            _status += "";
        }
    }
    private void CheckNum(int i){
        bool modulusCheck = true;

        int index = 0;
        do {
            if (i % _keyArray[index] == 0){
                modulusCheck = true;
                break;
            }
            else{
                modulusCheck = false;
            }
            index++;
            if (index >= _keyArray.Length){
                break;
            }
        } while (modulusCheck = true);

        if(modulusCheck == false || i == 0){
            string number = i.ToString();
            _status += number;
        }
        else{
            _status += "";
        }
    }
    private void AddCommaPeriod(int i, int userInputInt){
        // Add comma if it isn't the end of sentence
        if (i < userInputInt){
            _status += ", ";
        }
        else{
            _status += ".\n"; // Add period if it is the end of sentence
        }
    }
    private void UnwrapKeyValue(Dictionary<int, string> dataBase){
        _keyArray = new int[dataBase.Count];
        _valueArray = new string[dataBase.Count];
        int index = 0;
        foreach (var i in dataBase){
            _keyArray[index] = i.Key;
            _valueArray[index] = i.Value;
            index++;            
        }
    }
}
