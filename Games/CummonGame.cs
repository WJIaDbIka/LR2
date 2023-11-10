namespace Games
{
	class CummonGame : Game
	{
		public CummonGame(string opponentName, bool isWin, int rating, int gameCount) : base(opponentName, isWin, rating, gameCount) {
			_gameType = "Cummon Game";
		}

		public override int CountRaiting()
		{
			return Rating;
		}
	}
}
