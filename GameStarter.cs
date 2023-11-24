using Accounts;
using GameFactory;
using Games;

namespace GameStarter
{
	class GameStarter
	{
		private GameAccount Player1;
		private GameAccount Player2;
		private int GameCount;
		private GameCreator gameCreator;
		public GameStarter(GameAccount player1, GameAccount player2) {
			Player1 = player1;
			Player2 = player2;
			GameCount = 0;
			gameCreator = new GameCreator();
		}

		public void Start(GameType gameType, int rating)
		{
			GameCount++;
			var rand = new Random();
			if (rand.Next(0, 20)%2 == 0)
			{
				var player1Game = gameCreator.Create(gameType, Player2.UserName, true, rating, GameCount);
				var player2Game = gameCreator.Create(gameType, Player1.UserName, false, rating, GameCount);

				Player1.WinGame(player1Game.CountRaiting());
				Player2.LoseGame(player2Game.CountRaiting());

				player1Game.CurrentRaiting = Player1.CurrentRating;
				player2Game.CurrentRaiting = Player2.CurrentRating;

				Player1.AddGame(player1Game);
				Player2.AddGame(player2Game);
			} else
			{
				var player1Game = gameCreator.Create(gameType, Player2.UserName, false, rating, GameCount);
				var player2Game = gameCreator.Create(gameType, Player1.UserName, true, rating, GameCount);
				
				Player1.LoseGame(player1Game.CountRaiting());
				Player2.WinGame(player2Game.CountRaiting());

				player1Game.CurrentRaiting = Player1.CurrentRating;
				player2Game.CurrentRaiting = Player2.CurrentRating;

				Player1.AddGame(player1Game);
				Player2.AddGame(player2Game);
			}
		}
	}
}
