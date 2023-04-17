using _xox_app.models.user;
using System;


namespace _xox_app.game
{
    public abstract class Game
    {
        public TurnState turn;
        protected APlayer player1;
        protected APlayer player2;

        protected short step;
        protected GameStates state;
        // GameBoard is a static area. ui and Game (class) reads there and acts 

        public Game(APlayer player1, APlayer player2)
        {
            state = GameStates.run;
            step = 0;
            this.player1 = player1;
            this.player2 = player2;
            turn = whoPlaysFirst();
            //default board initialize
            GameBoard.startGameBoard(new string[3, 3]);
            GameBoard.reset();
        }

        //increment the step value here
        // run gameControll() for every move
        public abstract void play(int[] indexes);

        
        protected void gameControll()
        {

            if (step == ((short)GameBoard.getGameBoardSize()))
                end();
            if (CheckWin(player1.getSide()))
                end();
            if (CheckWin(player2.getSide()))
                end();
        }


        protected TurnState getTurn()
        {
            return turn;
        }
        private TurnState whoPlaysFirst()
        {
            Random rnd = new Random();
            int num = rnd.Next();

            if (num % 2 == 0)
                return TurnState.turnP1;
            else
                return TurnState.turnP2;
        }

        //TODO: controll board situation via .dll file
        private void end()
        {

            state = GameStates.stop;
            /// send board data to xOxTEST
        }

        // returns winner.
        public APlayer getWinner() { return checkWinner(ref player1, ref player2); }

        // checks and returns winner player.
        private APlayer checkWinner(ref APlayer player1, ref APlayer player2)
        {
            // state of player1's victory
            if (CheckWin(player1.getSide()))
                player1.setState(PlayerStates.victory);
            else
                player1.setState(PlayerStates.defeat);

            // state of player2's victory
            if (CheckWin(player2.getSide()))
                player2.setState(PlayerStates.victory);
            else
                player2.setState(PlayerStates.defeat);


            //return winner
            if (player1.getState() == PlayerStates.victory)
                return player1;
            else if (player2.getState() == PlayerStates.victory)
                return player2;
            else
                return null;
        }


        // reads gameboard
        private bool CheckWin(string sign)
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




        public override string ToString()
        {
            return "GameState: " + turn.ToString() + "\nplayer1: " + player1.ToString() + "\nplayer2: " + player2.ToString();
        }
    }
}
