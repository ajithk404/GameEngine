namespace GameEngine.game
{
    public class Player
    {
        private string symbol;

        public Player(string symbol)
        {
            this.symbol = symbol;
        }
        public string Symbol { get { return symbol; } } 
    }
}
