class Program
{
    static void Main(){
        GameController gc = new();
        BattleArena arena = new();
        Player player1 = new();
        Piece piece1 = new();
        
        // Dictionary<Player, string> playersPieces = new();
        // playersPieces.Add(player1, "List<Pieces>");

        // Enter battle arena
        // var enterArena = gc.EnterBattleArena(playersPieces); // parsing Du

        // Battle Arena
        Dictionary<Player, string> playersPieces = gc.GetPlayersPieces();
    }
}
public class GameController
{
    public Dictionary<Player, string> playersPieces;
    public bool EnterBattleArena(Dictionary<Player, string> playersPieces){
        // .. condition
        foreach(var i in playersPieces){
            Console.WriteLine(i.Key);
            Console.WriteLine(i.Value);
        }

        return true;
    }
    public Dictionary<Player, string> GetPlayersPieces(){
        return playersPieces;
    }
}
public class Player
{

}
public class Piece
{

}
public class BattleArena
{

}