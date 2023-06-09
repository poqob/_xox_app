﻿
using _xox_app.models.user;

namespace _xox_app.game
{
    // here, our game board will became.
    public static class GameBoard
    {
        // definition of gameBoard
        private static string[,] gameBoard;

        public static void startGameBoard(string[,] board) { gameBoard = board; }

        public static int getGameBoardSize() { return gameBoard.Length; }

        //get board
        public static string[,] getGameBoard() { return gameBoard; }

        // make move
        //indexes={row,col}
        public static string move(int[] indexes, APlayer player)
        {
            gameBoard[indexes[0], indexes[1]] = player.getSide();
            return player.getSide().ToString();
        }

        public static void reset()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    gameBoard[i, j] = "";
                }
            }
        }

        // reads gameboard
        public static bool CheckWin(string sign)
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (GameBoard.getGameBoard()[i, 0] == sign && GameBoard.getGameBoard()[i, 1] == sign && GameBoard.getGameBoard()[i, 2] == sign)
                {
                    return true;
                }
            }

            // Check columns
            for (int j = 0; j < 3; j++)
            {
                if (GameBoard.getGameBoard()[0, j] == sign && GameBoard.getGameBoard()[1, j] == sign && GameBoard.getGameBoard()[2, j] == sign)
                {
                    return true;
                }
            }

            // Check diagonals
            if (GameBoard.getGameBoard()[0, 0] == sign && GameBoard.getGameBoard()[1, 1] == sign && GameBoard.getGameBoard()[2, 2] == sign)
            {
                return true;
            }
            if (GameBoard.getGameBoard()[0, 2] == sign && GameBoard.getGameBoard()[1, 1] == sign && GameBoard.getGameBoard()[2, 0] == sign)
            {
                return true;
            }

            return false;
        }




    }
}
