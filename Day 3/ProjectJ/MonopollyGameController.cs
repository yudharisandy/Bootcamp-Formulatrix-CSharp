namespace MonopolyCards;

class MonopolyGameController 
{
    private Card[] cards;
    private int count = 0;
    public MonopolyGameController(int card){
        // take input parameter: number of cards will be made
        cards = new Card[card];
    }
    public void GetCardLength(){
        Console.WriteLine(cards.Length);
    }
    public bool AddCard(Card card){
        if (count == cards.Length - 1){
            return false;
        }
        else{
            cards[count] = card;
            count++;
            return true;
        }
    }
}
