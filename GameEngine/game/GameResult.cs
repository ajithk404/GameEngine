namespace GameEngine.game
{
    public class GameResult
    {
        private bool IsOver;
        private string? Winner;

        public GameResult()
        {

        }
        public GameResult(bool IsOver, string Winner)
        {
            this.IsOver = IsOver;
            this.Winner = Winner;
        }

    }
}
