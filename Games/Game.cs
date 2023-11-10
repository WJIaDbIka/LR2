namespace Games
{
	enum GameType
	{
		CUMMON_GAME = 1,
		TRAIN_GAME = 2,
		DOUBLE_RATE_GAME = 3,
	}

    abstract class Game
    {
        public string OpponentName { get; }
        public bool IsWin { get; }
        public int Rating { get; }
        public int CurrentRaiting{ get; set; }
        public int GameCount { get; set; }
        public static int GameId;
        public int Id { get; set; }
        public string _gameType { get; set; }

	public Game(string opponentName, bool isWin, int rating, int gameCount)
        {
            OpponentName = opponentName;
            IsWin = isWin;
            Rating = rating;
            GameCount = gameCount;
            GameId += 10;
            Id = GameId;
        }

        abstract public int CountRaiting();
    }
}
