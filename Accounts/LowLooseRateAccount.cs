namespace Accounts
{
	class LowLooseRateAccount : GameAccount
	{
		public LowLooseRateAccount(string userName, int currentRaiting) : base(userName, currentRaiting) { }

		protected override int CalcRate(bool isWin, int rating)
		{
			if (isWin)
			{
				return rating;
			} else
			{
				return -rating / 2;
			}
		}
	}
}
