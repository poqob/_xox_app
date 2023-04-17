using _xox_app.models.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _xox_app.game
{
    class SingleGame : Game
    {

        public SingleGame(String playerName, String playerID, Sides side) : base(new Player(playerName, playerID, side), new PlayerComputer(side == Sides.X ? Sides.O : side))
        {

        }

        public override void play(int[] indexes)
        {
            if (state == GameState.playing)
            {
                if (turn == TurnState.turnP1)
                {
                    // do something
                    player1.makeMove(indexes);
                    turn = TurnState.turnP2;
                    player2.makeMove(indexes);
                    turn = TurnState.turnP1;
                }
                //turnp2 situation
                else
                {
                    //do something
                    player2.makeMove(indexes);
                    turn = TurnState.turnP1;
                }
                step++;
                gameControll();
            }
        }
    }
}
