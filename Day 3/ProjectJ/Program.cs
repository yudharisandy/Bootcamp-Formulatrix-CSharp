// Abstraction
using MonopolyCards;
class Program
{
    static void Main(){
        // FreeJailCard freeJailCard = new(1, "FreeJailCard", "black");
        // BirthdayCard birthdayCard = new(2, "BirthdayCard", "yellow");
        // freeJailCard.StartEffect();
        // birthdayCard.StartEffect();

        MonopolyGameController monopoly = new(20);
        monopoly.GetCardLength();
        monopoly.AddCard(new BirthdayCard(1, "BirthdayCard", "black"));
        monopoly.AddCard(new FreeJailCard(2, "FreeJailCard", "yellow"));
    }
}