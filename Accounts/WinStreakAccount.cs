namespace Accounts
{
	class WinStreakAccount : GameAccount
	{
		private int streakCount = 0;
		public WinStreakAccount(string userName, int currentRaiting) : base(userName, currentRaiting) { }

		protected override int CalcRate(bool isWin, int rating)
		{
			if (isWin)
			{
				streakCount++;
				return rating + streakCount - 1;
			} else
			{
				streakCount = 0;
				return -rating;
			}
		}
	}
}
