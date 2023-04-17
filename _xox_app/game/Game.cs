using _xox_app.models.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _xox_app.game
{
   public abstract class Game
    {
        public TurnState turn;
        protected APlayer player1;
        protected APlayer player2;
        protected short step;
        protected GameState state;
        // GameBoard is a static area. ui and Game (class) reads there and acts 

        public Game(APlayer player1, APlayer player2)
        {
            state = GameState.playing;
            step = 0;
            this.player1 = player1;
            this.player2 = player2;
            turn= whoPlaysFirst();
            //default board initialize
            GameBoard.startGameBoard(new string[3,3]);
        }

        //increment the step value here
        // run gameControll() for every move
        public abstract void play(int[] indexes);
        /*
        {
            if (turn == TurnState.turnP1)
            {
                // do something
                player1.makeMove(indexes);
                turn = TurnState.turnP2;
            }
            //turnp2 situation
            else {
                //do something
                player2.makeMove(indexes);
                turn = TurnState.turnP1;
            } 
        }
        */

        protected void gameControll() {
            if (step == ((short)GameBoard.getGameBoardSize()))
                end();
        }

        private void end()
        {
            // controll board situation via .dll file
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

        public override string ToString()
        {
            return "GameState: "+turn.ToString()+"\nplayer1: "+player1.ToString()+"\nplayer2: "+player2.ToString();
        }
    }
}
