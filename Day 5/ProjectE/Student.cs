namespace LanguageTraining;

public class Student
{
    public string answer;
    public string GiveAnswer(string problem){
        // Logic for receiving student's answer
        // answer = "Chicken";
        Console.Write("Answer: ");
        answer = Console.ReadLine();
        return answer;
    }
}
