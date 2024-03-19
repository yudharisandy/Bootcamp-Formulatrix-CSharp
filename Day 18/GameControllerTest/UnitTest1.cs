using GameControllerLib;
using Moq;
namespace GameControllerTest;

public class GameControllerTests
{
	private GameController _game;
	private Mock<IPlayer> _player;
	private Mock<IBoard> _board;

	[SetUp]
	public void Setup()
	{
		_player = new Mock<IPlayer>();
		_board = new Mock<IBoard>();
		_game = new(_player.Object, _board.Object);
	}

	[Test] 
	//Positive Testing
	//Method_ExpectedBehavior_StateUnderTest
	public void AddCards_CardsAdded_PlayerExists()
	{
		//Arrange
		Mock<ICard> card1 = new Mock<ICard>();
        Mock<ICard> card2 = new Mock<ICard>();
        
        List<Mock<ICard>> cards  = new List<Mock<ICard>>();
        cards.Add(card1);
        cards.Add(card2);

		//Act
        foreach(var card in cards){
		    bool result = _game.AddCards(_player.Object, card.Object);

            //Assert
            Assert.IsTrue(result);

            // card.Verify(card => card.SetStatus(CardStatus.OnPlayer), Times.Once);
            card.Verify(card => card.SetStatus(CardStatus.OnPlayer), Times.Once);
        }
	}
	
	[Test] 
	//Positive Testing
	//Method_ExpectedBehavior_StateUnderTest
	public void AddCards_ReturnsFalse_PlayerNotExist()
	{
		//Arrange
		Mock<ICard> card = new Mock<ICard>();
		Mock<IPlayer> newPlayer1 = new Mock<IPlayer>();
        Mock<IPlayer> newPlayer2 = new Mock<IPlayer>();

        List<Mock<IPlayer>> players = new();
        players.Add(newPlayer1);
        players.Add(newPlayer2);
        // players.Add(_player); // Comment -> will be true (FAILED the test)

        foreach(var player in players){
            //Act
            bool result = _game.AddCards(player.Object, card.Object);
            //Assert
            Assert.IsFalse(result);
            card.Verify(card => card.SetStatus(It.IsAny<CardStatus>()), Times.Never);
        }
	}
}