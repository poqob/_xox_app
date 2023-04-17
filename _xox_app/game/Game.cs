using _xox_app.models.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _xox_app.game
{
   public class Game
    {
        private TurnState turn;
          private Player player1;
        PlayerComputer player2;
        // GameBoard is a static area. ui and Game (class) reads there and acts 

        public Game(String playerName,String playerID,Sides side)
        {
            char c = side.ToString().First();
            player1 = new Player(playerName,playerID,c);
            player2 = new PlayerComputer(c=='X'?'O':'X');
            whoPlaysFirst();
            startGame();
        }
        private  void startGame()
        {
            if (turn == TurnState.turnP2)
            {
                //wait for move
                //player2.makeMove();
                turn = TurnState.turnP1;
            }
        }

        public  String play(int[] indexes)
        {
            if (turn == TurnState.turnP1)
            {
                turn = TurnState.turnP2;
                return GameBoard.move(indexes, player1);
            }
            else {
                turn = TurnState.turnP1;
                return GameBoard.move(indexes, player2);
            } 
        }

        public TurnState getTurn()
        {
            return turn;
        }
        private void whoPlaysFirst()
        {
            Random rnd = new Random();
            int num = rnd.Next();

            if (num % 2 == 0)
                turn = TurnState.turnP1;
            else
                turn = TurnState.turnP2;
        }

        public override string ToString()
        {
            return "GameState: "+turn.ToString()+"\nplayer1: "+player1.ToString()+"\nplayer2: "+player2.ToString();
        }
    }
}
