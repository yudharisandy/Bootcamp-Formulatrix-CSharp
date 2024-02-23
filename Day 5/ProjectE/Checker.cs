namespace LanguageTraining;

public class Checker
{
    private bool checkStatus;
    public void CheckAnswer(string answer){
        // Logic for checking the answer
        checkStatus = true;
        // Print("Checker: Correct answer!");
    }
    public void ShowStatus(){
        if (checkStatus == true){
            Print("Checker: Correct answer!");
        }
        else{
            Print($"Checker: Wrong answer!");
        }
    }
    static void Print<T>(T x){
        Console.WriteLine(x);
    }
}
