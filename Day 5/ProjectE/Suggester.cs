namespace LanguageTraining;

public class Suggester
{
    private string suggestion;
    public void GiveSuggestion(string answer){
        // Logic for making suggestion
        suggestion = "Already good";
        // Print("Already good!");
    }
    public void ShowSuggestion(){
        Print($"Suggester: {suggestion}");
    }
    static void Print<T>(T x){
        Console.WriteLine(x);
    }
}
