class Program
{
    static void Main(){

    }
}
public class MonopolyGame
{
    public IPlayer[] players;
    public void AddPlayer(IPlayer p){
        // players.Add(p);
    }
}
public class MobileLegendGame
{
    public IOnlinePlayer players;
    public void AddPlayer(IOnlinePlayer p){
        // players.Add(p);
    }
    public void CheckUserName(IOnlinePlayer p){
        Console.WriteLine(p.userName);
    }
}
public interface IPlayer
{
    public string name { get; set; }
    public int id { get; set; }
}
public interface IOnlinePlayer : IPlayer
{
    public string userName { get; set; }
    public string email { get; set; }
}
public class Player : IPlayer
{
    public string name { get; set; }
    public int id { get; set; }
}
public class OnlinePlayer : IOnlinePlayer
{
    public string name { get; set; }
    public int id { get; set; }
    public string userName { get; set; }
    public string email { get; set; }
}
public class PUBGPlayer : IOnlinePlayer
{
    public string name { get; set; }
    public int id { get; set; }
    public string userName { get; set; }
    public string email { get; set; }
    public string rank { get; set; }
}