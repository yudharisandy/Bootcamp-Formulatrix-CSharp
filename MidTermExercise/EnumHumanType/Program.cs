class Program
{
    static void Main(){
        Human human1 = new(HumanType.Teen);
        human1.CheckHumanType();

        bool cons = human1.ChangeType(HumanType.Baby);
    }
}
public class Human
{
    private HumanType _type { get; set;}
    // COnstructor
    public Human(HumanType type){
        _type = type;
    }
    public void CheckHumanType(){
        if (_type == HumanType.Baby){
            Console.WriteLine(HumanType.Baby);
        }
        if (_type == HumanType.Teen){
            Console.WriteLine(HumanType.Teen);
        }
        if (_type == HumanType.Adult){
            Console.WriteLine(HumanType.Adult);
        }
    }
    public bool ChangeType(HumanType type){
        if (_type == type){
            Console.WriteLine($"Type has been already a/an {_type}");
            return false;
        }
        _type = type;
        Console.WriteLine($"Type has been changed to a/an {_type}");
        return true;
    }
}
public enum HumanType
{
    Baby,
    Teen,
    Adult
}