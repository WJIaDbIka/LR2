using Accounts;
using Games;

class Program
{
    static void Main()
    {
        Game.GameId = 1000;
        GameAccount player1 = new WinStreakAccount("Player1", 10);
        GameAccount player2 = new LowLooseRateAccount("Player2", 12);
        var gameStarter = new GameStarter.GameStarter(player1, player2);
        gameStarter.Start(GameType.CUMMON_GAME, 10);
        gameStarter.Start(GameType.TRAIN_GAME, 10);
		gameStarter.Start(GameType.DOUBLE_RATE_GAME, 10);

		player1.GetStats();
        Console.WriteLine();
        player2.GetStats();
    }
}
