
using _xox_app.game;


namespace _xox_app.models.user
{
   public class PlayerComputer : APlayer
    {
        // default computer definition
        public PlayerComputer (Sides side) : base("Computer","00000000",side) { }

      
        private void  computeBoard() {


           
        }

        //run maxmin and do proper move
        public override string makeMove(int[] indexes)
        {






            return GameBoard.move(indexes, this);
        }




    }
}
