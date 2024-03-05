using AutoChess;
class Program
{
    static void Main(){
        GameController gc = new();
    }
}
class PlayerData
{
    List<Piece> pieces;
    int gold;
    int exp;
    int level;
}