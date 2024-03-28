using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.boards;
using GameEngine.game;

namespace GameEngine
{
    internal class GameEngine
    {
        public Board Start()
        {
            return new TicTacToeBoard();
        }

        public void Move(Board board, Player player, Move move)
        {
            if(board is not TicTacToeBoard)
            {
                throw new InvalidOperationException();
            }

            board.SetCell(player.Symbol, move.getCell());

        }

        public GameResult IsComplete(Board board)
        {
            if (board is not TicTacToeBoard)
            {
                return new GameResult(false, "-");
            }
            TicTacToeBoard boardToe = (TicTacToeBoard)board;

            #region rowCheck
            bool isRowComplete = true;

            for (int i = 0; i < 3; i++)
            {
                string firstRowVal = boardToe.getCell(i,0);
                isRowComplete = true;
                for (int j = 1; j < 3; j++)
                {
                    if (firstRowVal != boardToe.getCell(i, j))
                    {
                        isRowComplete = false;
                        break;
                    }
                }

                if (isRowComplete)
                {
                    return new GameResult(true, "-");
                }
            }
            #endregion
            #region colCheck
            bool isColComplete = true;

            for (int i = 0; i < 3; i++)
            {
                string firstColVal = boardToe.getCell(0, i);
                isColComplete = true;
                for (int j = 1; j < 3; j++)
                {
                    if (firstColVal != boardToe.getCell(j, i))
                    {
                        isColComplete = false;
                        break;
                    }
                }

                if (isColComplete)
                {
                    return new GameResult(true, "-");
                }
            }
            #endregion

            #region diagnCheck
            bool isDiagnComplete = true;
            string firstVal = boardToe.getCell(0, 0);

            for (int i = 1; i < 3; i++)
            {
                if (firstVal != boardToe.getCell(i, i))
                {
                    isDiagnComplete = false;
                    break;
                }
            }

            if (isDiagnComplete)
            {
                return new GameResult(true, "-");
            }
            #endregion

            #region revDiagnCheck
            bool isRevDiagnComplete = true;
            string lastRowVal = boardToe.getCell(2, 0);

            for (int i = 1; i < 3; i++)
            {
                if (lastRowVal != boardToe.getCell(2-i, i))
                {
                    isRevDiagnComplete = false;
                    break;
                }
            }

            if (isRevDiagnComplete)
            {
                return new GameResult(true, "-");
            }
            #endregion

            int countOfFilledCells = 0;
            for(int i =0; i<3;i++)
            {
                for(int j =0; j<3;j++)
                {
                    if (boardToe.getCell(i, j) != null)
                    {
                        countOfFilledCells++;
                    }
                }
            }

            if (countOfFilledCells == 9)
            {
                return new GameResult(true,"-");
            }

            return new GameResult(false, "-");

        }
    }
}
