namespace LanguageTraining;

public class Grader
{
    private int score;
    public void GradeAnswer(string answer){
        // Logic for grading
        score = 10;
        // Print("Grader: 10/10");
    }
    public void ShowGrade(){
        Print($"Grader: {score}/10");
    }
    // public void CheckAnswer(string answer){
    //     Print("Checker: Correct answer!");
    // }
    // public void GiveSuggestion(string answer){
    //     Print("Already good!");
    // }
    static void Print<T>(T x){
        Console.WriteLine(x);
    }
}
