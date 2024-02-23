// Delegate implementation
// Language training app
// The app will show an Indonesian word -> then user must input the English of that word
// After that, we will call a delegate function ->
    // Check the answer correct or wrong
    // Give the grade of that answer
    // Give suggestion

using LanguageTraining;

public delegate void TrainerDelegate(string answer);
public delegate void ShowTrainerDelegate();

class Progam
{
    static void Main(){
        int initialStudentScore = 0;

        Student student = new();
        Checker checker = new();
        Grader grader = new();
        Suggester suggester = new();
        
        // Assign a problem to student
        string problem = "Ayam";
        Print($"Problem: {problem}");
        string studentAnswer = student.GiveAnswer(problem);
        Print($"Student's Answer: {studentAnswer}\n"); // Student will answer "Chicken"

        // All of the trainer actors (checker, grader, suggester) will work base on the answer
        TrainerDelegate delegates = checker.CheckAnswer;
        delegates += grader.GradeAnswer;
        delegates += suggester.GiveSuggestion;

        // Example: If Grader do all things (checing, grading, suggesting):
        // TrainerDelegate delegates = grader.CheckAnswer;
        // delegates += grader.GradeAnswer;
        // delegates += grader.GiveSuggestion;
        delegates.Invoke(studentAnswer);

        // Create a new delegate to only show the result in our app
        ShowTrainerDelegate showDelegates = checker.ShowStatus;
        showDelegates += grader.ShowGrade;
        showDelegates += suggester.ShowSuggestion;
        showDelegates.Invoke();
    }
    static void Print<T>(T x){
        Console.WriteLine(x);
    }
}

// Delegate : A way to call many functions from different classes at once
// Also called as "Function Pointer"
// Requirements: Each method must have same return type (ex: void), and same parameter (ex: parameter less)
// Add method to a delegates: delegates += method;
// Run the delegate: delegate() or delegate.invoke();
// Usually implemented in the "void" return type.