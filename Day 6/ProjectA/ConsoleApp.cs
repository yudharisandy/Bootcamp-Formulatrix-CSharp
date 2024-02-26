namespace Translation;

public class Grader
{
    private int _score;
    public string CheckTranslation(string answer){
        return "Correct";
    }
    public string Suggestion(string answer){
        return "Study more vocabularies";
    }
    public int GiveScore(string answer){
        return _score;
    }
    public void ShowResult(string answer, int grade){
        Console.WriteLine($"Grader class: {answer} | {grade}");
    }
}
