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
        private GameState state;
        Player player1;
        PlayerComputer player2;
        // GameBoard is a static area. ui and Game (class) reads there and acts 

        public Game(String playerName,String playerID,Sides side)
        {
            char c = side.ToString().First();
            player1 = new Player(playerName,playerID,c);
            player2 = new PlayerComputer(c=='X'?'O':'X');
            whoPlaysFirst();
        }




        public GameState getState()
        {
            return state;
        }
        private void whoPlaysFirst()
        {
            Random rnd = new Random();
            int num = rnd.Next();

            if (num % 2 == 0)
                state = GameState.turnP1;
            else
                state = GameState.turnP2;
        }

        public override string ToString()
        {
            return "GameState: "+state.ToString()+"\nplayer1: "+player1.ToString()+"\nplayer2: "+player2.ToString();
        }
    }
}
