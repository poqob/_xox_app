
using _xox_app.models.user;

namespace _xox_app.game
{
    // here, our game board will became.
    public static class GameBoard
    {
        // definition of gameBoard
        private static char[,] gameBoard = new char[3, 3];

        //get board
        public static char[,] getGameBoard() { return gameBoard; }

        // make move
        //indexes={row,col}
        public static void move(int[] indexes, APlayer player)
        {

            gameBoard[indexes[0], indexes[1]] =player.getSide();
        }


        
        
    }
}
