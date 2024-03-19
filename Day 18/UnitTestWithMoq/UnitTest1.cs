namespace SimpleGameProject.Test;

using Moq;

public class GameController
{
	private IList<IPlayer> _players;

	public GameController(IList<IPlayer> players)
	{
		_players = players;
	}

	public IList<IPlayer> GetListPlayers()
	{
		return _players;
	}
}
public interface ITotem
{

}
public interface IPlayer
{
	int Level{ get; set; }
	int ID { get; set; }
    // List<ITotem> Totems { get; set;}
	string GetName();
	bool SetName(string name);
}
[TestFixture]
public class GameControllerTest 
{
	[Test]
	public void GetListPlayers_ReturnRegisteredPlayers_PlayersAddedOnConstructor() 
	{
		//Arrange
		Mock<IPlayer> player1 = new Mock<IPlayer>();
		player1.SetupProperty(u => u.Level, 1);
		player1.SetupProperty(u => u.ID, 123);
		player1.Setup(p => p.GetName()).Returns("Joko");
		// player1.Setup(p => p.SetName(It.IsAny<string>())).Returns(true);
		
		Mock<IPlayer> player2 = new Mock<IPlayer>();
		player2.SetupProperty(u => u.Level, 2);
		player2.SetupProperty(u => u.ID, 156);
		player2.Setup(p => p.GetName()).Returns("Widodo");
		//player2.Setup(p => p.SetName(It.IsAny<string>())).Returns(true);
		
		List<IPlayer> players = new List<IPlayer>();
		players.Add(player1.Object);
		players.Add(player2.Object);
		
		GameController game = new GameController(players);
		
		//Act
		IList<IPlayer> result = game.GetListPlayers();
		
		//Assert
        // Assert.AreEqual(2, result.Count);
		Assert.That(result.Count, Is.EqualTo(2));

        // Assert.AreEqual("Joko", result[0].GetName());
        // Assert.AreEqual(1, result[0].Level);
        // Assert.AreEqual(123, result[0].ID);
		Assert.That(result[0].GetName(), Is.EqualTo("Joko"));
        Assert.That(result[0].Level, Is.EqualTo(1));
        Assert.That(result[0].ID, Is.EqualTo(123));

		// Assert.AreEqual("Widodo", result[1].GetName());
        // Assert.AreEqual(2, result[1].Level);
        // Assert.AreEqual(156, result[1].ID);
		Assert.That(result[1].GetName(), Is.EqualTo("Widodo"));
        Assert.That(result[1].Level, Is.EqualTo(2));
        Assert.That(result[1].ID, Is.EqualTo(156));
	}
}