using Games;

namespace Accounts
{
    class GameAccount
    {
        public string UserName { get; set; }
        private int currentRating;
        public int CurrentRating
        {
            get { return currentRating; }
            set
            {
                if (value < 1)
                {
                    currentRating = 1;
                }
                else
                {
                    currentRating = value;
                }
            }
        }
        private List<Game> gameHistory = new List<Game>();

        public GameAccount(string userName, int currentRaiting)
        {
            UserName = userName;
            CurrentRating = currentRaiting;
        }

        virtual protected int CalcRate(bool isWin, int rating)
        {
            if (isWin)
            {
                return rating;
            } else
            {
                return -rating;
            }
        }

        public void WinGame(int rating)
        {
            CurrentRating += CalcRate(true, rating);
        }

        public void LoseGame(int rating)
        {
            CurrentRating += CalcRate(false, rating);
        }

        public void AddGame(Game game)
        {
            gameHistory.Add(game);
        }

        public void GetStats()
        {
            Console.WriteLine($"Game History for {UserName}:");
            Console.WriteLine("{0,-15} {1,-10} {2,-10} {3,-10} {4, -10} {5, -10}", "Opponent", "Result", "Current Rating", "Game Index", "Game Count", "Game Type");
            for (int i = 0; i < gameHistory.Count; i++)
            {
                Console.WriteLine("{0,-15} {1,-10} {2,-10} {3,-10} {4, -10} {5, -10}", gameHistory[i].OpponentName,
                                  gameHistory[i].IsWin ? "Win" : "Loss",
                                  gameHistory[i].CurrentRaiting,
                                  gameHistory[i].Id,
                                  gameHistory[i].GameCount,
                                  gameHistory[i]._gameType);
            }
        }
    }
}
