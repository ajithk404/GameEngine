using GameEngine.game;

namespace GameEngine.boards
{
    public class TicTacToeBoard : Board
    {
        string[,] Cells = new string[3, 3];

        public string getCell(int i, int j)
        {
            return Cells[i, j];
        }
    }
}
